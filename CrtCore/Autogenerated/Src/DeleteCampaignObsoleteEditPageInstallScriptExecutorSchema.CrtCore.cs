namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeleteCampaignObsoleteEditPageInstallScriptExecutorSchema

	/// <exclude/>
	public class DeleteCampaignObsoleteEditPageInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeleteCampaignObsoleteEditPageInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeleteCampaignObsoleteEditPageInstallScriptExecutorSchema(DeleteCampaignObsoleteEditPageInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4918a44-2bf5-4de4-958e-cfa8c88b5c33");
			Name = "DeleteCampaignObsoleteEditPageInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2c3f70d-d3a5-4d15-9bc6-62f67312edb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,111,218,48,20,125,14,210,254,195,93,158,130,84,34,24,76,133,177,238,33,225,67,60,116,157,68,247,60,25,231,2,158,28,59,178,29,182,180,226,191,207,177,105,27,74,186,205,15,81,236,123,206,185,95,7,4,201,81,23,132,34,220,163,82,68,203,173,137,83,41,182,108,87,42,98,152,20,240,216,1,123,74,205,196,14,214,149,54,152,79,47,94,44,133,115,164,53,94,199,75,20,168,24,109,65,45,185,220,16,206,30,156,112,51,222,204,157,231,111,199,20,190,29,137,231,194,48,195,80,79,59,14,83,148,27,206,40,104,99,179,81,160,156,104,13,41,201,11,194,118,226,27,217,161,62,117,118,1,85,72,50,41,120,5,203,146,101,112,199,179,39,22,220,128,192,95,238,57,10,63,78,6,73,127,48,24,247,146,97,154,246,70,227,15,163,94,50,74,134,189,121,186,232,247,175,211,201,96,56,158,132,93,95,238,241,172,34,95,202,12,57,26,124,146,190,219,104,89,223,231,25,51,117,113,43,97,139,225,124,77,21,43,204,252,55,210,210,72,5,159,96,213,30,120,238,4,158,127,10,197,14,196,32,28,164,109,226,71,246,215,108,209,119,141,202,110,93,248,21,218,241,54,175,93,43,31,4,129,27,111,181,166,123,204,201,45,17,150,166,0,91,222,110,94,209,227,22,226,244,69,16,116,165,111,101,86,114,87,141,101,183,104,90,75,25,143,78,170,175,214,176,81,184,110,146,194,171,215,21,59,253,3,81,64,165,176,128,218,150,167,229,205,152,67,16,85,125,214,70,89,23,93,129,220,252,180,180,47,190,203,224,17,194,85,102,21,207,172,18,55,93,112,172,113,71,151,2,216,22,162,247,103,29,196,11,52,116,191,80,50,159,37,209,75,250,238,105,138,129,181,151,41,149,240,116,175,114,206,247,198,136,78,214,241,246,105,172,213,123,200,109,213,175,255,63,182,7,141,99,246,76,199,255,242,195,197,56,27,165,184,239,241,93,231,15,80,106,35,11,59,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4918a44-2bf5-4de4-958e-cfa8c88b5c33"));
		}

		#endregion

	}

	#endregion

}

