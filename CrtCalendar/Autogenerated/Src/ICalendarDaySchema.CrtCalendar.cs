namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarDaySchema

	/// <exclude/>
	public class ICalendarDaySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarDaySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarDaySchema(ICalendarDaySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5");
			Name = "ICalendarDay";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,106,195,48,12,61,183,208,127,240,113,187,36,247,181,228,210,66,9,140,237,176,148,158,157,88,41,166,142,157,73,246,74,24,251,247,201,105,178,150,178,92,2,57,200,210,123,122,207,146,99,101,3,212,202,10,68,1,136,146,92,237,147,173,179,181,62,5,148,94,59,155,108,165,1,171,36,210,106,249,189,90,46,2,105,123,18,31,29,121,104,214,15,103,102,26,3,85,164,81,178,7,11,168,43,198,48,170,13,165,209,149,208,214,3,214,81,45,31,219,238,100,39,94,248,104,156,5,89,26,96,112,148,89,164,105,42,54,20,154,70,98,151,141,137,8,118,181,184,0,156,147,63,80,122,143,98,196,123,125,228,186,184,69,125,191,197,9,252,186,15,104,8,126,122,103,255,11,141,238,132,146,30,10,221,192,164,220,181,44,110,215,25,18,51,68,223,156,21,23,135,231,56,80,197,55,109,209,181,128,190,155,208,46,157,51,34,39,102,29,7,210,12,205,145,234,163,231,126,61,95,210,208,132,226,171,38,191,25,24,249,128,205,196,67,130,230,216,56,88,253,25,216,128,2,235,117,173,1,227,154,227,12,124,215,78,205,126,31,180,138,91,46,24,114,200,213,28,217,61,248,94,229,114,55,133,9,181,62,131,224,3,90,202,118,15,156,77,58,86,34,84,57,126,237,16,155,15,163,137,15,226,233,249,250,39,176,29,254,126,1,11,212,244,67,119,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5"));
		}

		#endregion

	}

	#endregion

}

