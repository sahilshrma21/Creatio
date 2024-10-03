namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UseCspUIFeatureSchema

	/// <exclude/>
	public class UseCspUIFeatureSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UseCspUIFeatureSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UseCspUIFeatureSchema(UseCspUIFeatureSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe3ac458-ad46-7608-4980-ee525a6b38be");
			Name = "UseCspUIFeature";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9acc6780-473e-4622-a1b4-a9672747b2c4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,142,77,10,194,64,12,70,215,45,244,14,161,43,221,244,0,138,171,170,208,133,187,122,128,56,77,203,64,157,25,146,12,34,226,221,77,171,66,126,224,241,200,151,128,119,146,132,142,160,39,102,148,56,106,211,198,48,250,41,51,170,143,161,42,95,85,89,100,241,97,130,150,105,97,205,217,86,102,234,227,52,205,198,247,85,105,74,202,183,217,59,112,51,138,192,85,168,149,116,237,96,7,63,249,66,138,3,42,154,185,28,252,235,127,113,179,133,21,23,157,156,2,222,102,26,224,0,202,153,246,43,61,146,56,246,105,121,200,120,253,85,4,2,61,192,66,104,240,26,25,70,107,23,131,82,80,16,114,153,189,62,33,69,139,121,214,235,153,183,13,107,171,15,121,30,158,229,247,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe3ac458-ad46-7608-4980-ee525a6b38be"));
		}

		#endregion

	}

	#endregion

}

