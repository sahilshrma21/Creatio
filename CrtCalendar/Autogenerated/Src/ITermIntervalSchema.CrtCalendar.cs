namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSchema

	/// <exclude/>
	public class ITermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSchema(ITermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1");
			Name = "ITermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,79,194,64,16,61,67,194,127,152,224,69,47,237,29,144,11,70,194,1,98,180,122,49,30,134,118,90,54,182,91,178,59,37,65,227,127,119,118,251,1,162,224,109,247,237,155,55,111,223,140,198,130,236,22,99,130,136,140,65,91,166,28,204,74,157,170,172,50,200,170,212,131,254,231,160,223,171,172,210,25,60,237,45,83,49,62,185,7,143,149,102,85,80,240,68,70,97,174,62,124,221,129,53,195,156,116,130,38,18,206,179,86,12,183,231,122,5,45,213,6,45,89,100,68,232,202,80,38,239,48,203,209,218,17,184,71,145,40,252,91,24,134,48,177,85,81,160,217,79,155,187,231,65,92,106,70,165,201,64,90,26,224,13,129,179,9,74,51,153,29,230,109,109,120,84,252,218,253,97,157,211,155,3,238,144,81,76,178,193,152,29,176,173,214,185,138,33,246,29,14,70,122,46,165,206,231,189,162,60,17,163,15,158,236,109,214,74,75,42,214,100,174,87,146,186,196,48,228,253,150,134,55,78,182,213,253,21,86,36,20,240,226,189,140,92,28,114,176,205,225,235,188,178,252,175,58,145,150,127,195,139,131,47,202,29,21,204,43,149,116,134,22,201,63,46,154,162,54,18,88,201,72,119,212,93,47,23,95,73,143,58,59,185,213,216,49,116,180,2,11,55,189,84,22,118,4,11,39,188,232,166,121,102,23,186,2,40,83,96,103,165,93,128,122,136,193,95,123,112,136,172,169,253,209,107,18,77,219,137,159,118,244,192,146,120,83,38,178,113,200,96,136,43,163,109,221,57,205,49,243,13,127,119,172,145,134,61,141,14,236,73,216,130,142,21,193,156,120,137,246,253,250,102,92,71,117,18,148,32,223,71,251,157,209,212,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1"));
		}

		#endregion

	}

	#endregion

}

