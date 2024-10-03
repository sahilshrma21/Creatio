namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermIntervalSchema

	/// <exclude/>
	public class CaseTermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermIntervalSchema(CaseTermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cff3d064-d73b-473d-8492-7151dcd31b07");
			Name = "CaseTermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,81,107,219,48,16,126,78,161,255,225,198,160,164,208,218,93,31,219,52,48,194,54,250,208,81,150,180,47,99,15,170,115,246,68,101,201,232,228,64,182,229,191,239,36,91,137,29,135,18,10,129,72,167,251,116,223,247,221,89,90,148,72,149,200,16,22,104,173,32,147,187,100,102,116,46,139,218,10,39,141,62,61,249,123,122,50,170,73,234,2,230,107,114,88,222,110,247,51,161,80,47,133,165,133,44,241,73,75,7,119,187,88,18,131,156,207,136,143,22,11,190,14,190,232,186,188,225,44,66,46,88,206,157,112,72,124,204,191,52,77,97,66,117,89,10,187,158,182,123,159,7,142,19,65,106,254,91,9,5,153,41,43,133,14,53,18,1,5,124,18,209,105,7,254,243,171,18,5,253,242,171,57,90,41,148,252,35,94,20,250,64,85,191,40,153,1,50,149,33,19,47,119,244,221,104,100,49,87,23,126,195,126,56,33,53,253,96,167,140,38,127,240,105,255,192,168,149,143,95,115,120,211,232,101,23,26,201,61,249,51,37,136,118,250,239,91,85,33,231,144,1,159,33,243,136,203,172,41,133,22,114,99,33,27,216,114,200,129,86,102,184,96,80,17,110,224,190,187,159,244,141,152,70,39,34,241,71,107,42,180,78,34,179,127,12,23,7,206,3,210,33,16,13,113,60,2,93,138,67,142,145,164,31,22,95,61,66,195,58,16,24,21,232,71,136,23,212,46,54,111,87,110,122,244,190,210,1,123,68,237,189,238,110,93,122,64,247,219,44,143,177,232,27,58,2,223,85,212,14,74,65,175,192,60,107,76,14,83,13,17,139,174,182,154,166,15,187,236,73,26,131,29,65,253,78,250,74,30,49,62,111,53,173,132,5,139,84,171,230,115,237,230,38,126,238,27,193,50,135,113,207,144,15,119,160,107,165,224,236,172,103,84,178,88,87,232,15,151,152,11,190,115,60,120,20,206,7,144,103,207,29,166,112,21,41,141,90,62,255,6,132,246,191,189,134,220,166,75,113,59,46,125,134,49,124,60,193,45,226,125,252,60,188,75,175,233,76,107,245,27,195,51,124,47,248,53,228,224,127,204,49,106,39,155,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cff3d064-d73b-473d-8492-7151dcd31b07"));
		}

		#endregion

	}

	#endregion

}

