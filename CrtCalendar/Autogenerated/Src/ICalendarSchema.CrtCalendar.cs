namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarSchema

	/// <exclude/>
	public class ICalendarSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarSchema(ICalendarSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77b2d1ec-9baf-4fa5-be75-9d8f0bdfecfb");
			Name = "ICalendar";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,207,106,131,64,16,135,207,6,242,14,131,15,160,247,214,228,146,66,16,10,133,86,40,244,182,209,217,100,233,186,43,59,107,131,45,125,247,142,214,63,96,147,64,74,192,28,54,243,253,220,111,102,52,162,68,170,68,142,144,161,115,130,172,244,209,198,26,169,246,181,19,94,89,19,109,132,70,83,8,71,203,197,215,114,17,212,164,204,30,94,26,242,88,222,207,206,156,212,26,243,54,70,209,22,13,58,149,51,195,84,28,199,144,80,93,150,194,53,235,254,252,140,149,67,66,227,9,242,254,14,80,70,90,87,254,94,60,196,226,89,46,241,77,133,149,112,162,4,195,246,171,48,11,215,233,96,249,32,154,36,30,129,49,66,136,66,147,133,220,161,92,133,189,109,186,209,214,160,216,105,12,33,110,209,170,222,105,149,179,132,71,39,219,153,140,175,77,178,53,220,193,20,0,166,131,227,1,29,207,173,43,76,215,115,165,157,211,159,150,187,63,182,200,221,250,3,130,42,184,113,37,21,186,104,132,227,57,157,124,8,93,227,120,204,206,229,38,108,91,171,2,210,2,58,131,96,143,190,93,81,240,221,237,224,130,145,117,64,131,153,87,37,194,39,247,121,157,216,169,216,68,101,92,125,227,98,202,251,133,225,48,179,12,232,63,186,133,104,192,74,73,215,217,158,72,77,80,250,168,200,183,27,231,109,62,49,116,19,207,35,226,59,240,87,87,105,225,175,28,237,185,232,9,227,87,70,179,158,188,160,221,254,248,249,1,200,42,86,83,253,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77b2d1ec-9baf-4fa5-be75-9d8f0bdfecfb"));
		}

		#endregion

	}

	#endregion

}

