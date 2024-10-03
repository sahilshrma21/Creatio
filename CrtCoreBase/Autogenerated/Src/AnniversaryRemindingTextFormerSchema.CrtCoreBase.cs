namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryRemindingTextFormerSchema

	/// <exclude/>
	public class AnniversaryRemindingTextFormerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryRemindingTextFormerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryRemindingTextFormerSchema(AnniversaryRemindingTextFormerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c");
			Name = "AnniversaryRemindingTextFormer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,109,111,219,54,16,254,172,2,253,15,132,186,1,54,230,202,73,251,45,77,2,164,73,90,20,104,210,160,246,10,20,197,62,208,210,217,230,34,145,30,73,185,245,218,254,247,29,69,82,166,94,236,120,107,177,111,226,241,238,185,231,94,120,164,56,45,64,173,104,10,100,10,82,82,37,230,58,185,20,124,206,22,165,164,154,9,254,248,209,215,199,143,162,82,49,190,32,147,141,210,80,188,104,173,81,63,207,33,53,202,42,121,13,28,36,75,59,58,111,25,255,171,35,156,194,23,189,21,94,10,9,201,53,215,76,51,80,91,113,200,75,66,191,188,40,4,199,29,220,123,34,97,129,68,200,101,78,149,58,33,23,156,179,53,72,69,229,230,61,20,140,103,104,105,188,190,18,178,0,89,89,140,199,99,114,170,202,162,64,157,115,183,190,147,98,205,50,80,164,0,189,20,153,34,90,144,57,154,144,56,0,140,137,244,144,168,128,160,36,163,154,38,196,99,142,3,208,85,57,203,89,74,82,195,234,1,82,228,132,188,233,229,26,153,66,212,1,190,98,144,103,24,225,157,100,107,170,161,10,37,90,73,161,177,18,144,33,53,154,9,158,111,200,239,10,36,22,148,219,2,181,150,54,103,209,19,224,153,133,117,107,159,68,172,168,150,101,170,133,52,158,170,24,156,35,27,207,254,72,6,45,223,101,99,57,36,85,60,81,75,233,172,165,102,10,30,125,223,207,243,198,86,169,147,140,106,65,48,4,211,47,175,65,95,164,169,40,185,14,88,79,153,206,97,224,169,72,208,165,228,70,243,173,72,105,206,254,166,179,28,38,149,249,32,174,84,29,194,20,138,85,142,216,241,48,164,215,117,136,97,104,154,254,136,67,135,240,223,29,190,20,217,102,224,20,176,63,97,228,181,57,158,124,207,35,216,55,165,163,218,180,208,89,149,178,45,210,21,221,92,240,236,6,61,44,7,70,211,82,137,214,84,146,25,58,105,49,181,230,61,97,189,236,234,198,1,148,4,85,230,26,173,45,167,196,242,25,244,120,24,53,249,142,108,68,47,194,196,90,176,253,41,235,54,197,65,41,243,97,183,58,98,111,216,253,221,19,49,174,201,6,168,84,157,148,127,68,105,152,107,199,35,197,68,72,234,207,139,43,187,19,168,65,5,117,88,70,91,132,70,46,92,19,231,40,244,178,47,171,81,212,159,215,110,14,220,30,154,139,82,166,112,219,202,102,222,54,64,202,191,196,29,24,149,124,13,17,190,39,31,104,94,66,220,72,80,29,50,135,207,164,75,164,57,114,146,247,14,110,130,115,142,46,96,84,33,69,24,194,116,179,194,179,154,220,86,233,232,208,59,180,213,76,121,123,202,26,52,88,152,133,180,148,18,184,190,178,189,212,98,122,105,55,141,52,49,101,223,234,78,89,97,168,154,79,75,203,11,9,13,79,112,5,138,128,40,208,201,84,212,150,65,143,177,57,25,180,108,204,13,187,162,18,166,98,16,208,27,146,115,114,228,169,251,52,28,89,144,170,47,34,3,61,89,81,110,82,0,114,77,115,116,30,0,36,147,114,86,117,88,219,95,235,92,184,58,214,100,61,90,50,101,233,189,26,38,38,157,187,185,227,216,122,55,255,88,193,52,189,215,27,117,12,198,217,211,167,97,4,46,170,141,247,176,123,138,244,207,73,167,176,54,45,234,221,252,187,202,88,211,70,171,181,35,156,10,63,100,110,110,198,89,118,200,29,81,15,11,147,99,207,46,10,157,84,66,242,155,49,120,39,241,94,167,249,53,47,67,54,59,241,3,117,131,206,203,98,6,117,142,77,133,172,132,156,158,117,219,199,141,168,235,98,165,55,97,29,2,179,95,201,241,209,145,169,229,241,49,249,246,141,116,164,207,122,165,207,219,158,250,167,180,94,58,246,126,54,91,247,234,51,211,233,178,65,161,198,75,169,2,114,124,98,23,251,209,149,110,161,91,227,103,7,25,243,172,215,248,249,65,198,178,99,156,193,156,226,192,58,200,186,63,43,7,63,202,130,119,99,245,48,102,124,137,255,8,58,19,41,25,159,7,175,201,109,11,85,55,240,155,43,86,53,41,182,249,169,221,26,17,49,251,19,71,225,121,245,24,191,163,18,7,51,142,2,229,107,209,148,38,151,75,72,239,47,228,162,44,240,200,223,150,121,62,136,155,26,251,222,29,65,11,154,109,149,46,161,160,230,38,64,21,119,172,135,77,180,79,241,164,86,138,255,216,154,102,246,108,239,50,50,71,56,84,7,243,7,180,121,192,211,117,173,228,77,125,139,110,137,54,59,52,118,119,125,188,173,184,11,120,247,27,200,190,6,182,132,124,239,68,51,252,189,184,15,187,48,118,111,179,94,244,29,143,210,67,208,27,83,184,123,197,30,216,78,246,209,253,255,246,211,15,52,204,158,86,252,201,85,118,127,35,63,171,172,187,225,30,168,99,56,67,156,44,20,161,228,31,10,130,44,32,168,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTitleContactTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyContactTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleAccountTemplateLocalizableString());
			LocalizableStrings.Add(CreateBodyAccountTemplateLocalizableString());
			LocalizableStrings.Add(CreatestOrdinalLocalizableString());
			LocalizableStrings.Add(CreatendOrdinalLocalizableString());
			LocalizableStrings.Add(CreaterdOrdinalLocalizableString());
			LocalizableStrings.Add(CreatethOrdinalLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTitleContactTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2d0e61be-0a4a-45c0-ab9f-a90f92028ed7"),
				Name = "TitleContactTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyContactTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f88c60c5-8ecc-4ec8-89f7-67590239dfb3"),
				Name = "BodyContactTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleAccountTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("babf9ff7-7f81-4b5b-a544-3aeffb636c3b"),
				Name = "TitleAccountTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyAccountTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("56be17f0-594f-4a21-84c0-7230a14a16ea"),
				Name = "BodyAccountTemplate",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatestOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cb7b7382-9e88-48c3-91bf-c459bf541dcf"),
				Name = "stOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatendOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8df46a2e-db2a-408f-8b01-9c39f2d46c85"),
				Name = "ndOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreaterdOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8a1a6be5-802f-42f1-9056-13a65c21a853"),
				Name = "rdOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatethOrdinalLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4fb54baf-e0b3-44c0-bbf6-30d79e2a859c"),
				Name = "thOrdinal",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"),
				ModifiedInSchemaUId = new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0c0cb2d-82d8-4e7b-b5be-e3f71e54de5c"));
		}

		#endregion

	}

	#endregion

}

