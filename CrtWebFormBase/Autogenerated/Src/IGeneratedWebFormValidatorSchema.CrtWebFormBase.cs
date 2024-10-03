namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormValidatorSchema

	/// <exclude/>
	public class IGeneratedWebFormValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormValidatorSchema(IGeneratedWebFormValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61c26b2e-18c1-4d99-9cd7-da3ae5fc724c");
			Name = "IGeneratedWebFormValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,106,195,48,16,68,207,49,248,31,68,78,237,197,250,128,186,190,20,26,124,109,66,123,86,172,149,89,176,86,102,37,165,152,144,127,175,212,216,105,177,111,210,238,204,206,99,72,89,240,163,234,64,156,128,89,121,103,66,245,230,200,96,31,89,5,116,84,29,128,32,61,65,127,193,249,221,177,61,2,95,176,131,178,184,150,197,46,122,164,94,28,39,31,192,190,148,69,154,72,41,69,237,163,181,138,167,102,254,127,170,1,117,58,225,69,143,23,32,49,40,210,217,7,20,48,76,213,226,146,255,108,99,60,15,216,9,164,0,108,50,94,187,230,152,143,58,78,234,140,178,73,94,69,111,67,183,169,247,201,168,88,89,65,169,153,215,253,247,61,172,213,251,166,213,217,106,16,88,56,179,156,171,106,249,43,255,115,51,132,200,228,155,150,124,80,148,200,147,120,166,72,117,126,128,143,67,168,229,162,202,182,245,246,1,253,116,136,168,197,3,225,57,53,188,187,149,197,45,23,253,3,142,60,231,143,185,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61c26b2e-18c1-4d99-9cd7-da3ae5fc724c"));
		}

		#endregion

	}

	#endregion

}

