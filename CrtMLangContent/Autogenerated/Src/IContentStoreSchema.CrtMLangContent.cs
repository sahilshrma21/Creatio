namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContentStoreSchema

	/// <exclude/>
	public class IContentStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContentStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContentStoreSchema(IContentStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3c7a9a4-e4fe-4de6-9313-1b0c8d8e8ead");
			Name = "IContentStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,146,207,74,195,64,16,198,207,45,244,29,134,122,81,144,228,110,107,65,84,164,160,40,85,31,96,155,76,210,197,100,55,204,206,34,165,248,238,78,254,108,108,74,43,222,188,44,204,183,51,223,252,102,119,140,42,209,85,42,65,120,67,34,229,108,198,209,173,53,153,206,61,41,214,214,76,198,187,201,120,228,157,54,57,188,110,29,99,57,235,227,91,75,56,140,162,123,195,154,53,58,145,229,226,140,48,23,15,88,26,70,202,164,203,21,44,197,157,209,240,43,75,122,147,20,199,49,204,157,47,75,69,219,69,23,175,176,34,116,146,230,192,213,137,144,89,130,210,23,172,11,101,114,175,114,132,164,245,137,130,67,188,103,81,249,117,161,19,208,161,237,97,215,209,174,233,220,243,189,144,173,144,106,238,43,120,105,106,219,251,67,180,70,184,67,113,45,181,65,7,159,27,228,13,18,176,5,86,31,88,55,180,160,146,196,122,195,64,58,223,8,191,40,14,11,76,24,82,197,42,234,109,247,121,71,107,107,11,120,119,120,147,138,241,170,45,220,65,142,60,147,98,57,190,58,94,52,105,139,60,228,127,18,12,155,254,5,126,133,236,201,184,240,122,128,245,127,109,79,80,53,74,165,72,149,96,100,79,174,167,109,246,50,157,46,158,101,58,109,84,209,25,244,126,58,173,133,76,35,69,243,184,41,61,238,20,190,177,246,122,12,95,250,91,49,181,224,139,167,99,75,16,198,152,199,33,173,174,187,111,209,30,144,207,31,188,78,33,208,95,66,19,254,32,92,204,254,240,98,41,102,74,122,255,203,203,133,169,238,142,51,156,26,187,75,31,78,31,134,61,216,165,118,195,134,162,104,223,154,54,147,191,32,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3c7a9a4-e4fe-4de6-9313-1b0c8d8e8ead"));
		}

		#endregion

	}

	#endregion

}

