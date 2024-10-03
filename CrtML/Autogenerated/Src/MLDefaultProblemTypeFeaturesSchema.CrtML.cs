namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDefaultProblemTypeFeaturesSchema

	/// <exclude/>
	public class MLDefaultProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDefaultProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDefaultProblemTypeFeaturesSchema(MLDefaultProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0");
			Name = "MLDefaultProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,208,177,106,195,48,16,6,224,57,6,191,195,141,246,98,239,77,219,161,41,161,5,155,118,200,86,58,156,157,147,17,200,146,57,157,2,193,248,221,171,216,78,73,105,70,29,255,125,220,47,139,61,249,1,91,130,3,49,163,119,74,138,157,179,74,119,129,81,180,179,69,93,165,201,152,38,155,224,181,237,254,164,152,138,61,182,226,88,147,223,166,73,204,148,101,9,143,62,244,61,242,249,121,125,191,146,194,96,4,20,161,4,38,56,161,9,228,65,57,6,52,6,6,118,141,161,30,228,60,144,47,174,70,121,131,124,173,194,139,182,199,120,66,118,73,58,149,189,215,213,231,178,123,136,131,253,162,251,60,255,142,43,67,104,140,110,161,53,232,61,212,213,10,220,137,195,3,220,119,34,50,206,149,254,117,154,7,111,232,193,5,25,130,64,38,200,29,73,14,173,51,161,183,115,177,222,29,201,128,48,106,27,47,46,126,153,219,90,215,35,79,154,37,160,129,198,57,115,113,63,102,118,183,96,35,68,122,11,19,60,69,45,80,252,229,205,148,38,211,229,178,31,40,110,148,206,186,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0"));
		}

		#endregion

	}

	#endregion

}

