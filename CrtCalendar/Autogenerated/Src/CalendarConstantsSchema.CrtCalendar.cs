namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarConstantsSchema

	/// <exclude/>
	public class CalendarConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarConstantsSchema(CalendarConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d");
			Name = "CalendarConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2179f89-6a33-4745-96ee-fd30f06a5c1f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,93,107,219,48,20,125,110,32,255,65,100,47,219,131,18,89,146,109,169,221,6,250,176,182,61,20,10,235,24,236,77,75,148,96,150,200,197,146,25,97,244,191,87,78,98,218,166,161,203,24,216,24,93,157,123,142,116,239,185,246,118,227,194,157,157,59,112,235,218,214,134,102,25,167,170,241,203,122,213,181,54,214,141,159,42,187,118,126,97,219,48,30,253,25,143,46,186,80,251,21,248,186,13,209,109,174,198,163,20,121,211,186,85,2,2,181,182,33,92,130,219,122,227,190,249,58,38,150,16,173,143,41,239,34,61,119,221,207,117,61,7,41,20,211,103,222,99,79,66,123,141,71,202,97,227,18,220,236,242,251,205,254,125,206,214,58,187,104,252,122,11,62,117,245,2,12,7,214,118,27,190,44,192,7,224,221,239,221,206,219,9,41,180,33,8,87,48,23,178,128,148,8,4,69,165,74,72,115,133,75,158,107,70,184,158,188,187,58,87,225,186,246,93,116,199,34,148,73,106,12,103,176,34,210,64,106,114,14,69,161,12,196,140,86,20,49,106,36,54,255,32,242,185,233,218,99,9,89,178,36,162,251,123,84,28,82,92,97,40,12,161,80,105,34,52,175,10,197,139,115,36,190,55,237,175,212,205,19,133,146,90,73,201,50,14,185,196,169,80,5,46,33,167,133,129,26,161,130,230,2,107,138,178,243,5,78,215,137,8,73,9,22,5,84,130,209,212,140,44,135,82,16,2,211,69,136,42,115,38,152,65,231,107,156,42,83,34,71,172,210,37,212,89,198,32,69,88,64,206,21,130,216,228,140,96,158,85,26,87,7,133,157,235,82,189,247,198,75,171,251,189,109,159,197,94,154,125,104,210,206,168,7,167,207,102,51,240,62,116,155,141,109,183,31,15,235,1,7,230,131,163,167,3,114,246,4,122,106,72,94,72,252,215,132,132,216,246,243,171,221,210,118,235,216,15,224,143,198,59,213,44,92,170,220,228,40,60,121,173,248,7,38,105,131,123,60,226,158,230,105,236,85,142,218,71,48,152,195,247,29,76,217,5,250,91,198,190,213,62,217,54,193,49,221,255,133,206,233,222,125,143,124,0,192,171,176,88,242,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d"));
		}

		#endregion

	}

	#endregion

}

