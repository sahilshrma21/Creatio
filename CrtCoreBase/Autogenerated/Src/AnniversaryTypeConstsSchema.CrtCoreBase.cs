namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryTypeConstsSchema

	/// <exclude/>
	public class AnniversaryTypeConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryTypeConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryTypeConstsSchema(AnniversaryTypeConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a51c8b1b-32d7-45c3-a82d-781a607be12f");
			Name = "AnniversaryTypeConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,203,78,195,48,16,69,215,177,228,127,24,117,5,11,183,121,148,148,168,98,1,69,32,214,244,7,166,30,167,88,74,236,200,15,144,133,250,239,36,89,84,32,132,202,246,206,185,163,115,163,215,230,8,175,201,7,213,111,57,227,204,96,175,252,128,82,193,94,57,135,222,182,97,185,179,166,213,199,232,48,104,107,56,251,228,44,27,226,161,211,18,124,24,51,9,178,67,239,225,222,24,253,174,156,71,151,246,105,80,99,203,7,63,178,19,159,173,86,223,239,16,70,0,4,60,104,23,222,8,211,68,252,124,233,20,146,53,93,130,231,168,233,204,189,16,220,129,81,31,115,122,181,40,54,21,221,212,84,138,150,36,10,106,139,66,52,135,18,69,158,23,84,231,170,169,110,101,189,184,158,119,253,101,176,179,253,128,38,65,107,163,161,121,32,252,195,231,233,76,63,254,146,42,155,245,186,174,212,230,162,84,118,226,236,52,185,125,1,68,72,176,17,133,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a51c8b1b-32d7-45c3-a82d-781a607be12f"));
		}

		#endregion

	}

	#endregion

}

