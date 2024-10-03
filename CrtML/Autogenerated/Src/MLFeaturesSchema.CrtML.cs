namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLFeaturesSchema

	/// <exclude/>
	public class MLFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLFeaturesSchema(MLFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67fb55d9-3f15-424b-9ada-e5b443f524e0");
			Name = "MLFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,79,49,110,195,48,12,156,101,192,127,32,210,165,93,252,128,4,29,138,180,5,2,196,104,135,244,1,140,76,43,2,92,201,32,165,44,65,254,94,202,114,134,46,148,112,119,60,222,5,252,37,153,209,18,156,136,25,37,142,169,219,199,48,122,151,25,147,143,161,235,143,109,115,107,27,147,197,7,7,123,166,2,119,159,250,100,166,83,116,110,82,124,215,54,42,153,243,121,242,22,236,132,34,208,31,87,141,40,83,12,254,211,63,66,95,111,57,93,96,11,171,174,167,132,3,38,44,210,219,226,103,204,19,147,211,16,160,145,36,113,182,41,178,108,225,123,49,90,37,171,235,195,239,249,5,150,99,198,28,228,35,224,121,162,1,94,65,119,105,87,225,119,18,203,126,46,221,148,216,232,30,212,32,168,131,66,242,118,233,13,99,100,237,0,66,124,245,150,54,117,251,254,200,69,97,168,209,42,80,113,157,119,40,191,63,252,108,63,188,86,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67fb55d9-3f15-424b-9ada-e5b443f524e0"));
		}

		#endregion

	}

	#endregion

}

