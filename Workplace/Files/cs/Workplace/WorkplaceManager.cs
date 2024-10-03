namespace Terrasoft.Configuration.Workplace
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Common;
	using Section;
	using Core;
	using Core.Factories;
	using WorkplaceApi;

	#region Class: WorkplaceManager

	[DefaultBinding(typeof(IWorkplaceManager))]
	public class WorkplaceManager : IWorkplaceManager
	{

		#region Fields: Private

		/// <summary>
		/// <see cref="IWorkplaceRepository"/> implementation instance.
		/// </summary>
		private readonly IWorkplaceRepository _workplaceRepository;

		/// <summary>
		/// <see cref="ISectionRepository"/> implementation instance.
		/// </summary>
		private readonly ISectionRepository _sectionRepository;

		/// <summary>
		/// <see cref="IResourceStorage"/> implementation instance.
		/// </summary>
		private readonly IResourceStorage _resourceStorage;

		/// <summary>
		/// Current user identifier.
		/// </summary>
		private readonly Guid _currentUserId;

		private readonly IWorkplaceSectionAccessManager _workplaceSectionAccessManager;

		#endregion

		#region Constructors: Public

		public WorkplaceManager(UserConnection uc) {
			_workplaceRepository = ClassFactory.Get<IWorkplaceRepository>(new ConstructorArgument("uc", uc));
			_sectionRepository = ClassFactory.Get<ISectionRepository>("General", new ConstructorArgument("uc", uc));
			_workplaceSectionAccessManager = ClassFactory.Get<IWorkplaceSectionAccessManager>(new ConstructorArgument("userConnection", uc));
			_resourceStorage = uc.ResourceStorage;
			_currentUserId = uc.CurrentUser.Id;
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Creates workplace exception message.
		/// </summary>
		/// <param name="exceptionMessageKey">Localizable string name.</param>
		/// <returns>Workplace exception message.</returns>
		private string GetWorkplaceExceptionMessage(string exceptionMessageKey) {
			return new LocalizableString(_resourceStorage, "SectionExceptionResources",
				$"LocalizableStrings.{exceptionMessageKey}.Value").ToString();
		}

		private WorkplaceDto ConvertToWorkplaceDto(Workplace source, IEnumerable<Section> sections)
		{
			var dto = new WorkplaceDto
			{
				Id = source.Id,
				Name = source.Name,
				Position = source.Position,
				Type = source.Type,
				IsPersonal = source.IsPersonal,
				LoaderId = source.LoaderId,
				LoaderName = source.LoaderName,
				ClientApplicationTypeId = source.ClientApplicationTypeId,
				HomePageUId = source.HomePageUId,
				Sections = sections.Select(ConvertToSectionDto).ToList()
			};
			return dto;
		}

		private SectionDto ConvertToSectionDto(Section source)
		{
			return new SectionDto
			{
				Id = source.Id,
				Caption = source.Caption,
				Code = source.Code,
				EntityUId = source.EntityUId,
				IconBackground = source.IconBackground,
				Image32Id = source.Image32Id,
				IsModule = source.IsModule,
				ModuleSchemaUId = source.ModuleSchemaUId,
				SchemaName = source.SchemaName,
				SysModuleVisaEntityUId = source.SysModuleVisaEntityUId,
				TypeColumnName = source.TypeColumnName,
				SysModuleEntityId = source.SysModuleEntityId,
				Type = source.Type,
			};
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns new workplace position.
		/// </summary>
		/// <param name="type">New workplace type.</param>
		/// <returns>New workplace position.</returns>
		protected int GetNewWorkplacePosition(WorkplaceType type) {
			var workplacePositions = GetWorkplacesByType(type).Select(w => w.Position);
			if (!workplacePositions.Any()) {
				return 0;
			}
			return workplacePositions.Max() + 1;
		}

		/// <summary>
		/// Retruns workplaces, which  position must be changed.
		/// </summary>
		/// <param name="workplace"><see cref="Workplace"/> that changed position instance.</param>
		/// <param name="position"><paramref name="workplace"/> new position.</param>
		/// <returns><see cref="Workplace"/> collection.</returns>
		protected IEnumerable<Workplace> GetWorkplacesToChange(Workplace workplace, int position) {
			var workplaces = GetWorkplacesByType(workplace.Type);
			IEnumerable<Workplace> result;
			if (workplace.Position > position) {
				result = workplaces.Where(w => w.Position >= position && w.Id != workplace.Id);
			} else {
				result = workplaces.Where(w => w.Position <= position && w.Id != workplace.Id);
			}
			return result.OrderBy(w => w.Position);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public IEnumerable<Workplace> GetCurrentUserWorkplaces(Guid applicationClientTypeId) {
			var allAllowedWorkplaces = _workplaceSectionAccessManager.GetAllAllowedWorkplacesIds();
			return _workplaceRepository.GetAll()
				.Where(workplace => workplace.ClientApplicationTypeId.Equals(applicationClientTypeId)
					&& workplace.GetIsAllowedForUser(_currentUserId)
					&& allAllowedWorkplaces.Contains(workplace.Id)).OrderBy(workplace => workplace.Position);
		}

		/// <inheritdoc />
		public IEnumerable<WorkplaceDto> GetAvailableWorkplaces(Guid userId, Guid applicationClientTypeId) {
			userId.CheckArgumentEmpty(nameof(userId));
			applicationClientTypeId.CheckArgumentEmpty(nameof(applicationClientTypeId));
			var result = _workplaceSectionAccessManager.GetAllowedWorkplacesForUser(userId)
				.Where(info => info.Workplace.ClientApplicationTypeId == applicationClientTypeId)
				.Select(info => ConvertToWorkplaceDto(info.Workplace, info.AllowedSections))
				.ToList();
			return result;
		}

		/// <inheritdoc />
		public IEnumerable<Workplace> GetWorkplacesByType(WorkplaceType type) {
			var result = _workplaceRepository.GetAll().Where(w => w.Type == type);
			return result;
		}

		/// <inheritdoc />
		public Workplace CreateWorkplace(CreateWorkplaceParameters parameters) {
			var position = GetNewWorkplacePosition(parameters.Type);
			var workplace = new Workplace(Guid.NewGuid(), parameters.Name, parameters.Type) {
				Position = position,
				HomePageUId = parameters.HomePageUId
			};
			if (_workplaceRepository.SaveWorkplace(workplace)) {
				return workplace;
			}
			var message = GetWorkplaceExceptionMessage("WorkplaceCreateFailed");
			throw new WorkplaceCreateFailedException(message);
		}

		/// <inheritdoc />
		public void ChangeName(Guid workplaceId, string name) {
			var workplace = _workplaceRepository.Get(workplaceId);
			workplace.SetName(name);
			_workplaceRepository.SaveWorkplace(workplace);
		}

		/// <inheritdoc />
		public void ChangePosition(Guid workplaceId, int position) {
			var workplace = _workplaceRepository.Get(workplaceId);
			if (workplace.Position == position) {
				return;
			}
			var workplacesToChange = GetWorkplacesToChange(workplace, position);
			var index = workplace.Position > position ? position + 1 : 0;
			foreach (var w in workplacesToChange) {
				if (w.Position != index) {
					w.Position = index;
					_workplaceRepository.SaveWorkplace(w);
				}
				index++;
			}
			workplace.Position = position;
			_workplaceRepository.SaveWorkplace(workplace);
		}

		/// <inheritdoc />
		public void DeleteWorkplace(Guid workplaceId) {
			_workplaceRepository.DeleteWorkplace(workplaceId);
		}

		/// <inheritdoc />
		public void AddSectionToWorkplace(Guid workplaceId, Guid sectionId) {
			var workplace = _workplaceRepository.Get(workplaceId);
			var section = _sectionRepository.Get(sectionId);
			workplace.AddSection(section.Id);
			_workplaceRepository.SaveWorkplace(workplace);
			_sectionRepository.ClearCache();
		}

		/// <inheritdoc />
		public void RemoveSectionFromWorkplace(Guid workplaceId, Guid sectionId) {
			var workplace = _workplaceRepository.Get(workplaceId);
			workplace.RemoveSection(sectionId);
			_workplaceRepository.SaveWorkplace(workplace);
			_sectionRepository.ClearCache();
		}

		/// <inheritdoc />
		public void ReloadWorkplaces() {
			_workplaceRepository.ClearCache();
			_sectionRepository.ClearCache();
		}

		#endregion

	}

	#endregion

}