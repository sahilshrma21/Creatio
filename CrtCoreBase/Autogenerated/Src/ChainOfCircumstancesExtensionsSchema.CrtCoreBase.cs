namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChainOfCircumstancesExtensionsSchema

	/// <exclude/>
	public class ChainOfCircumstancesExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChainOfCircumstancesExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChainOfCircumstancesExtensionsSchema(ChainOfCircumstancesExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c54472f-f2a2-4576-973d-73866d39766e");
			Name = "ChainOfCircumstancesExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,207,78,195,48,12,198,207,155,180,119,48,227,192,38,161,246,14,91,37,52,118,4,38,216,11,100,169,187,69,106,146,146,56,136,105,226,221,201,159,182,235,38,36,46,109,243,217,63,231,179,93,197,36,218,134,113,132,45,26,195,172,174,40,91,105,85,137,189,51,140,132,86,147,241,105,50,30,57,43,212,30,62,142,150,80,62,78,198,94,185,53,184,247,97,88,213,204,218,7,88,29,152,80,111,213,74,24,238,164,37,166,56,218,245,55,161,178,62,201,70,34,207,115,88,88,39,37,51,199,162,61,71,12,116,5,124,8,2,246,100,214,129,249,128,108,220,174,22,28,124,54,249,23,15,14,254,53,48,58,69,19,189,239,23,164,131,46,189,243,77,44,150,130,215,22,163,240,4,92,75,233,145,70,91,226,90,149,34,204,197,159,132,162,48,21,58,48,242,15,4,131,214,213,4,210,89,82,119,4,59,132,174,4,131,18,43,22,130,95,172,118,24,26,94,52,204,48,105,176,2,229,87,176,156,110,223,35,61,205,139,172,199,46,154,78,10,29,27,140,228,21,86,108,125,32,212,77,38,178,69,222,103,158,225,33,200,195,188,60,230,125,199,79,79,92,101,27,36,103,148,45,54,195,182,125,90,167,135,196,203,77,108,12,150,130,51,194,69,107,171,128,87,77,207,169,245,94,155,209,65,252,189,175,51,22,45,205,33,252,122,163,81,186,176,27,239,178,128,155,245,167,99,181,157,37,229,190,27,238,172,197,231,243,199,192,253,180,11,71,85,166,157,199,115,82,47,69,175,253,2,77,36,221,183,8,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c54472f-f2a2-4576-973d-73866d39766e"));
		}

		#endregion

	}

	#endregion

}

