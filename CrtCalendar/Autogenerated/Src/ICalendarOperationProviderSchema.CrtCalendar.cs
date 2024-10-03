namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarOperationProviderSchema

	/// <exclude/>
	public class ICalendarOperationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarOperationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarOperationProviderSchema(ICalendarOperationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("612d2abe-2c2a-4f21-8270-8e0f51100801");
			Name = "ICalendarOperationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,219,106,219,64,16,125,142,193,255,48,248,41,133,34,125,64,20,65,113,74,49,148,36,164,110,251,80,242,176,146,70,238,210,189,136,189,184,136,210,127,239,140,172,181,82,187,198,166,208,135,130,64,236,50,115,230,156,163,51,50,66,163,239,68,141,176,70,231,132,183,109,200,150,214,180,114,19,157,8,210,154,108,41,20,154,70,56,63,159,253,152,207,174,162,151,102,3,31,122,31,80,223,28,156,169,83,41,172,185,205,103,239,208,160,147,245,84,115,98,192,84,144,38,173,165,198,143,70,6,184,61,79,42,75,197,4,67,64,121,158,67,225,163,214,194,245,229,120,126,194,206,161,71,19,60,8,168,199,70,176,29,238,176,160,115,118,43,27,116,89,234,207,95,0,116,177,82,178,6,105,2,186,150,109,90,165,209,15,9,224,113,236,167,106,54,232,136,195,112,241,166,105,104,250,86,168,136,96,91,8,196,26,34,209,246,16,44,52,34,32,235,128,170,159,8,74,211,90,167,119,114,247,176,249,33,110,209,9,39,52,24,250,140,183,139,132,179,40,19,201,97,80,86,228,67,213,159,155,6,78,139,242,19,191,142,43,29,134,232,140,63,2,76,247,92,120,151,232,147,200,235,253,33,145,121,205,230,237,148,191,218,125,164,255,205,161,48,70,108,81,174,19,169,127,109,233,151,135,202,91,133,1,159,47,49,248,104,113,18,227,75,189,31,118,149,224,38,111,27,209,251,223,204,254,142,248,13,104,199,59,69,117,127,101,119,29,213,184,112,114,107,207,56,200,211,252,210,70,67,166,223,71,93,161,227,76,12,183,28,135,205,200,247,2,115,89,200,129,185,239,165,15,197,126,143,239,68,95,238,13,248,204,19,78,101,120,34,117,198,76,206,236,87,124,17,225,75,253,162,95,138,180,141,167,160,81,251,120,56,173,113,61,173,72,205,172,14,100,50,101,226,146,66,225,175,87,111,77,212,36,179,82,88,36,137,43,254,177,81,64,202,52,142,165,93,253,156,207,232,249,5,154,29,26,180,28,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("612d2abe-2c2a-4f21-8270-8e0f51100801"));
		}

		#endregion

	}

	#endregion

}

