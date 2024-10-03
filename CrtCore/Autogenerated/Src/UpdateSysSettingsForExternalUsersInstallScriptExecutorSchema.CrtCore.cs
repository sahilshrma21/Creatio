namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema

	/// <exclude/>
	public class UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema(UpdateSysSettingsForExternalUsersInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e1be858-f9fe-4d6b-a4d3-b2c71df20e6b");
			Name = "UpdateSysSettingsForExternalUsersInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1296b383-c2ef-47b8-ae67-0601cddb70e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,149,77,111,226,48,16,134,207,169,212,255,96,113,74,37,68,239,219,15,169,229,163,139,68,81,181,129,222,7,103,146,120,229,216,89,219,9,141,16,255,125,199,132,80,74,219,19,233,33,31,182,95,63,51,19,59,175,21,228,104,11,224,200,22,104,12,88,157,184,193,80,171,68,164,165,1,39,180,186,188,216,92,94,4,165,21,42,101,81,109,29,230,52,46,37,114,63,104,7,79,168,208,8,126,115,208,28,99,12,126,215,63,24,43,39,156,64,75,2,146,20,229,74,10,206,184,4,107,217,178,136,193,33,197,138,208,57,154,106,39,218,140,223,28,26,5,114,105,209,216,169,178,14,164,140,184,17,133,27,191,33,47,157,54,191,216,244,203,126,162,111,118,49,218,32,149,22,49,107,70,49,244,60,42,87,53,229,176,242,67,243,138,249,210,131,160,2,195,236,123,58,51,97,221,29,83,184,102,254,237,118,36,118,98,48,245,173,117,134,4,125,166,87,127,137,112,127,191,159,31,120,237,247,178,86,21,108,88,111,168,99,236,245,89,239,89,168,23,250,22,107,109,226,25,170,212,101,189,109,35,218,246,59,64,70,5,114,1,114,152,1,85,91,42,215,41,124,94,230,126,71,252,12,124,166,215,104,56,88,252,25,252,178,40,58,199,211,22,155,227,58,202,80,202,243,97,109,162,191,105,231,105,83,255,65,78,141,238,18,125,210,58,149,184,128,244,25,20,164,104,58,129,78,160,18,92,171,137,209,249,209,79,125,62,122,36,44,172,36,62,196,21,40,142,241,171,176,37,200,113,146,144,190,3,250,97,59,107,55,254,71,224,133,246,94,49,211,169,80,231,195,39,66,162,183,52,101,189,137,142,80,213,222,74,78,184,219,155,221,35,33,187,4,158,177,240,163,13,145,77,197,98,103,90,66,157,186,83,107,92,193,206,101,235,163,225,125,199,221,137,211,53,118,92,71,60,195,28,246,107,79,214,238,154,238,199,122,78,167,68,216,59,94,189,254,169,87,54,201,6,34,97,225,105,184,193,4,29,207,252,250,143,30,195,47,42,184,58,228,27,124,154,74,45,58,110,202,92,189,130,44,41,135,169,141,162,151,135,10,132,244,107,79,105,56,83,98,27,60,184,190,254,12,128,10,195,86,208,124,224,221,221,223,232,218,250,179,225,63,126,63,113,210,5,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e1be858-f9fe-4d6b-a4d3-b2c71df20e6b"));
		}

		#endregion

	}

	#endregion

}

