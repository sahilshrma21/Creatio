namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilityObsoleteSchema

	/// <exclude/>
	public class CalendarUtilityObsoleteSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilityObsoleteSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilityObsoleteSchema(CalendarUtilityObsoleteSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e3cb340-4d0d-4fe9-b58a-97330a7996b4");
			Name = "CalendarUtilityObsolete";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,77,75,195,64,20,60,183,208,255,240,104,47,21,36,185,107,12,104,4,233,73,65,123,18,15,175,155,151,186,176,217,13,251,33,132,226,127,119,179,249,106,82,47,94,188,101,102,223,204,206,155,172,196,146,76,133,140,224,141,180,70,163,10,27,101,74,22,252,232,52,90,174,100,148,161,32,153,163,54,171,229,105,181,92,56,195,229,17,94,107,99,169,188,29,240,185,88,147,231,253,201,70,211,209,27,64,38,208,24,184,129,222,104,111,185,224,182,14,51,113,28,67,98,92,89,162,174,211,14,223,3,11,10,251,137,22,42,173,190,120,78,6,88,167,6,203,75,106,16,115,34,4,4,23,252,56,153,168,55,140,207,28,43,119,16,156,65,133,218,114,20,157,245,44,202,101,184,7,52,228,197,167,16,114,220,68,73,99,181,99,86,233,102,161,151,96,221,142,204,23,9,68,166,9,45,1,142,225,219,172,117,52,72,226,185,38,241,73,177,4,233,255,203,221,186,215,237,242,117,218,39,4,95,135,180,188,224,164,163,36,14,211,191,139,157,33,237,19,75,98,77,77,235,116,239,49,176,129,152,136,223,159,15,70,9,178,244,209,160,174,179,89,39,219,39,199,115,24,35,93,195,126,114,3,76,47,188,242,13,29,124,141,219,115,197,124,164,121,81,139,239,255,168,112,44,240,239,139,239,122,34,25,190,30,177,78,135,76,23,171,78,23,219,120,174,125,65,1,183,236,148,244,220,15,34,93,80,132,138,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e3cb340-4d0d-4fe9-b58a-97330a7996b4"));
		}

		#endregion

	}

	#endregion

}

