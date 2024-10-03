namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChangeXssProtectionRuleInstallScriptSchema

	/// <exclude/>
	public class ChangeXssProtectionRuleInstallScriptSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChangeXssProtectionRuleInstallScriptSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChangeXssProtectionRuleInstallScriptSchema(ChangeXssProtectionRuleInstallScriptSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("afeef6a5-c2d5-4f32-b19c-1a16404b2bfc");
			Name = "ChangeXssProtectionRuleInstallScript";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("115a8564-8a4e-4951-9e36-143f7496ab3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,219,110,218,64,16,125,6,137,127,152,184,47,118,4,148,75,210,20,18,138,184,139,135,84,81,105,171,62,248,101,179,30,96,43,179,70,123,33,65,132,127,239,248,66,67,8,86,43,89,90,237,236,204,57,51,115,102,44,217,10,245,154,113,132,239,168,20,211,209,220,84,7,145,156,139,133,85,204,136,72,150,138,187,82,177,96,181,144,11,152,109,181,193,213,237,201,157,252,195,16,121,236,172,171,19,148,168,4,127,245,57,134,85,152,103,175,142,164,17,70,160,142,29,232,251,160,112,65,120,48,8,153,214,109,24,44,153,92,224,47,173,31,84,100,82,170,111,54,196,169,212,134,133,225,140,43,177,54,105,224,218,62,134,130,3,143,227,254,43,12,218,48,125,99,24,61,35,183,38,82,4,22,87,30,131,254,77,231,30,205,50,10,40,161,135,132,230,240,156,145,18,136,161,35,41,101,11,19,52,239,152,221,31,26,21,181,87,166,38,176,111,174,101,152,88,17,128,8,60,72,152,11,41,210,140,47,113,197,238,153,100,11,84,128,103,108,157,19,160,234,153,192,219,35,68,120,62,77,44,179,119,206,193,147,166,38,125,239,111,191,210,184,184,14,233,254,174,52,167,124,146,132,151,50,110,152,2,30,201,64,36,243,65,12,18,159,96,40,18,23,166,182,119,218,40,26,135,50,68,143,191,41,238,75,86,121,97,7,206,52,32,76,234,199,62,177,236,83,56,133,198,42,9,23,57,21,84,199,104,248,114,172,162,213,176,239,190,210,122,208,5,105,195,144,196,206,9,76,208,137,233,72,206,77,68,228,233,52,252,67,184,131,94,113,173,249,173,61,59,16,167,19,16,119,39,158,2,215,217,53,107,141,126,175,85,111,84,122,173,222,85,229,170,126,125,83,233,141,135,205,202,117,179,85,187,105,244,62,141,62,215,106,123,199,203,250,44,230,224,230,113,95,116,146,234,15,105,22,242,154,55,67,67,187,108,87,242,39,11,45,233,156,28,36,130,227,118,219,119,47,190,111,231,243,58,247,124,95,95,250,254,199,174,235,250,254,211,101,219,235,122,58,89,28,39,203,36,31,158,109,208,205,156,246,89,191,179,253,66,25,164,43,150,89,246,217,111,224,216,94,42,38,250,252,1,84,78,55,121,178,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afeef6a5-c2d5-4f32-b19c-1a16404b2bfc"));
		}

		#endregion

	}

	#endregion

}

