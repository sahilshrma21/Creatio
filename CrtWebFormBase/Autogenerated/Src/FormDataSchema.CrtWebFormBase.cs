namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormDataSchema

	/// <exclude/>
	public class FormDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormDataSchema(FormDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9805f18b-4967-42e0-a558-71a8afcae843");
			Name = "FormData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fde60690-6c92-48a2-8124-1d9224eb59b6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,193,106,195,48,12,134,207,11,228,29,4,189,231,1,214,211,232,232,216,97,172,208,65,15,101,7,215,86,130,33,177,131,164,20,70,232,187,87,118,66,75,203,40,219,197,182,254,255,255,100,217,193,116,200,189,177,8,95,72,100,56,214,82,173,98,168,125,51,144,17,31,67,245,134,1,245,136,110,135,135,117,164,110,139,116,244,22,203,98,44,139,167,129,125,104,96,251,195,130,221,242,174,174,230,228,71,116,216,62,52,43,109,253,56,240,98,197,31,243,60,154,211,228,130,176,209,2,86,173,97,126,134,52,215,171,17,147,189,126,56,180,222,130,77,214,197,129,49,123,23,112,67,177,71,18,143,74,111,50,48,249,51,204,66,105,148,90,233,119,7,35,52,40,75,224,180,156,110,114,169,253,218,99,235,56,93,178,255,206,196,85,248,15,105,99,16,99,229,207,112,138,124,246,233,75,24,226,188,255,66,44,48,184,233,205,90,77,218,141,84,22,42,158,1,199,166,142,77,6,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9805f18b-4967-42e0-a558-71a8afcae843"));
		}

		#endregion

	}

	#endregion

}

