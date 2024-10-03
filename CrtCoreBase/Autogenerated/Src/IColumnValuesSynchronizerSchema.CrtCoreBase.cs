namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnValuesSynchronizerSchema

	/// <exclude/>
	public class IColumnValuesSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnValuesSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnValuesSynchronizerSchema(IColumnValuesSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27011a19-7509-4ec0-bb21-cf388cf23492");
			Name = "IColumnValuesSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd282faf-27c2-4fbe-9d4d-aa5a0b526cd3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,80,189,78,195,64,12,158,83,169,239,96,169,11,72,85,30,128,34,22,40,40,3,83,81,247,235,197,9,150,46,190,200,190,67,10,21,239,222,75,142,146,136,129,145,209,246,247,107,54,29,106,111,44,194,27,138,24,245,77,40,31,61,55,212,70,49,129,60,151,123,14,20,134,195,192,246,93,60,211,231,180,93,175,206,235,85,17,149,184,133,195,160,1,187,196,114,14,237,120,212,242,5,25,133,236,238,7,179,20,23,204,154,132,154,0,9,178,17,108,19,13,42,14,40,77,202,114,7,85,82,139,29,31,141,139,168,179,55,202,68,232,227,201,145,5,186,226,255,130,23,231,137,82,124,120,170,97,113,186,70,184,201,253,64,125,20,139,91,248,30,107,212,64,60,117,221,142,244,162,154,251,221,255,122,70,54,127,53,125,159,170,62,128,93,142,122,187,91,248,63,147,115,79,179,114,246,250,167,4,95,249,215,200,117,126,247,56,166,221,5,180,20,74,240,1,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27011a19-7509-4ec0-bb21-cf388cf23492"));
		}

		#endregion

	}

	#endregion

}

