namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapSyncJobSchedulerSchema

	/// <exclude/>
	public class IImapSyncJobSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapSyncJobSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapSyncJobSchedulerSchema(IImapSyncJobSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42c2b310-e629-40cf-90c2-3202b6197a53");
			Name = "IImapSyncJobScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,193,110,219,48,12,61,167,64,255,129,72,47,43,16,216,247,214,49,80,184,195,224,1,1,130,165,251,0,89,166,27,117,182,20,144,82,182,172,216,191,143,150,211,116,201,154,182,40,176,97,187,73,36,253,248,222,163,76,171,58,228,149,210,8,55,72,164,216,53,62,153,41,211,158,158,220,159,158,140,2,27,123,11,139,13,123,236,146,194,181,45,106,111,156,229,228,3,90,36,163,47,119,53,143,95,23,142,80,226,146,57,35,188,149,106,40,173,71,106,164,199,5,148,101,167,86,139,141,213,31,93,181,208,75,172,67,139,20,139,211,52,133,140,67,215,41,218,228,219,251,156,220,218,212,200,208,161,95,186,154,161,113,4,229,236,106,14,44,16,75,114,214,124,87,61,33,184,115,21,152,190,141,138,4,147,7,192,244,23,196,85,168,90,163,135,178,158,205,49,50,163,251,72,104,71,127,54,52,191,128,121,4,24,146,135,116,99,160,88,162,254,210,187,113,148,35,126,51,236,165,34,217,97,164,135,32,217,74,145,234,192,202,96,166,227,192,72,133,179,118,240,125,156,103,140,8,154,176,153,142,63,239,167,210,92,148,177,87,86,99,146,165,17,227,105,200,120,70,241,128,199,249,124,119,126,214,218,223,1,9,125,32,203,249,13,5,156,128,105,94,80,60,1,39,77,190,26,70,104,84,203,61,195,7,132,30,178,114,174,133,107,135,188,29,198,251,254,155,119,251,2,97,223,138,9,148,215,38,158,196,187,140,61,137,169,210,165,186,147,116,14,143,26,97,10,54,180,237,249,229,51,99,251,132,157,91,227,113,245,255,239,172,214,206,212,91,121,91,107,255,158,171,5,41,169,253,39,93,149,213,229,234,210,206,140,13,30,197,218,163,143,119,168,148,55,140,58,196,223,246,207,79,171,32,84,254,181,211,146,93,6,7,106,38,61,210,232,77,99,60,67,91,15,59,47,222,127,12,75,124,47,40,177,159,168,183,26,65,50,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42c2b310-e629-40cf-90c2-3202b6197a53"));
		}

		#endregion

	}

	#endregion

}

