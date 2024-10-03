namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCustomerServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCustomerServiceSchema(CalendarRemindCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187");
			Name = "CalendarRemindCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,75,107,194,64,16,62,39,224,127,24,244,18,65,114,232,81,107,47,65,36,135,66,169,214,75,233,97,221,140,118,33,217,13,251,80,130,250,223,59,217,196,54,218,90,188,132,157,217,124,175,153,117,70,200,45,44,42,99,177,152,244,66,231,203,37,106,205,140,218,216,56,81,26,169,221,11,37,43,208,148,140,227,197,165,220,136,173,211,204,10,37,123,225,161,23,6,127,225,227,153,180,194,10,52,158,40,24,104,220,210,255,144,228,204,152,49,36,44,71,153,49,253,138,133,144,25,85,220,229,204,42,157,56,99,85,129,122,129,122,39,56,122,104,233,214,185,224,192,107,228,189,64,184,45,177,122,32,206,218,245,143,39,37,141,213,142,211,37,89,123,209,98,199,108,35,29,148,77,113,175,108,244,102,80,19,157,68,94,79,7,220,69,57,172,25,131,49,172,153,193,232,234,10,188,163,83,163,58,32,173,198,91,91,183,70,159,209,126,170,172,246,232,71,210,90,108,198,99,44,45,132,223,61,159,68,35,229,74,41,56,147,28,175,99,120,163,193,191,97,70,48,119,34,3,78,89,210,172,181,31,248,157,87,190,217,30,167,48,71,155,124,215,209,53,73,131,31,129,196,253,251,7,28,160,223,90,72,233,101,166,89,127,4,125,218,135,210,4,165,10,78,195,137,215,17,27,136,186,34,83,144,46,207,225,120,236,72,199,36,188,172,74,204,18,149,187,66,174,88,238,240,177,246,252,20,117,57,135,53,186,110,199,179,162,180,213,57,73,160,209,58,45,61,111,163,121,242,223,115,27,247,119,191,137,95,155,134,164,59,159,78,142,211,228,198,35,104,123,221,22,117,190,0,137,227,181,160,198,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187"));
		}

		#endregion

	}

	#endregion

}

