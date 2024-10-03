namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueryExecutorSchema

	/// <exclude/>
	public class BaseQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueryExecutorSchema(BaseQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d0b9ea3-e9cd-412e-bbed-f37d017a5c6e");
			Name = "BaseQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("84b09f59-6bd7-4f07-9626-7a5c32da980f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,203,78,235,48,16,134,215,65,226,29,70,98,83,164,42,15,64,213,131,104,213,34,22,32,142,202,97,139,166,206,180,88,114,236,224,11,34,66,231,221,25,59,165,228,82,178,203,216,255,204,124,158,127,162,177,36,87,161,32,120,34,107,209,153,157,207,111,170,106,77,232,131,37,119,126,246,121,126,150,5,39,245,30,54,181,243,84,206,142,241,79,194,210,88,250,237,60,95,105,47,189,36,199,2,150,92,88,218,75,163,97,169,208,185,43,88,160,163,191,129,108,189,250,32,17,188,177,73,84,133,173,146,2,112,235,188,69,225,65,68,241,41,109,246,153,244,199,170,107,73,170,224,178,143,86,190,163,167,230,178,106,2,176,132,133,209,170,134,68,84,111,196,43,149,8,47,212,138,102,39,245,255,28,217,165,209,154,132,143,77,94,66,39,158,29,16,72,23,13,69,23,137,133,252,138,32,152,55,129,25,207,105,84,124,163,29,194,225,227,38,189,174,221,166,83,224,162,113,216,109,250,7,246,242,18,162,97,89,214,131,132,57,12,168,163,170,157,206,154,110,207,188,61,168,123,212,184,39,155,223,146,191,227,23,161,22,180,168,99,199,201,0,33,213,254,63,62,22,30,68,69,54,238,197,200,80,122,35,232,133,243,63,191,88,241,83,160,227,116,39,136,201,61,231,199,112,239,201,191,154,98,140,117,107,140,130,56,28,199,203,87,162,173,151,70,133,82,63,163,10,180,150,202,147,157,36,127,155,239,59,189,51,176,59,126,78,193,4,15,183,65,22,80,13,178,191,45,29,222,176,99,5,237,48,40,223,216,105,137,127,90,221,170,123,157,236,114,27,222,20,69,173,196,213,91,64,229,14,88,237,185,228,29,248,60,218,57,77,165,179,8,120,138,109,62,7,94,111,26,241,188,57,237,30,166,179,47,148,133,117,213,124,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d0b9ea3-e9cd-412e-bbed-f37d017a5c6e"));
		}

		#endregion

	}

	#endregion

}

