namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportMailBoxBinderSchema

	/// <exclude/>
	public class SupportMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportMailBoxBinderSchema(SupportMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3");
			Name = "SupportMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,209,106,194,64,16,124,86,240,31,22,251,98,161,36,239,106,133,42,45,20,42,45,181,208,231,203,101,99,15,146,219,99,239,34,6,233,191,119,205,153,98,80,159,142,221,153,155,157,25,171,42,244,78,105,132,47,100,86,158,138,144,172,200,22,102,91,179,10,134,236,104,120,24,13,7,181,55,118,219,163,48,38,47,74,7,98,131,126,118,133,241,141,153,176,170,138,172,160,130,223,49,110,69,14,86,165,242,126,10,155,218,57,226,176,86,166,92,210,126,105,108,142,220,242,210,52,133,185,175,171,74,113,179,56,205,17,134,130,88,32,68,208,140,197,227,248,181,175,241,137,142,188,17,67,205,56,93,36,157,82,122,38,229,234,172,52,26,244,209,193,85,3,48,133,39,231,158,119,104,195,155,241,1,45,242,82,121,148,175,135,214,219,127,136,53,134,31,202,37,198,71,43,25,193,147,60,237,164,3,147,35,236,200,228,240,110,69,113,19,20,135,73,39,45,245,6,220,7,208,241,189,135,99,193,131,65,38,151,146,51,122,7,207,90,180,173,45,22,222,36,71,183,243,155,241,31,224,22,178,152,140,47,203,138,7,126,79,1,209,230,49,99,59,199,109,127,41,187,63,212,62,131,115,53,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3"));
		}

		#endregion

	}

	#endregion

}

