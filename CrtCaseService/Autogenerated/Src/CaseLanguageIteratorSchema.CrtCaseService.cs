namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseLanguageIteratorSchema

	/// <exclude/>
	public class CaseLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseLanguageIteratorSchema(CaseLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf");
			Name = "CaseLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,106,195,48,16,60,59,144,127,88,220,75,2,193,190,231,117,72,122,9,180,80,210,230,84,122,80,212,181,17,200,146,209,131,54,45,249,247,174,20,39,177,211,208,199,193,8,237,206,204,206,174,214,138,85,104,107,198,17,158,208,24,102,117,225,178,165,86,133,40,189,97,78,104,213,239,125,246,123,137,183,66,149,29,136,193,73,191,71,153,27,131,37,193,96,41,153,181,99,88,50,139,119,76,149,158,149,184,114,72,26,218,68,92,158,231,48,181,190,170,152,217,205,155,251,17,0,5,125,82,88,23,138,108,119,192,73,4,100,163,98,179,35,59,111,209,107,191,149,130,3,15,85,175,22,133,49,44,174,122,73,66,63,103,219,90,89,103,60,167,20,185,127,136,170,209,239,55,195,7,199,74,56,193,164,248,64,11,10,223,64,16,155,41,154,158,46,8,140,8,220,96,49,75,175,25,74,243,121,6,39,225,252,82,121,90,51,195,42,80,244,30,179,212,91,52,228,76,33,15,79,144,206,55,116,7,126,10,100,211,60,162,35,185,153,196,181,146,131,77,71,7,186,178,195,192,78,198,176,37,230,224,34,5,113,72,201,81,112,237,37,53,60,139,45,175,218,193,231,151,6,153,132,212,61,19,114,161,223,131,149,53,141,151,6,27,87,168,77,184,176,52,28,157,217,183,88,48,47,29,37,29,227,238,7,210,8,226,128,211,54,185,41,253,247,82,143,190,174,181,113,255,226,4,123,191,163,247,147,112,236,195,22,197,77,67,245,122,88,182,120,223,31,254,154,78,144,98,95,170,200,157,48,136,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf"));
		}

		#endregion

	}

	#endregion

}

