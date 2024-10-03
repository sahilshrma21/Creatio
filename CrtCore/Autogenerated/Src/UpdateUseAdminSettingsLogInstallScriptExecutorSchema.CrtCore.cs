namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateUseAdminSettingsLogInstallScriptExecutorSchema

	/// <exclude/>
	public class UpdateUseAdminSettingsLogInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateUseAdminSettingsLogInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateUseAdminSettingsLogInstallScriptExecutorSchema(UpdateUseAdminSettingsLogInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f7c9664-5105-4029-8b26-c4687ac462ee");
			Name = "UpdateUseAdminSettingsLogInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2c3f70d-d3a5-4d15-9bc6-62f67312edb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,193,74,3,49,16,134,207,41,244,29,134,122,105,161,236,3,84,60,72,241,80,176,80,88,235,61,38,211,109,32,157,44,147,137,40,197,119,55,217,213,98,138,30,188,229,159,249,243,229,159,9,233,19,198,94,27,132,39,100,214,49,28,164,89,7,58,184,46,177,22,23,104,58,57,79,39,42,69,71,93,101,97,188,189,212,139,106,223,99,139,34,89,70,184,187,114,214,196,230,135,53,51,50,229,134,177,203,13,88,123,29,227,10,246,189,213,130,251,136,247,246,228,232,219,250,24,186,13,69,209,222,183,134,93,47,15,111,104,146,4,30,8,142,4,153,180,7,83,16,255,36,192,10,54,127,160,213,121,192,95,18,110,81,142,193,230,140,187,244,226,157,25,155,253,112,134,215,224,44,140,87,113,158,223,230,60,53,161,41,35,67,170,228,2,202,78,149,186,218,91,147,15,207,218,39,156,215,246,37,204,126,25,101,182,4,225,132,139,242,13,234,227,43,38,146,29,147,14,122,172,214,197,92,251,4,8,198,139,36,244,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f7c9664-5105-4029-8b26-c4687ac462ee"));
		}

		#endregion

	}

	#endregion

}

