namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLModelBuilderSchema

	/// <exclude/>
	public class IMLModelBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLModelBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLModelBuilderSchema(IMLModelBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("98854813-1873-4ab4-b4e2-030112343a5f");
			Name = "IMLModelBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,148,91,110,219,48,16,69,191,99,192,123,24,232,167,41,16,88,11,168,43,160,113,31,8,96,161,45,146,46,96,34,141,109,2,34,169,12,135,105,131,34,123,47,31,178,99,37,78,235,62,128,254,137,228,204,157,123,143,68,129,65,77,174,199,134,224,138,152,209,217,149,204,22,214,172,212,218,51,138,178,102,86,47,167,147,239,211,201,137,119,202,172,71,85,76,175,158,217,159,189,61,15,71,225,176,44,75,152,59,175,53,242,93,53,172,47,116,223,145,38,35,14,100,67,112,77,27,188,85,150,193,174,210,186,94,214,182,165,110,219,92,238,117,247,254,186,83,13,40,35,196,171,232,249,98,40,62,247,170,107,137,67,73,116,250,100,106,218,88,90,108,243,68,166,27,175,152,90,104,108,231,181,9,155,22,132,81,25,208,81,108,182,147,40,31,107,204,123,100,212,16,161,189,46,82,113,102,85,84,245,50,55,7,205,125,120,243,50,117,28,22,240,142,56,244,27,106,98,109,81,125,25,173,67,76,39,104,26,26,137,220,90,213,166,40,67,242,69,142,112,250,168,119,44,125,6,187,234,104,14,246,156,191,204,239,233,48,178,119,223,122,52,3,52,203,106,173,12,118,112,227,137,239,224,171,146,13,160,1,235,165,247,50,144,60,150,92,146,40,170,171,32,155,30,127,142,233,255,113,126,211,182,159,163,191,143,41,100,70,253,43,210,151,212,133,199,156,235,79,185,215,196,107,114,176,82,2,201,17,133,239,221,29,253,89,146,96,139,130,153,239,118,245,111,17,39,58,201,229,123,37,159,226,182,59,77,65,47,155,13,105,172,135,161,187,233,127,9,162,241,78,172,30,252,164,219,154,110,177,243,157,196,127,79,82,123,225,30,178,254,206,5,30,59,46,170,15,100,40,36,14,127,135,227,208,101,111,15,253,139,236,245,249,102,38,241,108,92,149,178,141,166,108,79,98,169,19,142,209,82,209,98,52,226,48,232,167,123,103,48,104,140,29,70,222,39,247,211,201,125,196,254,3,59,42,142,105,255,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("98854813-1873-4ab4-b4e2-030112343a5f"));
		}

		#endregion

	}

	#endregion

}

