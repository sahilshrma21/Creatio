namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupportDefMailBoxSchema

	/// <exclude/>
	public class ISupportDefMailBoxSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupportDefMailBoxSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupportDefMailBoxSchema(ISupportDefMailBoxSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c365918f-f01b-41e0-998d-6395d5736989");
			Name = "ISupportDefMailBox";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,141,77,10,194,64,12,70,215,22,122,135,44,117,211,57,128,165,11,21,196,133,171,122,129,105,201,148,129,206,15,73,6,90,196,187,59,131,212,69,33,16,248,190,151,23,175,29,114,212,35,194,11,137,52,7,35,205,53,120,99,167,68,90,108,240,117,245,174,171,67,76,195,108,71,176,94,144,76,161,31,125,138,49,144,220,208,60,181,157,47,97,201,84,33,15,74,41,104,57,57,167,105,237,182,224,142,2,252,187,0,151,121,24,194,2,134,130,3,94,89,48,47,20,177,126,106,254,6,181,87,180,132,146,200,115,215,239,60,77,171,182,170,176,44,148,69,229,227,241,116,206,193,167,174,242,124,1,20,242,151,143,232,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c365918f-f01b-41e0-998d-6395d5736989"));
		}

		#endregion

	}

	#endregion

}

