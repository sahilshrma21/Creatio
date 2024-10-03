namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SatisfactionLevelPointSchema

	/// <exclude/>
	public class SatisfactionLevelPointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SatisfactionLevelPointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SatisfactionLevelPointSchema(SatisfactionLevelPointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a");
			Name = "SatisfactionLevelPoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,61,107,195,48,16,157,109,240,127,56,200,110,237,105,233,226,181,67,32,249,3,23,229,100,4,214,201,232,206,129,16,242,223,35,69,37,117,3,25,170,65,112,79,239,227,30,98,12,36,51,90,130,3,165,132,18,157,246,67,100,231,199,37,161,250,200,93,123,237,90,200,103,147,104,204,51,12,19,138,192,22,246,249,89,28,218,66,250,166,51,77,187,232,89,187,182,178,141,49,240,41,75,8,152,46,95,191,80,21,219,200,138,158,41,129,139,9,100,101,4,115,49,17,64,62,101,86,8,148,135,126,229,104,254,90,206,203,113,242,22,236,195,245,221,66,77,46,208,52,47,11,85,224,193,128,232,128,68,125,64,165,156,138,66,253,83,96,214,138,159,180,34,169,194,43,140,164,31,32,229,186,149,230,111,98,134,218,4,52,254,43,72,52,121,30,159,234,151,180,166,38,110,136,79,245,103,186,54,35,119,146,178,89,188,208,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a"));
		}

		#endregion

	}

	#endregion

}

