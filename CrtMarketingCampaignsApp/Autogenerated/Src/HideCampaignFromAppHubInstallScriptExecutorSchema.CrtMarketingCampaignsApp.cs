namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HideCampaignFromAppHubInstallScriptExecutorSchema

	/// <exclude/>
	public class HideCampaignFromAppHubInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HideCampaignFromAppHubInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HideCampaignFromAppHubInstallScriptExecutorSchema(HideCampaignFromAppHubInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9309691-f5fd-411f-b0a1-64ed3ada8d17");
			Name = "HideCampaignFromAppHubInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e93a4a73-bac6-4521-8c50-1b385f4aa491");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,61,187,64,255,129,203,201,5,10,127,192,186,14,88,211,180,205,33,187,100,219,117,96,100,38,213,42,75,6,69,101,51,138,252,251,104,43,73,155,192,3,118,240,193,122,228,227,227,123,244,216,80,108,209,16,124,35,102,140,97,45,213,52,248,181,221,36,70,177,193,95,94,188,94,94,20,41,90,191,129,101,23,133,26,197,157,35,211,131,177,122,36,79,108,205,205,177,230,61,13,211,191,222,171,153,23,43,150,162,22,104,73,155,86,206,26,48,14,99,132,39,91,211,20,155,22,237,198,63,112,104,190,180,237,83,90,205,125,20,116,110,105,216,182,50,251,67,38,73,96,248,8,243,81,64,57,123,217,69,203,118,139,66,192,132,117,240,174,131,40,220,171,249,137,109,59,13,53,193,45,76,166,44,11,228,23,18,5,14,115,163,14,157,100,109,71,142,109,176,245,32,78,177,242,123,36,86,159,124,246,1,210,201,239,21,12,195,139,97,201,110,105,158,169,193,5,122,220,16,3,141,188,221,158,245,87,35,141,55,239,24,33,118,113,17,234,228,104,86,91,209,246,17,82,77,70,114,245,93,247,85,67,46,39,154,222,222,43,170,251,245,174,207,85,231,17,91,100,48,193,43,113,31,176,146,123,250,13,247,118,40,65,238,62,101,7,175,33,172,126,105,223,231,253,170,197,171,26,169,134,42,235,209,219,221,128,236,50,173,93,67,249,225,68,119,245,64,98,158,251,132,239,239,202,183,137,87,7,247,10,38,73,236,115,123,230,58,237,95,146,232,41,166,198,255,64,151,116,193,121,212,116,106,242,170,65,56,209,126,159,179,30,220,82,153,145,221,62,222,124,123,67,186,249,124,232,255,210,61,156,194,152,139,189,92,253,134,17,127,1,126,220,73,43,99,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9309691-f5fd-411f-b0a1-64ed3ada8d17"));
		}

		#endregion

	}

	#endregion

}

