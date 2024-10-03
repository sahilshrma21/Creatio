namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClassicPageUITypeForFreedomHostInstallScriptExecutorSchema

	/// <exclude/>
	public class ClassicPageUITypeForFreedomHostInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClassicPageUITypeForFreedomHostInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClassicPageUITypeForFreedomHostInstallScriptExecutorSchema(ClassicPageUITypeForFreedomHostInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0554340b-f6e2-490c-99d5-a9b58d70988f");
			Name = "ClassicPageUITypeForFreedomHostInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3967a9e7-8d4f-4777-81c6-ec5d8afe4ee6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,239,107,219,48,16,253,236,66,255,135,155,247,197,134,198,148,38,205,178,102,43,228,135,67,13,27,20,220,236,187,42,95,50,49,69,10,146,156,173,148,254,239,61,75,46,77,156,5,198,252,193,214,189,123,220,61,189,59,131,98,27,180,91,198,17,30,208,24,102,245,202,101,51,173,86,98,93,27,230,132,86,231,103,207,231,103,81,109,133,90,31,80,12,142,79,224,217,124,74,41,160,39,100,27,172,124,178,37,58,71,161,133,175,93,254,65,191,108,143,74,101,168,199,71,131,107,74,192,76,50,107,111,194,71,240,123,182,198,101,241,240,180,197,133,54,11,131,88,233,205,157,182,174,80,214,49,41,75,110,196,214,229,127,144,215,78,27,95,71,40,135,70,49,9,188,169,240,95,117,224,6,138,19,13,162,103,223,228,93,173,110,120,202,145,226,123,35,118,204,97,200,111,67,0,188,201,131,117,198,91,20,180,44,139,70,141,45,42,242,40,158,143,174,250,87,195,203,121,239,211,245,52,239,13,6,121,222,27,229,253,73,111,56,252,60,157,142,250,147,235,89,62,136,199,109,83,84,85,232,123,40,226,59,186,159,186,218,151,16,69,251,34,30,181,150,112,199,44,121,254,77,240,100,105,209,144,110,133,188,153,4,141,111,63,76,161,89,132,40,218,49,3,22,37,129,164,82,225,111,40,125,144,116,216,158,27,209,108,101,189,81,201,162,86,156,206,181,114,73,64,178,137,165,105,8,251,43,73,211,55,238,194,232,77,18,7,45,113,58,246,168,65,87,27,213,54,204,130,221,88,114,38,153,249,66,3,189,77,82,184,133,75,207,125,57,246,34,220,246,216,141,250,81,10,222,206,195,159,97,167,69,5,109,249,127,243,65,172,32,249,240,238,93,135,244,198,106,47,16,46,243,226,223,157,255,33,163,195,15,38,107,236,148,184,128,56,175,132,243,27,241,183,5,141,47,142,214,38,61,229,3,197,1,61,4,9,123,5,225,51,94,86,1,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0554340b-f6e2-490c-99d5-a9b58d70988f"));
		}

		#endregion

	}

	#endregion

}

