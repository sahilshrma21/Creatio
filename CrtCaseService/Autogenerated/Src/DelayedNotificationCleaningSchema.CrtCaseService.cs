namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DelayedNotificationCleaningSchema

	/// <exclude/>
	public class DelayedNotificationCleaningSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DelayedNotificationCleaningSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DelayedNotificationCleaningSchema(DelayedNotificationCleaningSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df08478c-376b-45c2-ab1f-44f5d2bfcce8");
			Name = "DelayedNotificationCleaning";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,193,78,227,48,16,61,7,137,127,24,101,47,137,132,156,59,148,74,208,238,162,34,129,208,118,171,61,187,206,180,53,114,236,106,108,23,42,196,191,239,196,73,11,97,17,220,60,111,222,188,121,51,99,43,27,244,91,169,16,254,32,145,244,110,21,196,196,217,149,94,71,146,65,59,123,122,242,114,122,146,69,175,237,26,230,123,31,176,225,188,49,168,218,164,23,55,104,145,180,186,56,114,38,142,112,24,137,233,245,7,96,174,54,88,71,131,196,56,103,126,16,174,89,12,38,70,122,15,231,48,69,35,247,88,223,187,160,87,90,37,23,19,131,210,114,125,226,87,85,5,35,31,155,70,210,126,220,199,191,113,75,232,209,6,15,18,84,207,134,71,183,4,183,2,105,8,101,189,135,54,15,246,157,172,23,7,185,234,157,222,54,46,141,86,172,210,218,249,194,12,91,157,221,186,229,207,103,84,49,56,226,202,151,228,239,56,208,29,134,141,171,219,145,30,146,100,151,253,104,63,1,220,6,3,250,111,172,254,239,181,67,182,146,100,3,150,111,121,153,71,143,196,23,180,221,133,242,241,130,99,80,71,64,140,170,196,254,188,56,189,217,8,249,124,252,112,124,15,106,250,237,236,52,133,40,13,236,156,174,161,91,1,22,139,65,111,24,90,57,131,217,84,167,23,123,31,249,64,188,194,51,112,203,71,78,143,225,173,115,9,237,143,203,178,157,36,168,211,90,224,18,44,62,245,59,42,134,170,101,226,102,226,23,185,166,200,63,185,86,126,96,252,221,32,97,145,95,169,214,247,28,109,61,149,1,243,82,48,185,40,197,204,223,71,99,138,18,164,239,27,93,164,186,206,129,56,76,88,38,244,53,203,250,75,179,76,119,236,20,191,118,255,121,0,50,246,15,166,141,123,143,101,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df08478c-376b-45c2-ab1f-44f5d2bfcce8"));
		}

		#endregion

	}

	#endregion

}

