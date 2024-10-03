namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormFieldsDataSchema

	/// <exclude/>
	public class FormFieldsDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormFieldsDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormFieldsDataSchema(FormFieldsDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91497938-5465-4428-8b59-f6b868ea29b1");
			Name = "FormFieldsData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fde60690-6c92-48a2-8124-1d9224eb59b6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,205,10,131,48,16,132,207,10,190,67,160,119,31,160,61,21,139,61,21,132,22,122,142,113,42,129,152,200,110,20,138,244,221,27,99,41,244,7,47,33,51,251,101,118,136,149,29,184,151,10,226,2,34,201,238,230,243,194,217,155,110,7,146,94,59,155,31,97,17,174,104,174,168,75,71,221,25,52,106,133,44,157,178,52,25,88,219,86,156,239,236,209,237,190,116,254,34,79,174,129,89,29,230,33,122,29,216,43,175,199,216,39,112,129,220,16,218,32,68,97,36,243,86,204,189,74,13,211,240,65,122,25,137,126,168,141,86,66,205,192,207,60,153,34,243,142,169,200,245,32,175,17,178,170,248,112,153,191,66,216,211,92,204,134,191,18,147,104,225,119,130,231,227,241,143,26,165,25,254,98,27,216,102,217,23,245,226,126,154,193,123,2,82,175,113,100,145,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91497938-5465-4428-8b59-f6b868ea29b1"));
		}

		#endregion

	}

	#endregion

}

