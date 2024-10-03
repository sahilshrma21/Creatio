namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportDefMailBoxSchema

	/// <exclude/>
	public class SupportDefMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportDefMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportDefMailBoxSchema(SupportDefMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f94f800-c500-433f-bc1d-fcfd77df71cb");
			Name = "SupportDefMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,77,79,195,48,12,134,207,65,226,63,88,229,50,36,212,222,97,219,129,79,113,64,66,42,112,69,161,117,71,164,54,169,156,100,48,16,255,29,55,105,7,237,24,71,59,175,237,215,79,18,45,27,180,173,44,16,30,144,72,90,83,185,244,194,232,74,173,60,73,167,140,62,60,248,60,60,16,222,42,189,26,73,8,207,182,249,124,99,29,54,57,58,199,145,133,197,68,56,110,152,178,122,144,114,11,110,114,68,184,226,3,184,168,165,181,167,144,251,182,53,228,46,177,186,147,170,62,55,239,65,148,101,25,204,173,111,26,73,155,101,31,223,147,89,171,18,45,52,44,132,23,243,14,21,153,6,108,176,3,182,31,50,20,103,191,170,91,255,82,171,2,138,110,226,238,64,56,133,219,63,92,136,142,196,214,237,181,194,186,100,187,247,164,214,210,97,48,41,218,24,0,161,44,141,174,55,240,104,145,120,125,141,69,183,59,60,251,81,28,247,23,71,168,203,216,181,143,7,32,70,91,71,190,112,134,186,65,193,115,84,76,105,132,196,173,86,78,201,90,125,32,104,124,3,197,197,82,243,205,154,138,181,136,80,16,86,139,100,103,177,36,219,118,24,49,138,153,86,146,108,64,243,51,89,36,99,243,201,178,91,14,138,109,98,158,5,113,168,237,1,239,12,155,77,128,140,91,30,67,64,44,38,152,248,69,237,112,19,226,235,127,120,119,232,94,77,249,131,77,136,189,224,110,208,129,141,78,195,83,218,243,146,210,127,48,17,58,79,218,46,243,113,155,116,158,13,39,191,168,240,165,118,223,134,199,206,134,141,163,106,242,147,82,86,60,201,218,227,60,86,44,103,19,48,39,48,92,103,142,180,86,5,94,117,115,147,147,126,66,122,213,180,110,115,188,143,86,32,18,243,99,136,156,251,6,172,196,4,189,24,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f94f800-c500-433f-bc1d-fcfd77df71cb"));
		}

		#endregion

	}

	#endregion

}

