namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadSourceConstsSchema

	/// <exclude/>
	public class LeadSourceConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadSourceConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadSourceConstsSchema(LeadSourceConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f02ccde-e202-4fc1-ac0f-1d4417da8cfe");
			Name = "LeadSourceConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c695e3ed-eb31-41e8-baf6-8b1758bb9790");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,79,107,194,48,24,135,207,10,126,135,160,151,237,16,251,47,141,118,110,131,166,173,50,24,236,224,96,236,152,181,177,43,182,137,36,233,54,145,125,247,165,173,130,232,240,98,9,13,121,243,190,191,231,57,132,211,138,169,13,77,25,120,101,82,82,37,86,122,28,9,190,42,242,90,82,93,8,62,232,239,6,253,94,173,10,158,131,229,86,105,86,205,204,217,172,145,100,185,185,7,81,73,149,186,3,207,140,102,75,81,203,148,153,113,165,213,160,111,122,44,203,2,247,170,174,42,42,183,143,251,179,185,214,180,224,234,104,2,148,66,172,235,13,72,155,73,202,53,248,162,101,205,212,248,144,96,29,69,108,234,143,178,72,129,233,211,102,75,27,248,63,236,222,174,229,159,9,180,133,133,16,121,201,64,152,189,9,153,181,148,115,204,9,71,26,130,224,229,22,44,234,34,59,226,117,81,251,164,167,12,60,0,206,190,219,166,155,33,118,38,147,200,241,9,244,145,23,64,20,97,27,146,16,97,136,98,55,33,174,237,184,19,59,25,222,206,46,136,190,83,158,177,31,16,23,146,165,250,42,207,117,23,213,37,157,120,122,94,48,39,113,60,133,110,20,218,16,133,200,134,193,52,244,161,67,16,9,112,104,59,24,59,151,61,95,244,39,147,64,21,154,93,37,217,198,156,200,205,253,100,226,17,23,65,18,227,41,68,62,9,97,144,68,24,198,73,130,236,208,243,35,236,248,7,185,223,230,15,204,55,98,60,235,94,103,83,49,229,63,143,41,141,15,230,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f02ccde-e202-4fc1-ac0f-1d4417da8cfe"));
		}

		#endregion

	}

	#endregion

}

