namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileUploadExceptionsSchema

	/// <exclude/>
	public class FileUploadExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileUploadExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileUploadExceptionsSchema(FileUploadExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69");
			Name = "FileUploadExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,146,75,107,194,64,16,199,207,10,253,14,67,188,40,72,114,183,234,69,90,16,42,148,106,123,31,147,137,46,36,187,97,103,83,31,165,223,189,147,135,26,42,218,67,95,167,101,231,241,155,255,236,254,53,166,196,25,134,4,11,178,22,217,196,206,159,24,29,171,85,110,209,41,163,253,123,149,208,115,150,24,140,110,218,111,55,237,86,206,74,175,96,190,99,71,233,237,241,222,236,78,83,163,37,35,185,142,165,149,48,96,146,32,243,0,102,184,45,104,115,181,167,187,109,72,20,81,84,156,89,49,167,172,15,130,0,134,156,167,41,218,221,184,190,47,214,4,116,168,2,183,70,7,138,229,180,102,163,97,179,38,13,177,48,129,5,90,36,168,6,251,7,92,208,224,101,249,50,81,33,132,133,156,171,106,96,0,13,101,173,98,239,211,50,70,179,179,121,232,140,149,157,30,75,100,169,254,76,126,25,152,88,66,71,12,74,186,80,203,67,155,24,220,46,35,169,36,130,208,82,60,242,174,73,241,130,177,127,132,7,159,233,195,12,45,166,160,229,27,71,30,139,36,92,145,55,126,34,54,185,149,89,117,196,31,6,101,93,217,86,63,194,181,153,221,233,129,48,175,0,7,80,175,0,180,90,3,88,34,83,87,211,6,30,76,136,137,218,227,82,80,206,138,21,186,117,105,31,188,147,117,142,100,246,250,21,194,59,107,100,255,154,164,25,49,23,155,188,96,146,147,215,235,65,249,39,239,213,195,119,72,71,213,239,200,173,138,53,67,231,78,156,234,87,25,30,53,167,253,168,11,85,197,255,218,132,151,132,252,177,1,47,201,248,45,243,93,154,247,79,198,187,36,231,59,166,147,200,7,22,215,44,97,93,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMaxFileSizeExceededExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateInvalidFileSizeExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMaxFileSizeExceededExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4f2e8a1b-07d3-4f66-9213-287d5ef48032"),
				Name = "MaxFileSizeExceededExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"),
				ModifiedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidFileSizeExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5880e243-dfed-417c-ae92-4c19a2d2bc78"),
				Name = "InvalidFileSizeExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"),
				ModifiedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"));
		}

		#endregion

	}

	#endregion

}

