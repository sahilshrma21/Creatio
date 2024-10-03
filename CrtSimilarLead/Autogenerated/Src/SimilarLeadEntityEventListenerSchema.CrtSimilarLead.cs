namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SimilarLeadEntityEventListenerSchema

	/// <exclude/>
	public class SimilarLeadEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SimilarLeadEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SimilarLeadEntityEventListenerSchema(SimilarLeadEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c236e34-22b6-4815-bdb0-6718c56a3063");
			Name = "SimilarLeadEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("364d74c1-c4ce-4435-a41a-0f64d57d716d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,139,34,49,16,61,43,248,31,138,222,203,8,75,250,238,170,176,14,195,204,46,243,5,122,27,246,80,118,151,154,165,147,72,42,10,50,204,127,159,74,108,165,149,110,60,166,222,171,122,175,62,2,22,13,241,22,11,130,5,121,143,236,86,65,221,59,187,210,235,157,199,160,157,29,244,63,7,253,222,142,181,93,195,252,192,129,140,224,85,69,69,4,89,61,146,37,175,139,95,103,78,179,140,49,206,118,35,234,47,119,193,158,212,131,13,58,104,226,155,4,245,176,39,27,34,79,152,63,60,173,197,23,220,87,200,60,130,185,54,186,66,255,76,88,38,250,33,113,159,181,180,33,182,83,70,158,231,48,230,157,49,232,15,211,250,125,34,192,202,121,1,137,160,240,180,154,100,141,114,89,62,5,74,37,129,146,190,58,213,202,175,138,197,124,172,216,213,53,102,200,212,226,37,131,60,38,124,180,64,119,243,98,67,6,95,101,83,48,129,11,19,195,127,146,179,221,45,43,93,64,17,91,190,209,49,140,160,67,95,234,124,166,121,156,71,248,66,97,227,74,25,226,187,215,123,12,84,163,100,203,35,161,139,157,220,28,193,235,217,166,192,19,218,178,34,190,61,215,6,225,205,254,177,76,62,200,25,36,66,116,174,206,10,249,181,196,120,139,30,13,196,219,158,100,44,142,101,190,211,212,46,28,95,106,156,39,74,123,6,101,211,197,134,154,250,139,81,231,241,37,175,51,146,75,161,164,240,219,175,57,46,19,180,229,128,86,62,86,225,108,64,109,227,9,135,13,157,20,83,15,80,98,192,11,51,245,50,221,94,244,116,73,176,119,186,132,70,251,119,110,249,95,254,94,221,199,79,104,213,7,26,66,252,181,189,222,82,182,173,154,233,167,60,26,198,143,213,251,106,221,234,49,122,25,76,177,65,255,27,199,215,201,210,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c236e34-22b6-4815-bdb0-6718c56a3063"));
		}

		#endregion

	}

	#endregion

}

