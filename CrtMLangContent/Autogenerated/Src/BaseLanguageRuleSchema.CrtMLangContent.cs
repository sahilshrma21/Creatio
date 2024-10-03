namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseLanguageRuleSchema

	/// <exclude/>
	public class BaseLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseLanguageRuleSchema(BaseLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168");
			Name = "BaseLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,65,110,131,48,16,60,39,82,254,176,34,151,228,18,238,105,146,67,57,68,72,61,68,105,251,128,141,89,144,37,176,209,218,62,68,85,255,94,99,2,2,71,173,122,220,97,118,152,25,175,194,134,76,139,130,224,131,152,209,232,210,238,50,173,74,89,57,70,43,181,90,45,191,86,203,133,51,82,85,240,126,55,150,154,151,113,158,174,48,121,220,127,89,51,85,126,13,178,26,141,217,195,43,26,122,67,85,57,172,232,234,106,10,156,52,77,225,96,92,211,32,223,79,143,185,35,2,222,140,101,20,22,68,183,13,165,102,207,35,2,193,84,30,147,124,42,148,164,39,144,77,91,83,67,202,6,167,102,55,72,167,19,237,214,221,106,41,98,229,216,22,236,33,159,219,92,116,177,199,52,23,214,45,177,149,228,35,93,130,98,8,242,148,36,0,159,134,24,132,86,138,68,231,107,55,18,167,190,6,99,29,57,27,185,241,24,76,44,42,178,93,233,139,239,254,167,107,82,69,239,235,49,15,149,251,14,44,59,97,53,255,199,102,198,132,150,12,72,191,133,202,95,128,46,167,109,199,21,249,194,127,73,18,144,22,25,27,80,254,156,142,137,155,133,72,78,113,33,135,52,176,251,26,88,91,15,83,241,244,38,155,168,139,185,234,246,209,77,68,58,70,180,191,122,139,79,227,236,100,1,103,178,131,137,188,216,4,200,31,152,180,247,43,9,205,69,94,108,59,201,94,113,46,232,177,31,77,118,71,169,78,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baa8372c-43b1-4ee1-aa11-be1c27d2f168"));
		}

		#endregion

	}

	#endregion

}

