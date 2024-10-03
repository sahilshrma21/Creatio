namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailHashDTOSchema

	/// <exclude/>
	public class EmailHashDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailHashDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailHashDTOSchema(EmailHashDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d659f6d2-cdbc-4628-8188-da882d020fa0");
			Name = "EmailHashDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,49,79,195,48,16,133,231,70,202,127,56,169,123,179,211,138,129,22,9,38,42,53,19,155,147,92,130,171,216,142,124,231,33,173,248,239,92,108,26,1,66,148,46,150,238,221,231,247,172,103,171,12,210,160,106,132,18,189,87,228,90,94,109,157,109,117,23,188,98,237,108,158,157,243,44,207,22,129,180,237,224,48,18,163,89,71,101,233,177,19,0,182,189,34,186,131,71,163,116,255,164,232,109,87,190,196,253,16,170,94,215,80,79,235,31,219,69,242,156,45,246,222,13,232,89,163,248,236,211,181,4,20,69,1,27,10,198,40,63,222,95,132,232,5,132,182,129,70,49,174,102,176,248,74,126,198,239,132,40,181,65,56,8,63,13,112,134,14,121,45,247,229,120,191,30,19,170,35,214,252,119,8,177,143,237,36,246,198,132,202,53,227,191,236,31,4,188,245,245,151,146,128,165,131,147,179,87,218,154,154,122,21,234,217,182,110,30,126,203,92,138,113,250,188,56,39,245,187,24,181,15,200,11,232,131,96,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d659f6d2-cdbc-4628-8188-da882d020fa0"));
		}

		#endregion

	}

	#endregion

}

