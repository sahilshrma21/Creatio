namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarDataStoreSchema

	/// <exclude/>
	public class ICalendarDataStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarDataStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarDataStoreSchema(ICalendarDataStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a242fa2e-8226-41ca-826d-a20b92e1d9d5");
			Name = "ICalendarDataStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,145,177,110,131,48,16,134,103,144,120,135,83,166,116,193,123,75,89,146,165,82,167,146,23,184,192,65,44,129,141,238,76,42,20,245,221,107,28,32,73,219,169,146,101,201,246,255,221,125,182,13,118,36,61,150,4,7,98,70,177,181,75,119,214,212,186,25,24,157,182,38,221,97,75,166,66,150,36,190,36,113,52,136,54,13,20,163,56,234,94,146,216,239,40,165,32,147,161,235,144,199,124,94,127,80,207,36,100,156,0,66,57,87,128,10,29,130,56,203,148,46,156,186,3,251,225,216,234,18,180,113,196,245,164,244,182,244,222,123,176,152,184,236,144,195,231,137,216,235,194,243,237,60,187,75,134,82,151,40,242,243,47,181,176,241,110,177,146,155,148,54,181,229,238,122,215,149,81,63,161,172,71,198,14,140,127,174,215,205,194,110,242,221,122,53,159,31,211,76,133,88,160,206,86,87,161,215,150,169,246,186,11,244,116,125,181,191,221,10,60,19,148,39,52,13,9,216,122,133,254,111,246,224,20,242,76,110,96,35,121,49,148,37,73,104,99,123,154,127,59,83,203,241,148,63,90,219,6,167,237,163,127,244,149,196,126,124,3,251,77,91,219,61,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a242fa2e-8226-41ca-826d-a20b92e1d9d5"));
		}

		#endregion

	}

	#endregion

}

