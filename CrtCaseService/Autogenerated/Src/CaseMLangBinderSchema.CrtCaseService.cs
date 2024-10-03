namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseMLangBinderSchema

	/// <exclude/>
	public class CaseMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseMLangBinderSchema(CaseMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e64afc31-7e45-4a5f-b9cc-d14c8c88f3f2");
			Name = "CaseMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,107,131,64,16,62,39,144,255,48,164,151,20,138,222,147,16,48,98,64,208,24,26,105,207,171,78,236,130,238,202,238,42,13,161,255,189,227,170,37,9,61,45,243,189,230,177,130,213,168,27,150,35,164,168,20,211,242,98,28,95,138,11,47,91,197,12,151,98,49,191,45,230,179,86,115,81,62,72,20,58,7,150,27,169,56,234,205,63,138,79,204,72,85,215,82,16,75,188,235,66,156,124,4,144,38,224,51,141,103,84,29,167,174,222,33,13,222,33,140,79,81,16,7,199,212,75,195,228,232,88,195,139,194,146,250,131,95,49,173,215,214,20,71,76,148,123,46,10,84,99,166,11,91,221,214,53,83,215,221,88,247,58,168,219,202,240,138,196,45,43,17,242,62,1,50,235,115,38,155,123,231,107,218,172,226,249,168,123,106,180,6,175,105,130,14,133,137,184,54,40,80,237,73,64,166,155,29,225,111,204,24,205,151,44,104,208,147,13,27,200,49,88,118,116,22,94,32,116,146,23,144,8,74,60,27,166,204,106,138,166,139,27,252,54,144,15,239,43,244,55,159,205,50,234,228,220,201,39,122,99,89,123,152,225,15,174,78,63,236,54,140,198,149,67,131,244,123,82,189,217,109,158,209,221,106,217,195,203,33,231,103,220,3,69,49,172,98,235,1,125,4,9,251,5,151,210,13,167,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e64afc31-7e45-4a5f-b9cc-d14c8c88f3f2"));
		}

		#endregion

	}

	#endregion

}

