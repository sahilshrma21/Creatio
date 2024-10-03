namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecommendationFilterItemsModeSchema

	/// <exclude/>
	public class RecommendationFilterItemsModeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecommendationFilterItemsModeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecommendationFilterItemsModeSchema(RecommendationFilterItemsModeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab1853cd-ba91-4c11-942e-58eb26dfa9d8");
			Name = "RecommendationFilterItemsMode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,77,107,195,48,12,134,207,9,228,63,8,118,45,201,189,140,29,90,50,216,97,151,209,177,179,235,200,153,153,63,50,217,134,149,210,255,94,217,253,32,165,131,193,110,126,229,87,143,94,201,9,139,97,18,18,97,131,68,34,120,21,219,181,119,74,143,137,68,212,222,65,83,239,155,186,169,171,7,194,49,235,222,37,187,132,55,148,222,90,116,67,49,61,107,19,145,94,34,218,240,234,7,44,254,174,235,224,49,36,107,5,237,158,206,58,127,130,87,160,138,31,180,3,186,225,176,252,78,24,98,123,233,239,102,128,41,109,141,150,128,60,255,175,241,21,71,174,238,18,148,194,123,224,4,206,236,64,103,59,40,242,118,22,103,34,28,180,204,204,246,74,152,103,168,62,62,185,111,81,22,252,157,223,255,72,147,120,203,255,225,87,70,200,47,126,28,78,39,231,5,79,87,207,146,107,71,83,25,44,244,174,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab1853cd-ba91-4c11-942e-58eb26dfa9d8"));
		}

		#endregion

	}

	#endregion

}

