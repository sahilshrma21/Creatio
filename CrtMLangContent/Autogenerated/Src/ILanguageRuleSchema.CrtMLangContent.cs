namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILanguageRuleSchema

	/// <exclude/>
	public class ILanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILanguageRuleSchema(ILanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e06075a-13a8-4259-bad5-f82e6f51b55b");
			Name = "ILanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a79d048a-6394-421e-9091-4cdc0081ecbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,193,74,196,48,20,60,183,208,127,120,236,94,244,210,220,181,246,162,178,20,86,88,86,127,32,109,94,187,129,246,165,188,36,66,17,255,221,52,221,234,234,10,57,100,38,243,102,134,23,146,3,218,81,54,8,111,200,44,173,105,93,254,104,168,213,157,103,233,180,161,44,253,200,210,196,91,77,29,188,78,214,225,112,159,165,129,17,66,64,97,253,48,72,158,202,51,126,66,219,176,174,209,130,59,33,176,239,195,173,53,12,166,118,82,211,236,32,161,151,212,121,217,97,190,122,136,11,147,209,215,189,110,64,147,67,110,231,82,213,254,44,63,6,179,32,152,187,36,91,198,46,52,131,23,116,39,163,236,29,28,226,88,172,117,213,43,18,7,54,239,90,133,54,107,58,4,68,78,183,26,25,8,81,45,61,139,81,178,28,24,91,160,176,150,135,205,44,113,211,17,27,195,170,82,27,81,230,223,9,226,111,196,50,251,255,96,249,28,49,112,36,46,178,243,66,196,177,31,23,70,231,153,108,185,191,46,26,196,235,235,44,223,121,173,96,135,110,85,86,234,38,82,191,179,111,151,223,74,182,72,106,89,91,64,159,89,26,206,23,221,140,16,219,251,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e06075a-13a8-4259-bad5-f82e6f51b55b"));
		}

		#endregion

	}

	#endregion

}

