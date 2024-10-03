namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUtilsSchema

	/// <exclude/>
	public class EmailUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUtilsSchema(EmailUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16897125-c693-4777-9da7-082cb0569c67");
			Name = "EmailUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ce224767-e889-460a-86ca-36a387a79bb0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,82,203,110,219,64,12,60,203,128,255,129,117,15,149,154,118,117,79,20,53,69,16,244,210,0,65,146,246,210,244,176,149,40,123,81,61,12,114,85,217,8,242,239,217,93,74,142,229,94,100,147,156,25,206,14,216,234,6,121,171,11,132,71,36,210,220,85,86,93,119,109,101,214,61,105,107,186,118,185,120,94,46,162,158,77,187,134,135,61,91,108,220,188,174,177,240,67,86,223,176,69,50,197,197,41,230,17,119,86,221,227,186,175,53,221,236,182,132,204,30,239,112,14,249,158,112,237,42,184,174,53,243,57,220,52,218,212,63,172,169,57,76,211,52,133,140,251,166,209,180,207,199,218,89,178,218,180,12,189,131,25,187,135,6,237,166,43,25,170,142,96,232,232,47,12,198,110,68,73,77,26,233,145,200,182,255,83,155,2,216,186,71,21,80,248,197,71,123,225,57,108,62,24,187,21,245,115,184,11,52,25,158,250,10,141,123,180,61,57,95,181,97,11,93,5,232,53,249,19,48,250,136,176,132,138,186,6,178,173,38,221,16,86,208,186,188,47,87,164,135,7,75,46,174,85,154,171,131,118,122,42,46,180,255,56,121,48,14,186,44,125,172,80,72,54,62,124,14,0,149,165,129,248,166,67,226,50,255,126,236,114,18,64,118,132,9,225,41,243,172,60,39,19,225,28,238,52,49,134,245,95,133,28,203,4,14,238,18,159,101,20,69,255,52,141,97,192,37,180,56,204,116,226,228,34,128,220,129,224,14,40,124,5,21,58,241,213,42,254,146,5,118,254,52,156,197,191,62,159,169,15,191,221,191,228,227,149,212,74,170,39,53,43,147,213,168,235,151,55,218,22,27,244,219,131,190,186,149,58,126,115,42,88,119,65,168,139,13,196,1,32,52,48,237,196,159,222,19,153,10,226,119,242,34,53,157,99,28,64,234,167,174,123,76,14,200,104,68,185,136,102,0,217,23,189,132,31,249,74,236,99,80,97,254,50,94,34,182,165,28,99,168,165,59,111,186,30,44,23,175,18,8,81,161,193,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16897125-c693-4777-9da7-082cb0569c67"));
		}

		#endregion

	}

	#endregion

}

