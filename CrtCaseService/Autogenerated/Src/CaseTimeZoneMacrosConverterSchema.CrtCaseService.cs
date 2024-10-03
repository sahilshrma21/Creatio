namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimeZoneMacrosConverterSchema

	/// <exclude/>
	public class CaseTimeZoneMacrosConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimeZoneMacrosConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimeZoneMacrosConverterSchema(CaseTimeZoneMacrosConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae");
			Name = "CaseTimeZoneMacrosConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,219,48,12,61,187,64,255,129,240,46,9,16,216,247,52,49,176,101,91,225,67,135,161,107,47,187,169,50,157,10,136,37,131,146,59,120,197,254,125,148,100,39,177,215,102,167,132,244,227,227,227,35,165,69,131,182,21,18,225,1,137,132,53,181,203,118,70,215,106,223,145,112,202,232,235,171,215,235,171,164,179,74,239,225,71,111,29,54,55,199,248,188,132,240,189,124,246,69,59,229,20,218,119,1,95,133,116,134,34,130,49,31,8,247,220,25,118,7,97,237,26,118,194,226,131,106,240,167,209,120,39,36,25,203,2,95,144,28,82,128,231,121,14,27,219,53,141,160,190,24,226,123,108,9,45,106,103,65,142,96,168,13,193,103,225,2,25,52,158,73,162,5,165,67,7,64,175,178,207,70,194,252,140,177,237,158,14,74,130,244,122,46,201,89,195,167,75,90,147,215,160,247,52,159,209,214,81,231,103,231,49,191,135,38,17,49,31,41,36,74,205,46,138,131,250,205,162,53,254,98,225,214,9,205,155,51,53,131,17,65,18,214,219,244,130,190,52,47,226,16,217,177,73,62,239,178,105,5,137,6,52,223,197,54,237,44,18,87,107,148,254,20,210,226,145,99,111,232,144,200,54,121,64,191,93,108,229,51,54,226,27,255,79,139,112,2,61,196,84,248,62,169,29,12,190,32,125,241,56,145,2,83,101,43,96,35,253,97,157,122,46,61,111,178,134,39,230,92,252,131,62,193,192,159,119,242,103,216,12,234,42,46,103,186,169,59,116,207,166,242,75,34,227,152,4,171,248,189,29,67,48,44,147,84,197,207,104,208,95,234,218,192,45,186,49,94,220,118,170,26,142,236,30,165,161,170,172,134,230,73,57,130,152,254,133,73,104,19,253,42,160,29,18,176,141,175,33,190,148,62,99,226,1,51,47,45,22,129,50,241,23,114,118,96,31,105,223,53,220,125,49,223,233,10,166,206,46,87,255,169,151,108,104,89,113,221,108,150,80,182,188,9,63,132,174,35,125,84,159,157,251,16,33,111,27,30,179,211,36,231,254,2,27,167,249,1,165,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae"));
		}

		#endregion

	}

	#endregion

}

