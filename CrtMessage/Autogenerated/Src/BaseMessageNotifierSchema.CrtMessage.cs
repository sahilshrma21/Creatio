namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessageNotifierSchema

	/// <exclude/>
	public class BaseMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessageNotifierSchema(BaseMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc1877d9-eed2-4af1-98c3-84cf7a260a2d");
			Name = "BaseMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,77,107,195,48,12,61,167,208,255,32,216,37,187,228,7,52,219,96,43,108,20,214,81,214,245,60,28,91,73,13,169,29,44,39,163,148,253,247,217,249,106,218,181,91,233,77,146,159,223,147,158,229,146,164,202,96,185,37,139,155,104,170,243,28,185,149,90,81,244,130,10,141,228,241,120,52,30,41,182,65,42,24,71,248,64,99,24,233,212,58,172,74,101,86,26,230,225,227,209,206,227,130,27,131,153,75,97,154,51,162,9,60,49,194,57,18,17,203,240,77,91,153,74,52,53,174,40,147,92,114,96,9,89,195,184,5,238,241,61,124,128,134,9,204,142,74,238,122,35,214,171,61,75,204,133,147,91,24,89,49,139,205,97,209,36,96,144,9,173,242,45,188,74,178,119,29,153,79,252,128,15,240,153,183,33,197,45,43,42,209,16,31,170,44,140,46,208,88,137,94,169,238,191,21,106,102,105,137,103,42,213,7,241,206,99,2,66,27,215,65,214,6,223,127,139,57,119,157,53,37,183,218,248,185,180,117,207,130,162,155,172,77,79,25,22,222,182,138,251,185,224,30,20,126,157,153,63,188,189,164,157,57,218,181,22,167,7,175,180,20,176,44,19,226,70,38,24,30,43,64,215,199,239,198,162,71,33,194,254,120,216,199,144,122,165,232,42,242,119,220,232,10,255,231,175,157,219,246,190,165,218,109,12,95,67,88,177,61,61,72,53,88,148,14,26,116,149,104,85,8,183,107,161,93,75,106,116,188,208,57,87,155,234,81,177,115,122,166,44,154,212,125,181,83,139,191,255,57,178,131,157,249,30,65,112,221,62,94,252,152,241,0,127,217,11,13,111,116,158,199,103,236,112,181,31,15,163,10,163,153,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc1877d9-eed2-4af1-98c3-84cf7a260a2d"));
		}

		#endregion

	}

	#endregion

}

