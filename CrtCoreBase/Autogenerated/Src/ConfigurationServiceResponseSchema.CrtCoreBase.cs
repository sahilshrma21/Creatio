namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConfigurationServiceResponseSchema

	/// <exclude/>
	public class ConfigurationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConfigurationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConfigurationServiceResponseSchema(ConfigurationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bbd217b6-97c9-4dc1-83e9-27fef9bede8a");
			Name = "ConfigurationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbd880ce-b4f0-465b-921f-c6a2e08aa5ce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,77,79,195,48,12,61,103,18,255,33,210,46,67,66,253,1,160,93,128,9,113,24,66,116,55,196,33,100,110,137,232,146,202,113,198,199,180,255,142,179,118,75,91,6,226,196,165,138,227,247,158,253,236,212,170,21,248,90,105,144,11,64,84,222,21,148,93,57,91,152,50,160,34,227,236,201,104,115,50,18,193,27,91,202,252,195,19,172,46,6,113,246,16,44,153,21,100,57,160,81,149,249,220,241,18,42,9,223,5,19,65,107,163,97,238,150,80,101,215,138,20,87,35,84,154,18,97,134,232,240,214,22,78,78,123,93,33,244,216,123,98,118,192,179,4,139,60,118,85,159,248,162,14,207,149,209,82,87,202,123,217,51,215,202,61,240,8,156,245,32,207,229,165,242,135,144,169,155,157,162,24,35,148,12,143,100,79,24,52,57,244,231,242,126,167,219,32,218,26,191,169,79,78,101,28,165,16,121,208,26,184,149,169,100,45,136,190,197,246,239,42,179,119,13,117,76,72,216,11,166,171,169,236,233,141,193,46,155,214,251,62,238,209,213,128,100,224,184,139,164,151,78,77,37,15,212,158,58,46,10,85,249,166,172,16,251,54,115,82,20,98,50,7,234,223,77,214,170,10,112,218,226,187,187,102,232,33,236,161,182,63,88,18,162,107,106,14,244,226,150,236,168,110,29,53,233,214,211,218,32,5,85,201,65,131,223,219,59,50,95,4,10,104,165,133,183,33,125,211,113,113,197,143,50,46,32,187,1,90,124,212,188,239,236,142,255,174,179,6,50,231,89,169,178,1,180,231,54,195,82,250,117,129,241,31,140,201,20,54,222,247,251,60,234,38,141,175,55,188,223,61,36,210,191,183,63,120,144,187,157,242,231,11,165,74,92,15,134,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bbd217b6-97c9-4dc1-83e9-27fef9bede8a"));
		}

		#endregion

	}

	#endregion

}

