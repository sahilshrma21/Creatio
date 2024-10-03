namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailTemplateLanguageHelperSchema

	/// <exclude/>
	public class IEmailTemplateLanguageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailTemplateLanguageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailTemplateLanguageHelperSchema(IEmailTemplateLanguageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06ed1bb-262f-444b-a442-af9c8800a88f");
			Name = "IEmailTemplateLanguageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,145,207,74,196,48,16,198,207,91,232,59,12,123,82,144,230,1,172,123,145,101,45,236,73,251,2,99,51,173,129,38,41,147,228,176,136,239,110,19,251,199,186,94,5,161,16,58,153,239,251,126,51,49,168,201,13,216,16,212,196,140,206,182,190,120,180,166,85,93,96,244,202,154,60,123,207,179,93,112,202,116,240,114,113,158,244,125,158,141,21,33,4,148,46,104,141,124,57,76,255,149,241,196,109,52,107,45,195,192,182,33,151,132,104,128,52,170,30,70,249,208,163,167,177,34,193,17,114,243,22,239,27,171,117,48,170,73,137,208,163,233,2,118,84,204,49,226,91,206,16,94,123,213,128,90,162,170,99,116,174,39,227,243,164,125,162,126,32,30,251,35,253,21,108,42,156,200,131,164,22,67,239,151,200,4,238,200,200,72,181,69,46,22,35,241,211,169,28,144,81,131,25,119,249,176,159,251,43,185,63,28,183,67,43,89,138,212,186,42,153,124,96,227,14,207,233,92,57,148,44,74,49,95,198,238,83,80,50,34,207,3,86,242,38,149,214,184,219,175,135,249,199,195,254,166,60,91,148,196,87,106,231,45,211,95,110,235,14,170,122,131,0,91,162,184,205,221,71,158,141,223,39,65,79,128,237,36,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06ed1bb-262f-444b-a442-af9c8800a88f"));
		}

		#endregion

	}

	#endregion

}

