namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICategoryFromSupportMailBoxSchema

	/// <exclude/>
	public class ICategoryFromSupportMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICategoryFromSupportMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICategoryFromSupportMailBoxSchema(ICategoryFromSupportMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9f6082f-e4c2-4b11-b02e-75f27d626477");
			Name = "ICategoryFromSupportMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,106,195,48,12,134,207,11,228,29,116,220,96,196,15,208,144,195,58,22,118,24,20,58,216,217,77,148,84,44,182,131,100,183,13,99,239,62,187,77,187,209,13,6,6,35,251,247,167,255,151,173,54,40,163,110,16,94,145,89,139,235,124,177,116,182,163,62,176,246,228,108,158,125,228,217,77,16,178,61,172,39,241,104,22,87,117,212,15,3,54,73,44,69,141,22,153,154,168,137,42,165,20,148,18,140,209,60,85,115,189,98,183,163,22,65,194,56,58,246,96,52,13,176,113,7,20,216,147,223,66,163,61,246,142,167,226,252,94,253,0,140,97,51,80,3,100,61,114,151,76,63,47,103,249,19,59,179,62,33,95,34,241,193,29,162,60,57,255,101,226,120,80,163,255,215,1,116,145,9,114,202,120,33,169,107,84,201,232,3,91,169,30,233,56,131,120,7,251,45,50,194,59,78,64,242,87,31,221,182,140,18,119,219,194,78,15,1,147,238,146,188,84,103,100,234,241,141,45,197,115,28,251,61,212,129,218,42,101,152,163,162,188,69,227,243,40,8,229,246,46,253,209,103,158,197,245,5,199,168,215,226,225,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9f6082f-e4c2-4b11-b02e-75f27d626477"));
		}

		#endregion

	}

	#endregion

}

