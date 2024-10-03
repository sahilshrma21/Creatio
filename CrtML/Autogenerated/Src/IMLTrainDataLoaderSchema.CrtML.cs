namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLTrainDataLoaderSchema

	/// <exclude/>
	public class IMLTrainDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLTrainDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLTrainDataLoaderSchema(IMLTrainDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d2ebc20-5c7a-4359-8621-f2a9dff1e79b");
			Name = "IMLTrainDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("145716f7-775c-41a4-ac90-f77e940d760b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,145,77,78,195,48,16,133,215,141,148,59,140,186,2,169,74,14,64,136,132,202,6,41,101,67,57,192,36,153,52,86,99,59,26,219,64,169,184,59,158,180,41,5,36,47,252,247,222,251,252,108,80,147,27,177,33,216,18,51,58,219,249,108,109,77,167,118,129,209,43,107,178,77,149,38,199,52,89,4,167,204,14,94,14,206,147,190,75,147,184,147,231,57,20,46,104,141,124,40,207,235,202,98,235,160,69,143,208,89,6,141,77,175,12,193,64,200,70,244,158,81,201,36,155,245,249,149,193,24,234,65,53,160,140,39,238,132,233,105,83,109,69,240,24,253,196,153,56,222,58,78,225,255,210,175,226,125,79,39,132,250,0,77,31,204,222,173,128,62,168,9,94,16,118,234,141,12,244,104,218,129,24,172,1,138,144,217,197,50,255,235,89,140,200,168,193,196,166,238,151,214,172,197,112,130,105,151,229,67,35,29,197,64,244,231,4,114,179,37,56,98,133,131,250,164,246,68,51,161,192,48,73,161,99,171,47,160,53,58,186,34,152,2,127,242,153,124,96,227,202,231,160,107,33,238,102,15,182,239,46,43,242,249,92,4,177,187,169,4,105,236,230,68,87,108,170,215,81,20,241,241,178,189,146,130,75,248,245,146,219,248,163,139,175,52,137,227,27,201,23,187,21,18,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d2ebc20-5c7a-4359-8621-f2a9dff1e79b"));
		}

		#endregion

	}

	#endregion

}

