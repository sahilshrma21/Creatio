namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactCommLanguageSchema

	/// <exclude/>
	public class IContactCommLanguageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactCommLanguageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactCommLanguageSchema(IContactCommLanguageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb716256-d7b9-4bb9-a683-e956c5354404");
			Name = "IContactCommLanguage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,106,195,48,16,69,215,54,248,14,67,86,233,198,58,64,93,111,82,8,129,236,218,11,76,173,145,43,176,36,51,26,17,66,233,221,43,59,118,26,82,218,130,22,98,244,254,215,255,227,209,81,28,177,35,120,37,102,140,193,72,189,11,222,216,62,49,138,13,190,42,63,170,178,72,209,250,30,94,206,81,200,61,86,101,158,140,233,109,176,29,88,47,196,102,210,31,178,76,176,147,93,112,238,136,190,79,216,83,230,38,117,161,148,130,38,38,231,144,207,237,58,216,147,192,176,128,96,53,121,177,198,18,3,211,128,66,26,78,86,222,161,187,152,214,87,23,117,111,211,140,200,232,192,231,34,79,155,5,63,232,77,187,196,185,113,174,27,53,179,223,82,38,73,236,99,123,252,25,35,195,235,235,132,239,147,213,83,226,237,124,185,126,243,112,89,198,175,5,35,104,50,152,134,155,166,134,131,131,56,111,18,34,137,228,197,254,213,110,13,241,124,239,243,111,212,69,177,157,50,22,159,85,153,207,23,110,56,255,86,238,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb716256-d7b9-4bb9-a683-e956c5354404"));
		}

		#endregion

	}

	#endregion

}

