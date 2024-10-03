namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultOpenIdUserChangeValidatorSchema

	/// <exclude/>
	public class DefaultOpenIdUserChangeValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultOpenIdUserChangeValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultOpenIdUserChangeValidatorSchema(DefaultOpenIdUserChangeValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ec53e46-ef7a-45a0-abd4-217bf5a8fdf0");
			Name = "DefaultOpenIdUserChangeValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cafc62fc-f7d7-4a5d-acf5-62f836ef940a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,205,110,226,48,16,62,131,196,59,120,179,151,68,66,121,128,118,187,18,132,82,113,160,173,22,186,151,170,7,19,79,192,146,99,35,255,116,21,33,222,125,199,118,182,77,80,89,184,32,50,158,239,103,190,177,137,164,53,152,61,45,129,172,65,107,106,84,101,243,66,201,138,111,157,166,150,43,153,63,237,65,46,216,196,217,221,104,120,24,13,7,206,112,185,37,171,198,88,168,111,63,190,187,104,13,231,234,249,189,180,220,114,48,103,27,230,180,180,74,247,58,80,106,5,214,226,95,67,238,78,251,251,94,59,173,136,71,134,239,26,182,120,64,10,65,141,185,33,51,168,168,19,54,142,244,98,64,23,59,42,183,240,155,10,206,40,234,6,204,107,219,53,229,146,33,83,106,155,61,168,42,93,156,69,101,217,27,194,246,110,35,120,73,74,175,116,81,136,220,144,243,124,72,118,8,78,62,236,47,193,238,20,195,1,158,131,72,60,108,5,55,74,9,82,80,25,73,60,93,26,56,149,148,80,250,84,136,235,125,142,73,88,66,67,76,99,38,172,230,242,69,114,187,84,140,87,28,88,70,252,138,7,131,64,74,133,80,127,150,84,58,42,60,227,47,37,32,246,149,33,109,114,23,90,7,157,208,243,7,176,56,134,131,244,84,51,105,175,209,255,41,147,49,169,168,48,144,221,6,106,94,145,244,130,137,127,134,7,26,172,211,146,88,237,32,130,143,225,247,193,113,22,2,88,48,188,60,95,141,236,61,175,113,197,172,80,194,213,50,216,255,225,97,63,211,100,193,146,214,202,59,213,196,148,59,168,41,210,244,135,139,151,186,89,133,83,116,74,183,160,61,233,66,26,75,101,9,211,230,17,31,89,154,172,58,226,61,218,78,221,123,12,60,121,161,129,90,136,212,39,105,182,88,99,53,102,254,250,70,202,96,220,172,213,28,108,185,67,138,67,27,247,108,229,54,24,105,50,65,216,59,36,228,248,25,235,183,174,106,30,128,115,173,234,217,52,237,29,196,161,242,103,205,107,170,155,152,80,238,199,25,183,161,142,79,212,179,75,11,241,226,209,121,190,48,143,78,136,39,125,95,239,113,198,158,238,87,59,137,40,220,202,231,108,217,117,114,215,110,221,223,122,228,111,227,202,200,93,255,198,92,131,185,228,167,45,135,91,30,234,199,246,165,131,100,241,177,135,239,88,237,23,143,100,52,252,11,39,93,13,103,176,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ec53e46-ef7a-45a0-abd4-217bf5a8fdf0"));
		}

		#endregion

	}

	#endregion

}

