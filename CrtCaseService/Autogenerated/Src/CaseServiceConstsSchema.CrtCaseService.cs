namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseServiceConstsSchema

	/// <exclude/>
	public class CaseServiceConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseServiceConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseServiceConstsSchema(CaseServiceConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77");
			Name = "CaseServiceConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,207,106,194,64,16,198,207,10,190,195,98,47,237,97,197,252,51,166,210,67,118,141,165,151,34,49,47,176,221,140,178,16,119,211,157,141,32,165,239,222,77,164,151,210,82,241,54,51,223,199,247,27,134,209,226,8,216,10,9,164,2,107,5,154,189,155,113,163,247,234,208,89,225,148,209,228,99,50,158,140,71,29,42,125,32,187,51,58,56,174,134,201,157,133,67,175,243,70,32,62,146,109,247,214,40,57,40,237,80,18,116,62,64,18,217,235,132,11,132,29,216,147,146,224,227,209,97,159,59,250,97,181,32,106,163,155,51,121,238,84,77,74,64,211,116,253,14,175,198,169,189,146,195,62,85,219,188,212,228,105,176,204,182,194,34,220,79,195,40,73,51,158,49,154,175,163,144,198,73,56,167,203,40,137,104,202,242,40,207,57,75,162,60,155,62,172,254,3,22,232,212,113,128,148,240,222,1,186,223,88,124,185,97,193,124,19,80,230,145,52,102,139,152,102,235,32,161,105,184,137,231,69,145,6,139,148,93,193,202,165,83,39,229,206,62,213,139,170,21,218,149,166,129,202,120,220,183,118,57,212,236,79,235,173,16,46,175,134,112,121,43,132,201,235,41,222,219,99,62,47,127,5,186,190,188,86,223,250,217,23,208,197,215,126,163,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77"));
		}

		#endregion

	}

	#endregion

}

