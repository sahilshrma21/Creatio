namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupportMailBoxRepositorySchema

	/// <exclude/>
	public class ISupportMailBoxRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupportMailBoxRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupportMailBoxRepositorySchema(ISupportMailBoxRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b7ac775-ccba-4dbf-ac65-c1caf69c4152");
			Name = "ISupportMailBoxRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,65,106,195,64,12,60,199,144,63,236,177,189,216,15,168,241,161,37,13,57,4,74,221,15,172,93,57,8,188,43,35,105,75,76,233,223,187,107,215,36,196,61,148,194,94,164,157,209,140,70,222,58,144,193,182,96,222,128,217,10,117,154,63,145,239,240,20,216,42,146,223,102,159,219,108,19,4,253,201,212,163,40,184,135,155,58,226,251,30,218,4,150,124,15,30,24,219,11,230,122,44,67,190,243,138,138,32,17,16,33,69,81,152,82,130,115,150,199,234,167,126,97,250,192,119,16,67,141,90,244,105,6,117,70,194,48,16,171,113,22,251,134,206,32,249,66,47,174,248,67,104,122,108,13,122,5,238,210,82,135,122,230,29,35,237,145,206,175,48,144,160,18,143,17,156,246,90,57,152,26,123,80,249,93,113,45,57,119,24,52,176,151,170,94,145,202,98,249,75,224,195,206,7,7,108,155,30,202,41,138,177,74,106,199,5,126,119,63,7,243,119,95,166,99,114,70,166,75,24,1,213,24,216,63,156,222,248,20,229,20,252,197,218,115,84,153,207,93,207,26,147,211,205,215,54,139,239,27,231,23,200,21,69,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7ac775-ccba-4dbf-ac65-c1caf69c4152"));
		}

		#endregion

	}

	#endregion

}

