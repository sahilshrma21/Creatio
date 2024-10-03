namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateLanguageHandlerSchema

	/// <exclude/>
	public class EmailTemplateLanguageHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateLanguageHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateLanguageHandlerSchema(EmailTemplateLanguageHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce5d036c-9766-420e-a3b2-131f211f241e");
			Name = "EmailTemplateLanguageHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,219,74,195,64,16,125,110,161,255,48,212,23,133,218,188,107,45,136,10,10,21,74,205,15,76,147,105,92,220,236,198,153,93,161,136,255,110,110,27,155,42,85,17,124,203,204,206,156,61,151,141,193,156,164,192,132,32,38,102,20,187,113,211,43,107,54,42,243,140,78,89,51,26,190,142,134,163,225,224,136,41,43,75,184,210,40,114,6,55,57,42,29,83,94,104,116,180,64,147,121,204,232,22,77,170,137,235,249,40,138,96,38,62,207,145,183,243,182,190,52,128,107,113,140,137,3,58,173,16,192,181,16,160,91,12,96,74,72,189,16,79,3,72,180,135,50,99,42,203,39,153,95,147,168,204,80,10,40,128,144,60,162,50,96,55,37,128,20,214,136,90,43,173,220,118,58,139,194,124,216,119,219,130,10,100,204,193,148,234,47,198,241,138,158,61,137,27,207,227,242,164,129,168,27,229,110,55,123,104,91,188,238,45,87,245,254,110,225,215,90,37,31,250,147,202,199,131,54,206,2,175,9,180,119,84,56,77,26,93,28,75,182,5,177,83,84,102,178,172,175,104,206,247,237,175,27,15,62,73,72,196,214,222,126,54,55,112,252,37,169,15,88,120,173,80,6,25,185,243,250,67,218,143,183,150,51,153,180,161,221,215,112,79,238,209,166,63,17,208,144,144,46,159,175,101,212,157,221,136,56,228,187,234,114,237,114,9,79,202,121,54,50,95,133,236,66,99,199,150,23,197,206,163,14,186,91,50,199,193,144,64,234,164,117,161,65,8,83,28,92,51,94,235,147,93,87,254,87,232,238,116,248,247,22,22,83,226,63,186,211,61,236,111,236,153,192,93,220,187,23,250,52,42,111,190,124,46,141,93,253,102,217,123,7,86,195,82,243,193,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce5d036c-9766-420e-a3b2-131f211f241e"));
		}

		#endregion

	}

	#endregion

}

