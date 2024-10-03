namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosWorkerExtendedPropertiesSchema

	/// <exclude/>
	public class MacrosWorkerExtendedPropertiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosWorkerExtendedPropertiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosWorkerExtendedPropertiesSchema(MacrosWorkerExtendedPropertiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb");
			Name = "MacrosWorkerExtendedProperties";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,78,195,48,12,134,207,157,180,119,176,198,189,189,111,176,3,211,132,56,32,77,2,196,217,75,220,206,90,155,86,118,34,168,38,222,157,44,221,74,65,72,220,236,223,254,237,207,137,195,134,180,67,67,240,66,34,168,109,233,243,77,235,74,174,130,160,231,214,205,103,167,249,44,11,202,174,130,231,94,61,53,171,49,159,90,132,254,214,39,163,242,87,207,181,198,182,216,120,35,84,69,9,54,53,170,46,225,9,141,180,250,214,202,145,100,251,225,201,89,178,59,105,59,18,207,164,201,81,20,5,220,106,104,26,148,126,125,201,147,27,216,25,236,52,212,232,9,208,90,62,239,194,26,186,209,15,239,7,54,7,48,232,96,79,16,148,108,244,196,97,68,96,132,202,187,197,61,42,109,157,103,223,79,65,22,197,58,191,46,46,38,155,187,176,175,217,128,73,203,255,35,207,78,137,126,60,248,187,182,132,93,26,52,212,127,159,151,132,225,193,193,132,218,7,33,96,75,17,178,100,146,124,180,76,193,174,100,15,129,237,217,187,25,124,143,22,206,127,152,101,21,249,85,10,244,18,124,94,216,34,245,128,151,242,65,253,41,70,237,11,145,179,153,86,43,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb"));
		}

		#endregion

	}

	#endregion

}

