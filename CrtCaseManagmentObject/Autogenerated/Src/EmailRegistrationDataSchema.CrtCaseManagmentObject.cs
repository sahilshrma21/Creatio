namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailRegistrationDataSchema

	/// <exclude/>
	public class EmailRegistrationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailRegistrationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailRegistrationDataSchema(EmailRegistrationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456");
			Name = "EmailRegistrationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,107,195,48,12,61,167,208,255,32,218,203,6,163,185,175,31,48,186,49,122,24,148,109,127,64,75,148,32,104,156,96,59,133,82,246,223,39,59,105,235,182,233,8,219,205,146,245,244,158,172,103,133,5,153,10,19,130,79,210,26,77,153,217,201,178,84,25,231,181,70,203,165,26,14,246,195,65,84,27,86,57,124,236,140,165,98,58,28,72,102,172,41,151,107,88,110,208,152,71,120,41,144,55,239,146,50,182,193,61,163,69,41,139,227,24,102,166,46,10,212,187,69,27,75,127,139,172,72,67,86,106,32,135,4,81,97,48,39,51,57,96,226,0,84,213,95,27,78,32,113,84,55,153,156,204,163,170,181,46,43,210,150,73,164,173,61,218,139,190,146,227,19,171,148,148,229,140,69,80,153,65,162,9,45,165,240,148,88,222,178,221,77,142,184,80,210,65,211,107,205,167,210,85,26,237,33,39,59,133,74,243,86,186,128,145,32,250,238,205,237,103,123,107,158,194,141,213,131,187,155,19,250,115,86,168,37,252,11,245,218,35,91,204,42,133,255,205,46,174,216,146,54,126,165,61,200,195,114,199,237,238,35,207,239,120,93,212,159,250,176,242,4,13,245,161,150,178,211,184,225,115,143,73,165,141,3,93,28,26,82,228,138,95,235,196,150,186,151,37,165,26,149,252,74,81,55,51,68,78,98,54,31,117,122,127,20,47,192,238,170,64,185,172,20,11,80,242,181,231,35,76,216,54,222,28,45,206,167,62,26,124,22,123,192,162,19,207,87,184,43,167,252,138,175,206,77,114,217,236,150,251,174,122,118,109,163,243,57,238,252,142,78,99,63,52,75,227,195,225,66,208,125,107,157,211,31,134,121,128,246,78,138,124,146,219,224,210,246,243,203,150,161,251,66,71,180,185,48,37,153,31,209,221,220,112,130,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456"));
		}

		#endregion

	}

	#endregion

}

