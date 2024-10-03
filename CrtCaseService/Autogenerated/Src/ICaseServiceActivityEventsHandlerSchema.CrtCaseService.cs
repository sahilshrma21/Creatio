namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICaseServiceActivityEventsHandlerSchema

	/// <exclude/>
	public class ICaseServiceActivityEventsHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICaseServiceActivityEventsHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICaseServiceActivityEventsHandlerSchema(ICaseServiceActivityEventsHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c523a32-702b-4a95-b0d6-e068df7e5eb7");
			Name = "ICaseServiceActivityEventsHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ff867e3a-49a7-422a-a992-de581439f8d9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,81,107,194,48,16,199,159,21,252,14,7,190,108,80,252,0,186,9,34,186,245,97,48,116,238,61,54,215,238,70,76,186,228,82,40,178,239,190,52,181,98,97,178,193,96,47,45,119,185,223,253,239,254,137,22,7,116,165,200,16,94,208,90,225,76,206,147,165,209,57,21,222,10,38,163,71,195,227,104,56,240,142,116,1,219,218,49,30,102,231,248,18,177,120,45,63,89,105,38,38,116,161,32,148,140,45,22,161,47,164,154,209,230,65,121,10,233,82,56,220,162,173,40,195,69,198,84,17,215,171,10,53,187,71,161,165,66,27,193,210,239,21,101,64,29,247,27,108,112,140,232,89,244,9,249,205,72,55,133,231,216,172,61,172,12,73,104,145,174,77,170,29,90,70,121,19,103,175,65,116,237,99,152,192,46,28,7,155,52,102,141,71,224,123,97,210,52,29,44,218,35,109,152,114,202,162,151,167,212,61,104,175,212,237,236,170,250,174,148,161,94,23,127,80,95,123,157,221,237,141,81,115,40,144,83,183,20,140,133,177,245,154,84,176,175,181,225,52,72,2,177,248,193,147,76,160,69,200,109,240,195,147,69,185,38,84,210,189,10,69,178,15,93,236,120,66,155,239,28,28,114,167,213,91,247,164,226,216,134,197,18,232,255,231,240,110,72,111,48,163,146,154,251,251,70,234,98,198,142,9,139,93,65,126,242,246,95,46,118,140,90,182,207,46,198,159,237,235,239,37,99,238,11,61,191,248,244,131,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c523a32-702b-4a95-b0d6-e068df7e5eb7"));
		}

		#endregion

	}

	#endregion

}

