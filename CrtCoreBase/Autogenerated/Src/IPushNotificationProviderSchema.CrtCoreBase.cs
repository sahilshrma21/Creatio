namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPushNotificationProviderSchema

	/// <exclude/>
	public class IPushNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPushNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPushNotificationProviderSchema(IPushNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e415681b-39a4-4c62-9fc4-58927242174a");
			Name = "IPushNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,77,107,194,64,16,61,71,240,63,12,246,162,80,146,66,47,69,197,34,10,226,161,173,84,61,149,30,214,236,36,29,154,236,134,157,141,32,165,255,189,187,73,20,43,42,237,101,217,143,247,193,123,179,74,228,200,133,136,17,86,104,140,96,157,216,112,162,85,66,105,105,132,37,173,218,173,175,118,43,40,153,84,10,203,29,91,204,7,39,103,135,207,50,140,61,152,195,25,42,52,20,59,140,67,221,24,76,221,45,204,149,69,147,56,147,62,204,23,37,127,60,107,75,9,197,149,254,194,232,45,73,52,21,33,138,34,24,114,153,231,194,236,70,205,249,64,6,157,64,225,216,160,142,232,80,52,124,14,247,252,232,72,160,40,55,25,197,64,7,141,43,254,129,15,26,108,53,73,88,162,146,221,83,228,84,88,1,210,45,61,223,192,119,157,208,1,235,144,191,2,79,50,193,220,135,115,10,23,115,190,98,97,144,81,89,62,147,210,219,94,11,24,123,195,11,126,117,174,183,151,13,235,12,45,118,59,83,239,228,16,40,193,141,209,149,242,16,222,133,247,33,172,25,253,72,199,50,39,181,86,100,231,210,21,231,38,44,100,167,247,238,53,26,51,182,198,79,127,165,63,81,65,37,30,164,104,7,213,134,155,77,93,207,158,49,43,73,62,158,106,255,137,185,247,34,155,225,191,24,79,200,44,210,63,114,166,84,125,95,215,233,176,166,223,54,50,35,24,75,73,213,91,86,205,255,178,220,217,31,225,238,126,0,249,153,118,55,98,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e415681b-39a4-4c62-9fc4-58927242174a"));
		}

		#endregion

	}

	#endregion

}

