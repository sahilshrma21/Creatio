namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITILCaseCalculationParameterReaderSchema

	/// <exclude/>
	public class ITILCaseCalculationParameterReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITILCaseCalculationParameterReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITILCaseCalculationParameterReaderSchema(ITILCaseCalculationParameterReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69");
			Name = "ITILCaseCalculationParameterReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,223,107,219,48,16,126,118,161,255,195,225,190,164,80,236,247,252,130,145,173,37,144,177,208,102,79,101,15,170,124,78,5,142,100,78,114,70,54,246,191,239,36,219,169,211,101,14,13,125,40,49,4,157,244,125,119,223,119,39,105,177,65,91,10,137,176,66,34,97,77,238,146,153,209,185,90,87,36,156,50,250,242,226,247,229,69,84,89,165,215,240,176,179,14,55,188,95,20,40,253,166,77,238,80,35,41,57,218,159,233,210,16,254,47,158,220,10,233,12,41,180,124,194,255,162,52,77,97,108,171,205,70,208,110,218,172,111,13,109,44,148,130,184,72,135,100,33,55,4,51,97,241,139,118,180,91,26,165,93,139,76,59,208,199,111,91,78,166,50,252,193,139,178,122,42,148,4,89,8,107,97,190,154,47,60,126,38,10,89,21,65,223,178,101,191,71,145,33,13,161,127,159,25,189,31,209,21,225,154,119,129,189,178,142,42,47,198,14,97,25,146,5,61,255,8,10,129,185,86,78,137,66,253,66,11,2,52,254,4,197,120,161,217,127,147,131,123,70,134,32,130,36,204,39,241,233,106,227,116,90,43,75,246,25,187,70,180,226,79,19,13,174,33,200,250,243,113,106,15,145,208,123,208,140,155,196,149,69,98,187,117,61,122,241,116,197,25,125,12,228,62,152,140,211,128,120,163,248,239,7,204,112,152,232,218,115,69,67,120,98,142,193,171,173,3,211,174,80,103,245,84,52,235,102,68,190,162,123,54,153,159,14,50,142,129,152,245,152,124,135,14,10,101,157,183,52,72,169,135,94,190,20,223,103,23,161,171,72,219,233,162,159,97,156,182,7,131,79,109,89,96,154,123,3,159,85,208,199,220,99,158,110,190,190,55,80,255,79,125,129,193,62,251,114,166,29,158,168,7,70,104,171,194,193,36,216,152,28,37,25,5,142,250,96,242,41,203,6,241,3,210,86,73,92,242,91,145,204,179,248,6,186,17,14,28,131,84,101,105,200,45,112,139,69,139,233,132,186,32,239,64,83,215,232,212,236,223,215,126,237,91,211,113,243,245,251,36,189,192,55,244,232,56,85,167,71,209,89,77,106,158,73,229,118,239,210,174,62,186,222,198,157,209,183,179,218,214,189,125,62,198,223,95,151,202,228,185,220,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69"));
		}

		#endregion

	}

	#endregion

}

