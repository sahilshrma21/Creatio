namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMacrosInvokableSchema

	/// <exclude/>
	public class IMacrosInvokableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMacrosInvokableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMacrosInvokableSchema(IMacrosInvokableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c");
			Name = "IMacrosInvokable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,185,110,195,48,12,157,109,192,255,64,32,75,187,216,123,19,100,201,80,120,200,150,118,151,21,90,113,107,73,1,69,5,8,130,254,123,37,89,118,211,107,35,169,119,145,50,66,163,59,11,137,112,64,34,225,108,207,245,206,154,126,80,158,4,15,214,84,229,173,42,11,239,6,163,190,65,8,215,85,25,94,86,132,42,192,160,53,140,212,7,161,39,104,247,66,146,13,140,139,125,23,221,136,9,215,52,13,108,156,215,90,208,117,155,251,133,3,182,7,157,72,208,91,130,196,196,122,102,53,119,180,179,239,198,65,6,196,204,204,102,237,151,89,17,3,255,242,75,131,23,135,4,210,26,131,50,238,86,47,192,123,139,34,162,118,11,8,126,180,73,189,80,200,235,84,184,92,124,164,45,255,182,221,35,159,236,17,248,36,24,8,217,147,113,224,152,226,73,47,98,244,152,150,158,246,255,39,82,154,100,234,150,208,249,145,179,194,166,153,199,17,151,85,159,145,167,179,188,70,249,7,219,189,133,240,32,72,121,141,134,221,227,244,117,83,228,21,154,227,244,135,177,13,179,79,92,251,93,155,19,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c"));
		}

		#endregion

	}

	#endregion

}

