namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationSchema

	/// <exclude/>
	public class INotificationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationSchema(INotificationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc959941-3df6-44cb-bc9f-61641c97b720");
			Name = "INotification";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,74,196,48,16,199,207,91,232,59,204,81,47,201,3,180,244,34,82,122,89,68,125,129,108,156,148,64,51,41,147,68,88,138,239,110,218,253,32,171,184,120,200,33,51,191,255,7,67,202,97,152,149,70,120,71,102,21,188,137,226,201,147,177,99,98,21,173,167,186,90,234,106,151,130,165,17,222,142,33,162,203,251,105,66,189,46,131,232,145,144,173,110,234,42,83,82,74,104,67,114,78,241,177,59,255,7,138,200,102,13,48,158,129,124,180,198,234,205,25,102,246,159,246,3,89,92,164,178,208,206,233,48,89,13,246,42,31,246,133,54,3,203,22,249,43,115,27,188,98,76,76,225,38,78,92,105,249,19,111,249,196,119,101,132,104,229,101,188,114,195,51,37,135,172,14,19,182,55,85,6,50,190,131,30,99,57,12,15,143,205,157,126,61,251,52,3,229,219,255,209,42,68,94,15,126,226,22,24,49,54,240,117,199,240,229,124,202,127,120,238,51,81,88,238,242,3,168,171,205,253,27,163,11,55,49,14,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc959941-3df6-44cb-bc9f-61641c97b720"));
		}

		#endregion

	}

	#endregion

}

