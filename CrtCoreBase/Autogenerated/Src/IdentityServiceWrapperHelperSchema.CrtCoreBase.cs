namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IdentityServiceWrapperHelperSchema

	/// <exclude/>
	public class IdentityServiceWrapperHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IdentityServiceWrapperHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IdentityServiceWrapperHelperSchema(IdentityServiceWrapperHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5f50835-6d49-4295-bff7-bbe844c6a4ae");
			Name = "IdentityServiceWrapperHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,63,79,195,64,12,197,231,68,202,119,56,117,106,150,8,49,82,254,168,170,72,201,196,16,16,179,123,117,195,73,225,238,100,251,42,42,212,239,142,155,136,1,148,12,12,231,193,254,189,231,231,243,240,129,28,193,162,121,65,34,224,112,144,106,19,252,193,117,137,64,92,240,69,254,85,228,89,98,231,187,95,8,225,106,166,95,213,96,37,144,67,158,34,158,215,73,222,27,47,216,141,254,202,40,21,211,174,119,214,176,104,207,26,219,3,179,105,246,232,197,201,169,69,58,58,139,111,4,49,34,61,97,175,85,37,151,88,127,116,205,180,196,108,81,26,175,140,183,184,44,205,32,204,142,64,198,77,227,119,102,219,135,29,244,235,24,91,20,209,252,92,213,8,146,8,95,25,91,140,160,209,241,103,84,7,26,110,186,190,26,124,179,7,179,185,196,31,63,225,84,233,238,219,153,92,247,203,197,227,167,32,121,93,101,45,50,47,202,209,226,230,31,22,229,106,208,16,106,60,63,115,209,128,156,181,232,59,155,34,255,6,169,170,122,213,245,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5f50835-6d49-4295-bff7-bbe844c6a4ae"));
		}

		#endregion

	}

	#endregion

}

