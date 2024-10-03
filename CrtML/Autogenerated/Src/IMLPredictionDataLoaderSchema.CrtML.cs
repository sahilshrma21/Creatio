namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLPredictionDataLoaderSchema

	/// <exclude/>
	public class IMLPredictionDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLPredictionDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLPredictionDataLoaderSchema(IMLPredictionDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7fe1526a-0fab-4bde-b93e-51192ba340d4");
			Name = "IMLPredictionDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("145716f7-775c-41a4-ac90-f77e940d760b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,81,209,106,194,64,16,124,174,224,63,44,190,180,133,144,124,128,105,160,40,21,65,161,80,127,224,76,54,230,106,114,39,123,119,182,34,254,123,247,46,106,180,182,80,250,150,189,204,206,204,206,40,209,160,217,136,28,97,129,68,194,232,210,198,35,173,74,185,114,36,172,212,42,158,207,250,189,125,191,119,231,140,84,43,120,219,25,139,205,240,219,204,43,117,141,185,199,155,120,130,10,73,230,140,97,84,146,36,144,26,215,52,130,118,217,113,158,105,81,24,40,132,21,80,106,130,70,228,149,84,8,53,10,82,158,115,67,88,200,64,22,159,24,146,11,138,141,91,214,50,7,169,44,82,233,157,79,231,179,215,243,202,152,105,189,0,18,67,247,193,195,141,137,11,23,182,194,206,201,181,240,173,114,251,178,17,36,26,80,28,220,211,0,149,149,118,55,45,6,217,130,137,218,9,100,225,63,74,137,20,167,73,64,119,203,132,214,145,50,217,184,213,97,226,8,62,42,36,12,78,214,200,219,173,41,94,175,139,160,18,133,121,43,106,135,87,63,239,77,251,200,34,39,86,47,211,49,167,198,18,231,25,129,94,190,115,57,89,56,217,231,243,162,169,11,236,97,226,100,1,167,67,30,135,255,141,12,150,59,200,43,167,214,38,2,252,196,220,89,223,229,74,110,81,65,37,84,81,35,1,163,144,219,254,107,186,90,141,60,97,168,147,35,126,110,117,108,37,236,81,1,205,137,178,117,20,244,161,14,120,40,73,55,103,179,75,97,240,66,182,107,101,171,249,250,159,131,105,245,210,233,76,26,155,254,30,107,150,193,149,81,31,225,221,161,223,59,248,36,191,0,194,207,77,206,96,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7fe1526a-0fab-4bde-b93e-51192ba340d4"));
		}

		#endregion

	}

	#endregion

}

