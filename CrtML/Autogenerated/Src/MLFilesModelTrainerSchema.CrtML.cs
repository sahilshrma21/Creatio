namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLFilesModelTrainerSchema

	/// <exclude/>
	public class MLFilesModelTrainerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLFilesModelTrainerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLFilesModelTrainerSchema(MLFilesModelTrainerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b54722e-e495-4420-8ab7-f2449124451a");
			Name = "MLFilesModelTrainer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("145716f7-775c-41a4-ac90-f77e940d760b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,146,77,107,227,64,12,134,207,41,244,63,136,244,226,64,177,239,105,146,195,182,180,4,226,82,186,217,211,178,4,197,150,147,1,123,198,104,198,187,180,161,255,125,53,99,39,216,38,189,217,26,189,175,30,125,104,172,200,214,152,17,108,137,25,173,41,92,252,104,116,161,14,13,163,83,70,199,233,230,246,230,116,123,51,105,172,210,135,65,22,211,195,55,241,248,25,51,103,88,145,149,12,201,249,253,68,5,54,165,251,161,116,46,217,145,251,168,201,20,209,58,221,164,38,167,114,203,168,52,241,236,30,94,5,7,150,144,110,132,193,58,27,191,227,225,141,205,190,164,106,43,146,217,31,241,170,155,125,169,50,200,74,180,86,18,159,85,73,182,239,50,135,161,171,72,78,1,98,114,199,116,144,142,32,120,115,227,9,237,28,222,130,95,155,145,36,9,44,108,83,85,200,31,171,115,96,173,149,83,88,170,79,178,128,160,233,31,40,209,163,150,153,153,2,220,145,68,66,4,25,83,177,156,94,1,154,38,171,150,54,190,148,72,198,53,22,53,50,86,160,165,253,229,180,177,196,194,168,41,243,11,152,174,182,82,194,199,32,187,4,227,69,18,20,215,13,42,95,189,221,98,171,14,1,47,239,237,181,239,208,205,244,10,124,244,107,0,3,67,182,251,243,172,219,98,208,43,60,243,190,147,57,236,209,82,52,86,245,243,224,244,213,173,135,116,222,110,104,184,174,148,220,209,228,126,83,108,156,56,80,222,190,215,231,95,48,127,229,250,84,78,32,7,21,184,159,208,225,198,96,46,51,123,100,66,71,163,104,36,85,3,31,147,107,88,135,165,118,205,247,146,118,99,236,93,143,59,94,231,51,127,254,147,175,111,105,194,100,126,102,71,170,80,122,192,92,156,195,49,157,127,198,20,187,170,123,120,33,153,60,202,121,198,221,23,93,36,3,4,31,245,188,3,144,209,24,37,26,30,254,3,54,161,93,247,233,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b54722e-e495-4420-8ab7-f2449124451a"));
		}

		#endregion

	}

	#endregion

}

