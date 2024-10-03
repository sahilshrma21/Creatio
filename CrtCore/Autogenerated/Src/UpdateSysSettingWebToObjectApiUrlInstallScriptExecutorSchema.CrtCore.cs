namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSysSettingWebToObjectApiUrlInstallScriptExecutorSchema

	/// <exclude/>
	public class UpdateSysSettingWebToObjectApiUrlInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSysSettingWebToObjectApiUrlInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSysSettingWebToObjectApiUrlInstallScriptExecutorSchema(UpdateSysSettingWebToObjectApiUrlInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9564f345-428a-4286-97b5-b6825c5f7227");
			Name = "UpdateSysSettingWebToObjectApiUrlInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2c3f70d-d3a5-4d15-9bc6-62f67312edb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,49,79,195,48,16,133,231,84,234,127,56,101,74,165,54,129,181,85,7,4,8,149,133,33,45,140,200,113,47,197,197,181,45,251,146,130,80,255,59,151,164,160,166,2,196,96,203,103,61,125,239,249,25,140,216,97,112,66,34,44,209,123,17,108,73,233,181,53,165,218,84,94,144,178,102,56,248,24,14,162,42,40,179,233,73,60,206,190,239,155,41,127,15,57,18,241,24,96,126,166,236,19,211,19,41,51,152,226,170,66,43,9,82,139,16,96,229,214,130,78,112,79,88,44,237,67,177,69,73,87,78,173,188,94,152,64,66,235,92,122,229,232,246,13,101,69,214,79,97,241,227,61,211,155,252,145,243,170,102,44,72,203,42,8,228,155,220,207,86,175,59,57,99,57,117,252,66,228,194,52,203,246,88,144,23,242,149,69,147,250,226,50,45,220,206,26,173,12,166,210,238,178,251,60,147,30,153,54,177,109,172,116,27,226,217,239,38,6,247,255,50,105,153,202,254,101,209,154,116,101,213,86,173,161,123,37,38,171,128,158,59,54,172,228,130,161,234,141,35,104,27,136,106,225,161,22,186,66,14,145,116,225,70,103,63,151,222,33,61,54,146,164,143,24,67,220,117,31,143,218,135,70,170,132,228,200,154,247,107,252,114,139,206,209,124,184,193,242,111,250,184,223,214,209,236,208,236,205,198,235,208,148,240,9,191,32,113,232,182,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9564f345-428a-4286-97b5-b6825c5f7227"));
		}

		#endregion

	}

	#endregion

}

