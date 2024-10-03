namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSelectorSchema

	/// <exclude/>
	public class ITermIntervalSelectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSelectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSelectorSchema(ITermIntervalSelectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef");
			Name = "ITermIntervalSelector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,203,106,195,48,16,60,215,224,127,88,114,106,161,88,31,80,215,80,90,8,62,244,148,252,128,226,174,29,21,61,204,106,85,8,165,255,222,149,106,39,105,11,58,172,118,103,70,179,35,175,29,198,89,15,8,123,36,210,49,140,220,60,7,63,154,41,145,102,19,124,93,125,214,213,77,138,198,79,176,59,69,70,39,115,107,113,200,195,216,108,209,35,153,225,65,48,74,41,104,99,114,78,211,169,91,238,189,103,164,49,203,135,17,164,116,96,114,231,67,91,136,152,69,2,53,43,85,93,113,231,116,176,102,248,1,23,122,47,246,92,191,112,119,11,181,221,103,108,246,247,239,241,210,120,69,62,134,55,224,163,102,32,228,68,62,2,27,135,23,19,99,32,24,180,29,146,45,203,54,103,41,245,87,171,157,53,105,7,94,242,122,220,104,154,146,67,207,113,211,61,173,101,209,138,44,169,225,100,48,54,173,42,140,139,192,226,160,219,95,59,16,216,218,207,192,95,107,202,122,176,69,190,125,49,37,108,113,211,138,190,124,196,61,132,195,187,36,208,193,217,200,93,254,129,175,186,146,83,87,223,22,76,161,42,213,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef"));
		}

		#endregion

	}

	#endregion

}

