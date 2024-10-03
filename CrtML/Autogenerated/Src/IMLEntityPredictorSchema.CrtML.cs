namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLEntityPredictorSchema

	/// <exclude/>
	public class IMLEntityPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLEntityPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLEntityPredictorSchema(IMLEntityPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146");
			Name = "IMLEntityPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,209,74,195,48,20,125,118,176,127,184,236,73,97,180,31,224,86,16,21,41,108,80,216,252,128,172,185,221,162,109,82,238,77,212,33,251,119,147,118,209,106,125,216,91,78,114,206,185,231,30,162,69,131,220,138,18,97,139,68,130,77,101,147,123,163,43,181,119,36,172,50,58,89,175,166,147,207,233,228,202,177,210,123,216,28,217,98,115,251,141,135,42,194,164,32,83,34,243,111,11,207,246,252,52,77,97,193,174,105,4,29,179,51,206,181,69,170,194,244,202,16,180,132,82,149,65,1,66,75,96,241,22,38,216,3,14,95,8,217,213,22,148,6,212,86,217,99,18,173,211,129,119,235,118,181,42,61,41,218,231,235,213,99,71,47,122,39,67,158,21,182,26,197,234,46,206,44,142,57,144,47,137,49,206,209,223,180,130,68,3,218,55,189,156,53,70,98,157,203,89,182,245,126,29,0,37,131,69,165,144,146,69,218,113,255,151,246,131,162,182,71,23,139,127,162,63,51,210,86,240,235,44,11,39,176,254,8,239,202,30,134,219,225,135,37,1,157,158,199,190,132,214,145,230,172,248,91,135,167,198,183,64,54,187,23,44,109,44,243,78,203,141,111,242,250,201,41,9,231,26,230,208,161,184,217,28,214,171,7,97,69,49,10,11,227,252,176,4,237,234,250,38,252,197,211,116,114,10,159,236,11,146,143,19,187,206,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f591c48-2aae-4f89-af89-1090bb3a3146"));
		}

		#endregion

	}

	#endregion

}

