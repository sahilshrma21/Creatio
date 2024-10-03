namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailRelationConstSchema

	/// <exclude/>
	public class AutoEmailRelationConstSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailRelationConstSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailRelationConstSchema(AutoEmailRelationConstSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd");
			Name = "AutoEmailRelationConst";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,77,139,220,48,12,134,207,59,48,255,33,236,94,218,131,22,41,254,136,195,210,67,38,147,41,61,21,118,183,63,192,99,43,211,64,226,132,124,80,66,233,127,175,59,237,105,250,21,240,193,126,45,233,225,149,20,108,199,211,96,29,39,175,60,142,118,234,235,249,177,236,67,221,92,150,209,206,77,31,30,139,101,238,171,206,54,237,51,183,87,101,191,251,186,223,221,45,83,19,46,201,203,58,205,220,61,197,119,60,15,35,95,226,127,82,182,118,154,146,223,242,98,217,105,222,239,98,224,176,156,219,198,37,211,28,117,151,184,127,134,223,253,128,221,100,140,108,125,31,218,53,121,191,52,62,169,186,161,237,87,230,15,62,121,151,4,254,114,85,223,220,107,204,132,168,78,37,156,132,62,0,73,66,40,140,17,64,250,104,68,89,28,48,55,120,255,246,233,127,213,63,46,99,217,119,131,13,235,235,58,220,50,84,38,41,61,21,71,80,162,210,112,60,17,65,158,209,1,16,233,168,177,202,133,41,245,6,70,180,58,91,55,191,184,207,220,217,79,55,12,210,103,22,90,17,152,154,83,144,164,114,48,222,35,88,131,194,75,109,132,247,98,3,163,112,174,95,194,95,24,169,242,153,35,123,6,242,140,32,21,18,156,37,166,128,41,35,43,155,165,94,243,118,31,177,95,221,18,26,119,29,227,159,129,136,210,230,148,18,164,84,27,144,150,24,76,78,241,166,28,214,153,210,108,37,109,55,181,1,104,200,73,33,53,1,106,202,65,74,239,193,96,22,109,102,105,28,161,65,163,220,175,73,125,187,174,232,3,7,255,115,157,247,187,168,124,7,188,247,132,206,39,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd"));
		}

		#endregion

	}

	#endregion

}

