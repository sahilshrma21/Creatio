namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceTermProviderFactorySchema

	/// <exclude/>
	public class ServiceTermProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceTermProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceTermProviderFactorySchema(ServiceTermProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af9b1e78-e018-487e-9a15-deed4c262d47");
			Name = "ServiceTermProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,81,106,194,64,16,253,86,240,14,131,95,10,33,57,128,105,160,88,42,253,43,168,7,88,215,137,108,73,54,97,102,215,18,74,239,222,217,53,90,99,91,11,73,200,206,188,55,243,230,205,122,54,246,0,235,142,29,214,233,178,169,42,212,206,52,150,211,21,90,36,163,23,147,177,143,144,13,18,41,110,74,39,40,194,63,194,233,179,210,174,33,131,44,128,201,216,170,26,185,85,26,7,48,91,154,131,39,21,218,164,107,164,163,209,40,233,122,50,254,152,140,71,89,150,65,206,190,174,21,117,69,127,14,89,104,169,57,154,61,18,148,177,69,151,158,193,217,21,186,245,187,202,104,208,149,98,142,180,215,158,117,210,213,9,36,52,249,209,37,6,86,232,24,184,69,109,74,163,163,60,112,177,179,34,153,67,126,57,189,112,179,91,114,30,81,16,38,126,152,234,198,238,77,180,113,90,108,6,37,128,49,56,12,23,68,154,103,49,249,123,33,207,72,98,152,61,45,101,90,108,229,28,184,125,224,39,153,208,121,178,92,172,239,142,145,103,103,92,32,246,166,29,13,57,175,42,120,25,112,163,137,23,102,240,232,78,122,246,100,162,46,49,38,103,71,114,63,18,104,118,111,34,182,248,158,152,19,216,14,198,130,225,148,115,136,43,26,157,36,194,50,236,178,95,159,92,74,151,223,233,95,204,34,115,100,241,29,164,160,72,240,129,247,72,7,95,163,117,179,235,197,36,87,138,230,201,63,188,155,61,36,183,146,231,139,80,224,83,62,242,202,243,5,130,171,117,161,86,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af9b1e78-e018-487e-9a15-deed4c262d47"));
		}

		#endregion

	}

	#endregion

}

