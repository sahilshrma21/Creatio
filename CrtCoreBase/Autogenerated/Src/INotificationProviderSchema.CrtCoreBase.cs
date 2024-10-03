namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationProviderSchema

	/// <exclude/>
	public class INotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationProviderSchema(INotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aabdace1-2a9b-4be1-a035-cadae80c10e3");
			Name = "INotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,106,195,64,12,69,215,9,244,14,3,217,36,80,124,128,164,116,209,164,132,44,90,12,238,5,38,99,217,85,113,70,70,146,3,33,228,238,213,140,83,67,160,203,249,255,233,235,107,162,63,129,244,62,128,251,2,102,47,212,104,177,165,216,96,59,176,87,164,232,174,79,243,217,32,24,219,7,130,161,216,189,109,38,171,186,136,194,201,244,174,131,144,198,164,216,67,4,198,96,140,81,11,134,54,133,29,162,2,55,182,110,237,14,159,164,216,96,200,91,74,166,51,214,192,25,238,135,99,135,193,225,31,251,63,154,138,25,60,69,127,128,126,83,45,107,87,230,241,209,180,12,183,7,221,210,16,117,185,74,125,103,21,164,138,73,125,143,138,138,32,163,114,183,207,132,181,171,64,75,207,246,53,214,64,150,59,204,39,121,190,188,136,178,157,251,236,232,248,99,35,175,174,159,168,213,230,94,7,98,61,54,202,239,219,120,254,131,104,218,47,106,49,248,109,119,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aabdace1-2a9b-4be1-a035-cadae80c10e3"));
		}

		#endregion

	}

	#endregion

}

