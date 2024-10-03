namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HttpRequestClientFactorySchema

	/// <exclude/>
	public class HttpRequestClientFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HttpRequestClientFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HttpRequestClientFactorySchema(HttpRequestClientFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6a5c9a8-5d91-4432-9612-d13ffbfc331e");
			Name = "HttpRequestClientFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cc281005-d010-4480-8333-effff60fd1ff");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,193,110,219,48,12,134,207,14,144,119,224,176,139,3,20,121,128,165,237,97,9,210,6,195,138,33,235,173,40,10,69,102,50,1,138,148,82,84,10,35,200,187,79,178,173,54,118,220,118,59,210,254,245,235,35,127,202,136,45,186,157,144,8,247,72,36,156,93,243,120,106,205,90,109,60,9,86,214,12,7,135,225,32,243,78,153,13,252,46,29,227,118,210,169,131,94,107,148,81,236,198,55,104,144,148,124,211,156,218,18,142,231,66,178,37,133,238,93,197,18,159,61,58,142,130,32,217,249,149,86,18,28,7,24,9,82,11,231,224,150,121,215,168,166,90,161,225,218,180,12,242,67,117,40,251,74,184,9,56,48,87,168,11,247,13,126,145,218,11,198,250,231,174,46,146,39,161,40,172,209,37,204,84,213,131,160,242,210,49,5,178,11,152,123,35,47,23,103,247,93,95,195,147,9,131,43,190,43,83,4,161,131,171,104,156,25,124,249,47,151,124,52,105,120,209,20,53,114,155,255,39,242,31,251,89,3,231,206,112,131,124,23,249,22,38,104,140,196,188,70,129,8,61,130,67,5,187,23,4,171,154,31,174,58,253,60,196,234,113,82,233,8,217,147,73,210,10,57,203,142,255,202,93,197,215,96,183,162,236,167,78,192,115,178,219,217,34,79,172,13,195,52,198,223,132,29,54,141,251,134,250,6,152,101,231,183,174,172,213,112,79,229,71,3,186,0,235,185,143,79,53,226,68,149,234,48,62,227,181,174,199,165,214,144,127,105,79,51,62,40,22,65,253,3,203,188,138,32,57,164,198,214,66,59,172,207,31,187,214,103,168,149,67,43,27,38,143,167,177,180,123,222,91,85,192,50,4,19,30,43,125,208,245,123,107,10,50,60,236,112,69,28,123,2,239,91,151,192,122,162,252,132,103,134,26,25,27,131,190,245,236,140,112,137,91,187,63,237,253,53,224,206,14,198,239,195,193,17,134,131,191,166,178,198,159,219,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6a5c9a8-5d91-4432-9612-d13ffbfc331e"));
		}

		#endregion

	}

	#endregion

}

