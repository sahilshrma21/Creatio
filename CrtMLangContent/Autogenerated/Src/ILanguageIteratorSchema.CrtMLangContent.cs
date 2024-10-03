namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILanguageIteratorSchema

	/// <exclude/>
	public class ILanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILanguageIteratorSchema(ILanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f45065ed-3795-44ee-a8b8-acb977312744");
			Name = "ILanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,203,78,195,48,16,60,183,82,255,97,85,46,112,137,239,109,232,5,161,40,18,72,8,248,1,55,217,132,149,146,117,180,107,31,162,138,127,199,121,82,42,14,62,236,120,102,103,60,102,219,162,118,182,64,248,68,17,171,174,242,201,147,227,138,234,32,214,147,227,221,246,178,219,110,130,18,215,240,209,171,199,246,120,51,71,126,211,96,49,144,53,201,144,81,168,136,156,200,186,19,172,35,10,57,123,148,42,154,28,32,127,177,92,7,91,99,30,33,235,157,140,68,99,12,164,26,218,214,74,127,154,231,119,236,4,21,217,43,88,6,154,233,80,197,211,144,250,193,255,220,67,51,175,211,100,89,99,174,246,116,225,220,80,1,180,248,255,103,191,185,140,17,214,176,175,232,191,92,169,7,120,27,197,211,229,109,192,17,200,48,102,91,3,0,114,104,167,165,201,42,49,183,154,180,179,98,91,224,88,251,227,94,176,112,82,230,229,254,244,204,158,124,15,19,0,84,198,103,83,69,40,73,106,70,193,175,94,208,7,97,141,138,197,13,92,117,85,67,106,22,198,32,201,103,218,185,193,52,11,84,158,134,208,75,7,122,63,64,176,164,120,56,206,69,32,151,83,23,227,252,61,125,229,31,48,98,63,165,113,34,226,57,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f45065ed-3795-44ee-a8b8-acb977312744"));
		}

		#endregion

	}

	#endregion

}

