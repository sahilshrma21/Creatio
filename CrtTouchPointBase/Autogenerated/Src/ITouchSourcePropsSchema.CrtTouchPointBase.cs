namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITouchSourcePropsSchema

	/// <exclude/>
	public class ITouchSourcePropsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITouchSourcePropsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITouchSourcePropsSchema(ITouchSourcePropsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38f705d4-ff74-4732-a6de-a0fc5e557d04");
			Name = "ITouchSourceProps";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c695e3ed-eb31-41e8-baf6-8b1758bb9790");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,65,107,195,48,12,133,207,9,228,63,8,122,79,238,237,216,165,135,17,88,33,172,253,3,94,172,164,130,88,206,108,235,80,194,254,251,140,221,134,176,141,29,118,212,211,123,250,244,88,25,244,179,234,17,46,232,156,242,118,8,245,209,242,64,163,56,21,200,114,85,46,85,89,136,39,30,225,124,243,1,205,161,42,163,178,115,56,198,53,180,28,208,13,241,192,30,218,139,149,254,122,182,226,122,236,156,157,125,50,54,77,3,79,94,140,81,238,246,124,159,179,7,20,107,48,168,73,12,204,209,143,46,16,250,250,145,105,54,161,89,222,39,234,129,30,176,223,88,197,146,120,235,103,221,122,114,15,93,202,231,253,247,135,146,112,188,42,102,156,64,152,62,4,129,52,114,160,129,208,213,107,100,251,79,241,34,164,225,13,189,76,225,21,149,62,165,22,173,134,5,70,12,7,248,252,3,117,47,255,79,82,78,255,32,237,144,117,238,157,230,172,110,197,162,42,163,248,5,129,207,186,102,239,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38f705d4-ff74-4732-a6de-a0fc5e557d04"));
		}

		#endregion

	}

	#endregion

}

