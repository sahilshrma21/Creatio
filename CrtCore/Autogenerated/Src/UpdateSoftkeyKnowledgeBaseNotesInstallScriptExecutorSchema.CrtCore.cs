namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutorSchema

	/// <exclude/>
	public class UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutorSchema(UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ef4e205b-067a-4986-8306-0390f15d3609");
			Name = "UpdateSoftkeyKnowledgeBaseNotesInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1296b383-c2ef-47b8-ae67-0601cddb70e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,81,111,218,48,16,126,78,165,254,7,47,123,9,18,65,20,232,182,194,86,137,20,168,208,84,54,149,118,175,149,155,28,137,87,199,142,108,7,136,16,255,189,78,28,84,8,129,237,209,119,159,239,190,251,206,159,25,142,65,38,216,7,244,4,66,96,201,23,170,117,199,217,130,132,169,192,138,112,118,121,177,185,188,176,82,73,88,136,230,153,84,16,15,42,103,141,167,20,252,28,44,91,247,192,64,16,255,3,179,95,54,142,57,171,207,8,56,21,111,141,153,34,138,128,212,0,13,73,210,87,74,124,228,83,44,37,122,78,2,172,96,174,161,111,144,253,100,124,69,33,8,193,195,18,102,92,129,156,50,169,48,165,115,95,144,68,141,215,224,167,138,11,212,71,211,218,132,46,190,41,90,88,159,5,132,122,24,52,33,64,3,217,71,191,5,89,234,62,38,153,152,3,122,150,32,180,80,204,12,142,94,210,131,243,96,31,90,76,144,205,253,8,98,252,128,25,14,65,160,23,56,14,14,202,246,192,2,195,224,144,206,3,168,136,159,228,179,228,36,64,119,17,102,225,105,65,156,6,202,151,105,89,134,17,122,219,71,148,177,31,181,212,244,94,149,1,120,217,76,63,25,199,62,168,110,55,171,2,52,10,5,172,251,84,179,146,134,207,35,248,92,4,211,64,183,96,176,66,121,202,177,199,95,187,163,118,111,232,185,157,225,151,43,183,119,253,173,227,222,220,76,186,174,215,30,122,237,78,123,116,221,233,221,217,101,177,37,22,200,231,44,32,197,83,43,203,140,72,209,15,139,236,187,84,66,191,159,38,226,175,127,53,137,219,114,86,107,131,236,105,160,25,86,104,108,139,236,214,148,38,11,228,124,170,145,163,53,1,229,71,19,193,227,145,231,124,244,110,236,132,180,4,168,84,152,117,91,166,162,97,129,88,46,184,230,88,87,84,139,249,148,37,16,104,227,164,49,251,131,105,10,37,249,91,199,46,54,181,27,57,231,85,84,106,77,229,44,165,244,151,24,199,137,202,156,115,4,118,157,205,189,71,72,168,182,183,99,47,40,172,221,128,8,179,159,190,86,50,111,62,136,128,132,145,234,163,171,118,59,89,15,98,194,220,21,9,84,212,71,221,34,160,117,59,117,243,24,91,146,174,27,121,14,106,111,218,221,148,77,67,242,220,61,188,4,103,129,169,4,3,218,254,175,71,138,127,162,180,136,249,51,10,135,24,183,131,83,177,111,229,241,150,226,86,222,180,214,180,198,229,86,157,95,142,160,173,154,79,192,92,255,167,103,207,204,173,163,69,226,29,3,202,117,212,198,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef4e205b-067a-4986-8306-0390f15d3609"));
		}

		#endregion

	}

	#endregion

}

