namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeUnitEnumSchema

	/// <exclude/>
	public class TimeUnitEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeUnitEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeUnitEnumSchema(TimeUnitEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2edcc60c-6562-466a-beae-9495a7f738b1");
			Name = "TimeUnitEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,77,75,196,48,16,61,111,97,255,195,128,23,5,105,189,175,43,200,42,172,7,245,224,138,7,241,144,214,105,13,230,163,204,36,66,113,247,191,59,105,187,221,21,20,18,50,239,229,205,204,155,196,41,139,220,170,10,97,131,68,138,125,29,242,149,119,181,110,34,169,160,189,203,87,202,160,123,87,196,243,236,123,158,205,34,107,215,192,83,199,1,237,98,158,9,115,66,216,136,16,110,93,180,220,51,69,81,192,37,71,107,21,117,87,35,190,254,82,218,168,210,32,4,109,17,162,211,129,161,246,4,1,201,50,84,202,84,209,12,29,247,21,138,163,18,109,44,141,174,0,165,7,108,164,192,179,228,11,157,28,205,30,188,67,88,194,197,121,2,247,218,197,128,125,184,246,145,250,224,70,117,253,249,226,233,83,220,31,73,70,102,82,142,88,18,4,237,100,203,122,125,44,217,27,12,248,118,240,193,65,172,86,80,25,197,60,249,89,163,105,145,246,174,126,43,75,239,13,220,241,254,49,147,252,52,124,232,67,114,255,44,41,56,131,62,125,70,24,34,185,137,134,229,114,210,230,226,15,182,219,191,239,210,44,255,94,14,163,47,82,131,221,48,97,250,64,177,52,252,97,130,194,253,0,54,122,13,160,21,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2edcc60c-6562-466a-beae-9495a7f738b1"));
		}

		#endregion

	}

	#endregion

}

