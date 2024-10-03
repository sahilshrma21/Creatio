namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalConstantsSchema

	/// <exclude/>
	public class PortalConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalConstantsSchema(PortalConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0d4ff333-6c25-49dc-97f3-5f38c4c7f52d");
			Name = "PortalConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,65,107,27,49,16,133,207,49,248,63,44,57,181,135,105,36,173,100,73,132,30,180,90,169,244,16,18,226,228,84,122,80,215,178,189,176,214,154,149,150,96,74,254,123,229,56,109,234,4,218,128,175,195,155,121,223,188,153,49,182,97,85,204,119,49,249,205,229,116,50,157,4,183,241,113,235,26,95,220,249,97,112,177,95,166,79,186,15,203,118,53,14,46,181,125,152,78,126,78,39,103,219,241,71,215,54,69,76,185,214,20,77,231,98,44,110,250,33,185,46,139,115,53,164,152,85,123,229,217,197,197,183,60,223,132,212,166,221,188,89,251,141,187,245,205,109,187,90,167,121,63,14,141,255,190,23,29,207,27,188,91,244,161,219,21,95,198,118,81,252,179,251,250,33,248,161,248,92,4,255,240,164,254,112,62,155,25,133,185,229,80,91,92,3,69,76,128,196,90,1,146,138,32,198,107,163,140,56,255,120,121,146,171,26,211,186,63,182,165,132,32,109,171,236,195,48,5,74,181,1,85,215,8,48,146,21,163,21,35,72,208,83,109,175,92,24,93,151,165,127,27,11,69,168,80,168,4,35,21,219,47,141,65,74,33,129,10,86,149,82,99,65,57,58,213,184,246,75,55,118,233,200,215,82,108,16,153,9,48,37,201,11,19,146,115,54,210,0,211,21,215,90,162,89,41,127,231,252,242,6,87,253,98,236,222,117,242,131,242,240,83,87,174,13,55,110,229,191,46,142,8,176,148,154,75,170,1,83,107,128,86,132,128,194,88,1,65,70,102,184,146,50,81,191,33,80,139,77,27,238,67,155,222,3,241,71,172,186,238,128,114,31,253,16,95,113,112,130,42,206,177,6,195,21,7,106,203,124,129,252,10,192,136,174,9,214,37,47,165,125,226,120,166,120,94,202,199,152,119,186,219,109,255,159,199,155,14,221,111,182,93,78,37,189,66,97,172,212,178,82,22,42,146,115,161,26,113,168,74,193,64,81,75,149,152,89,109,41,121,137,228,113,58,121,220,83,253,2,237,59,172,234,6,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d4ff333-6c25-49dc-97f3-5f38c4c7f52d"));
		}

		#endregion

	}

	#endregion

}

