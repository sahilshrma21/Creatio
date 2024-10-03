namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMacrosWorkerPropertiesConverterSchema

	/// <exclude/>
	public class IMacrosWorkerPropertiesConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMacrosWorkerPropertiesConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMacrosWorkerPropertiesConverterSchema(IMacrosWorkerPropertiesConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fea00b7-db2d-4922-a2b4-e3c0ba2cab34");
			Name = "IMacrosWorkerPropertiesConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,207,10,130,64,16,198,207,10,190,195,224,169,32,220,7,200,188,120,242,16,69,8,157,55,25,101,201,253,211,236,110,32,209,187,167,165,18,17,17,204,101,134,239,251,205,55,163,184,68,107,120,133,80,34,17,183,186,118,73,174,85,45,26,79,220,9,173,162,240,22,133,1,99,12,82,235,165,228,212,101,99,95,40,135,84,15,214,90,19,84,90,93,145,156,80,13,72,94,145,182,96,72,155,97,130,54,153,8,236,3,145,186,206,160,225,196,37,168,62,200,38,46,15,120,241,104,93,156,21,202,120,247,5,149,178,217,243,139,98,125,219,67,118,222,253,69,49,254,212,138,10,196,124,81,177,125,90,142,154,206,72,251,217,151,191,142,68,74,167,160,43,24,151,13,152,225,83,193,216,195,168,93,76,202,183,245,203,117,47,188,71,97,95,15,222,39,111,60,128,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fea00b7-db2d-4922-a2b4-e3c0ba2cab34"));
		}

		#endregion

	}

	#endregion

}

