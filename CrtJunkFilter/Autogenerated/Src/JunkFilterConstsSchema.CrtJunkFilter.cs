namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: JunkFilterConstsSchema

	/// <exclude/>
	public class JunkFilterConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public JunkFilterConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public JunkFilterConstsSchema(JunkFilterConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a61b393-d894-421c-9a81-38a44ebfda70");
			Name = "JunkFilterConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("59955e0a-90db-4796-8f0c-f9403b7d622f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,193,106,195,48,12,134,207,11,228,29,76,78,9,133,208,115,71,161,208,181,148,29,70,161,97,151,177,131,231,168,197,204,145,131,44,31,66,233,187,87,110,55,104,14,129,130,79,159,255,79,150,100,212,29,132,94,27,80,13,16,233,224,143,92,175,61,30,237,41,146,102,235,49,207,206,121,246,210,199,31,103,141,10,44,204,40,227,116,8,234,61,226,239,214,58,6,18,33,112,144,88,138,254,103,77,130,98,144,197,147,218,116,218,186,102,232,97,237,91,80,75,85,220,64,241,58,149,127,243,114,143,143,194,157,76,27,27,100,26,70,47,36,48,157,223,129,110,129,246,228,123,32,30,26,159,20,246,207,230,63,181,139,16,246,154,101,122,20,117,85,148,231,249,165,250,90,46,190,203,122,86,141,202,252,45,141,164,128,71,55,140,71,124,44,177,42,235,106,246,140,122,0,108,211,214,93,236,240,67,62,48,245,126,103,55,251,146,103,114,174,127,199,140,166,218,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a61b393-d894-421c-9a81-38a44ebfda70"));
		}

		#endregion

	}

	#endregion

}

