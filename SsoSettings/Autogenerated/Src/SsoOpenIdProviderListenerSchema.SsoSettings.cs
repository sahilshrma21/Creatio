namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoOpenIdProviderListenerSchema

	/// <exclude/>
	public class SsoOpenIdProviderListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoOpenIdProviderListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoOpenIdProviderListenerSchema(SsoOpenIdProviderListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e352bac-7906-43be-bbc2-e3ef9f8320df");
			Name = "SsoOpenIdProviderListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5aa7639-5b66-4d72-9308-0563d89b2353");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,75,195,64,16,133,207,13,228,63,12,241,146,92,242,3,34,94,44,61,8,98,11,17,47,226,97,155,76,227,66,58,27,102,102,11,37,248,223,93,55,41,53,10,122,219,157,121,243,190,247,200,28,81,6,211,32,60,35,179,17,119,208,114,237,232,96,59,207,70,173,163,178,22,87,163,170,165,78,210,100,76,147,149,151,240,94,200,25,203,13,169,85,139,82,110,78,72,42,183,105,18,148,55,140,93,176,128,117,111,68,42,8,78,219,1,233,161,221,177,59,217,22,57,106,31,173,40,18,114,188,120,141,62,231,197,34,175,155,119,60,154,167,144,20,238,32,251,229,146,21,111,225,114,240,251,222,54,208,124,161,254,33,85,112,111,4,131,230,197,178,122,211,95,234,253,136,179,26,99,164,107,11,71,162,236,27,117,28,202,236,34,111,82,204,236,191,169,121,1,21,236,3,56,151,153,119,237,85,125,171,117,73,147,21,48,126,204,9,144,218,41,68,252,79,211,229,48,206,62,1,191,168,200,210,205,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e352bac-7906-43be-bbc2-e3ef9f8320df"));
		}

		#endregion

	}

	#endregion

}

