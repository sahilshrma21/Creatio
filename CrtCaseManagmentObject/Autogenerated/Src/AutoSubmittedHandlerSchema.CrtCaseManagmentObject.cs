namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoSubmittedHandlerSchema

	/// <exclude/>
	public class AutoSubmittedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoSubmittedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoSubmittedHandlerSchema(AutoSubmittedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e");
			Name = "AutoSubmittedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,203,110,227,48,12,69,215,14,144,127,32,60,155,4,104,237,253,52,13,16,4,83,180,139,62,48,9,186,167,109,38,214,84,15,151,148,90,4,197,252,123,101,217,233,35,131,217,216,16,69,158,203,43,210,162,33,233,176,38,216,18,51,138,219,249,98,237,236,78,237,3,163,87,206,78,39,111,211,73,22,68,217,61,108,14,226,201,92,76,39,49,82,150,37,44,36,24,131,124,88,142,231,21,212,26,69,192,183,232,129,169,99,18,178,94,0,161,69,219,104,98,112,59,200,87,193,187,243,77,168,140,242,158,154,28,58,118,29,177,63,128,178,64,6,149,134,150,176,33,46,142,42,229,23,153,46,84,90,213,163,78,79,250,0,93,143,18,63,225,230,58,213,63,140,220,241,34,22,191,165,206,179,31,76,251,232,236,63,121,112,75,166,34,150,33,247,212,102,10,220,146,111,93,3,117,75,245,83,239,150,224,5,117,160,222,221,208,250,167,167,83,183,197,7,180,60,165,46,58,100,52,96,227,68,46,243,4,204,151,143,71,238,63,175,118,34,84,44,202,84,254,73,99,242,129,173,44,127,15,127,216,114,36,169,221,216,170,18,200,239,92,14,209,51,92,161,150,40,18,125,240,171,18,138,168,99,109,15,27,95,188,114,78,195,186,119,60,115,213,31,170,253,0,154,67,191,30,89,54,84,128,120,142,139,82,252,122,14,145,57,75,25,197,214,109,82,116,54,63,131,53,10,197,245,18,47,197,74,107,247,74,205,183,25,30,71,145,108,159,37,112,54,20,175,157,137,254,148,56,91,220,115,163,44,234,155,189,117,76,61,112,126,209,103,254,29,135,75,182,25,230,27,79,49,150,77,39,241,251,14,171,170,52,18,231,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e"));
		}

		#endregion

	}

	#endregion

}

