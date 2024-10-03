namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormDataOptionsSchema

	/// <exclude/>
	public class FormDataOptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormDataOptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormDataOptionsSchema(FormDataOptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d42f939-512c-48fc-a714-f267c7a43313");
			Name = "FormDataOptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fde60690-6c92-48a2-8124-1d9224eb59b6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,203,78,195,48,16,60,131,196,63,172,196,61,189,3,66,66,188,78,136,170,69,226,188,177,167,169,145,99,71,246,38,37,170,248,119,54,73,139,160,32,144,184,196,217,241,236,204,172,237,192,53,114,195,6,244,132,148,56,199,149,20,215,49,172,92,213,38,22,23,67,113,143,0,253,133,125,70,121,23,83,189,68,234,156,193,201,241,246,228,248,168,205,46,84,180,236,179,160,62,63,168,139,29,243,33,90,248,95,55,11,149,254,157,112,101,196,117,99,30,229,41,243,52,161,210,130,174,61,231,124,70,67,174,27,22,126,108,6,74,30,41,179,217,140,46,114,91,215,156,250,203,93,173,147,9,187,144,137,173,117,86,169,236,41,78,61,180,138,137,150,220,97,55,230,99,249,2,35,131,232,94,107,246,73,172,105,75,239,12,153,193,254,187,251,209,118,76,240,145,114,158,98,131,36,14,26,117,62,118,78,251,135,17,71,224,206,115,69,46,88,103,244,208,51,201,154,133,2,96,179,130,198,183,22,132,87,131,209,138,164,111,160,48,37,189,67,117,6,109,214,8,228,68,187,82,220,100,178,109,26,78,52,115,55,44,8,226,164,47,62,156,63,15,180,159,168,140,209,171,129,32,216,197,78,244,217,201,250,118,111,249,52,56,110,169,130,156,83,30,62,111,255,26,69,162,154,192,180,2,205,190,66,66,162,53,216,234,210,177,119,118,122,121,127,7,181,46,115,233,177,152,36,230,81,55,250,159,210,157,234,56,211,93,140,245,132,126,5,21,123,7,131,62,208,82,12,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d42f939-512c-48fc-a714-f267c7a43313"));
		}

		#endregion

	}

	#endregion

}

