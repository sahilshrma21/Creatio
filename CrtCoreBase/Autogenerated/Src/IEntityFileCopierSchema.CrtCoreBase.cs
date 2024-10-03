namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEntityFileCopierSchema

	/// <exclude/>
	public class IEntityFileCopierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEntityFileCopierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEntityFileCopierSchema(IEntityFileCopierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2");
			Name = "IEntityFileCopier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,75,195,48,16,199,159,55,216,119,56,230,139,130,180,239,219,28,200,80,217,195,68,182,125,129,152,94,218,64,155,196,203,69,41,195,239,110,150,118,67,71,81,124,235,253,239,223,95,254,185,139,17,13,122,39,36,194,30,137,132,183,138,179,149,53,74,151,129,4,107,107,38,227,195,100,60,10,94,155,18,118,173,103,108,230,147,113,84,174,8,203,216,134,181,97,36,21,1,51,88,63,24,214,220,62,234,26,87,214,105,164,100,204,243,28,22,62,52,141,160,118,217,215,91,116,132,30,13,123,144,214,48,9,201,160,44,197,194,181,199,131,48,129,64,69,146,135,15,205,21,120,135,82,43,45,193,186,99,42,159,157,200,249,55,180,11,175,117,180,232,83,164,161,68,163,67,74,117,206,191,65,174,108,225,103,240,146,126,238,154,151,153,147,16,9,45,136,186,238,99,41,178,13,88,131,167,176,108,65,24,203,21,82,118,70,228,151,140,133,19,36,26,48,113,234,119,83,111,3,73,220,136,56,84,218,201,10,27,241,28,245,233,178,251,78,38,176,10,58,27,52,201,215,159,150,45,242,68,250,27,188,69,105,169,88,23,17,251,131,67,73,135,96,244,91,64,93,28,177,42,14,232,119,48,11,42,145,47,193,251,164,254,7,252,110,117,145,230,121,95,215,215,158,233,184,243,225,105,220,194,83,136,222,161,27,245,173,161,76,55,243,126,201,104,138,110,207,169,254,236,94,238,15,49,106,95,107,80,182,240,4,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c02c3b56-5b96-4366-af70-1c204d27c6c2"));
		}

		#endregion

	}

	#endregion

}

