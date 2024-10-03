namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SLMExtensionsSchema

	/// <exclude/>
	public class SLMExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SLMExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SLMExtensionsSchema(SLMExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e");
			Name = "SLMExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,193,110,219,48,12,61,187,64,255,129,232,46,233,48,216,247,38,205,37,27,176,2,203,48,160,222,118,86,109,38,22,106,75,134,40,165,11,138,254,251,40,201,178,155,164,107,177,75,143,36,31,249,30,169,103,43,209,33,245,162,66,40,209,24,65,122,99,243,149,86,27,185,117,70,88,169,85,126,251,109,253,229,143,69,69,28,208,249,217,227,249,89,230,72,170,237,191,26,230,111,1,242,149,104,81,213,194,208,4,77,169,82,118,248,83,73,11,215,111,119,231,9,204,99,120,208,7,131,91,174,195,170,21,68,112,5,71,186,25,81,20,5,44,200,117,157,48,251,229,16,223,246,88,201,141,172,60,28,208,227,61,9,116,104,27,93,83,158,186,138,103,109,189,187,107,185,129,44,235,169,160,10,116,71,100,217,99,32,28,53,173,227,56,86,245,35,52,199,234,177,158,144,224,101,119,104,44,65,229,140,97,53,96,121,75,176,104,58,176,26,108,131,80,105,46,80,175,85,237,47,55,149,31,164,109,160,147,202,89,140,89,199,183,201,71,162,226,152,105,209,11,35,58,80,236,128,235,11,63,225,98,185,74,156,28,45,138,80,159,224,6,173,51,138,150,101,98,204,23,69,202,121,208,225,93,60,170,244,178,134,133,74,189,14,210,104,102,27,73,83,217,15,186,4,239,170,44,219,9,3,188,154,107,253,251,43,124,24,81,179,203,121,0,196,226,104,129,155,154,113,65,201,148,137,64,226,99,84,13,204,66,177,220,247,152,40,178,74,16,158,216,45,255,170,157,185,138,128,68,226,187,120,252,9,52,174,49,63,4,255,18,173,195,36,38,6,31,199,86,190,0,89,26,26,233,70,121,178,212,127,103,80,220,207,95,147,246,91,155,123,126,232,255,80,56,116,188,183,208,207,98,255,174,39,60,45,251,44,23,89,200,75,170,107,220,8,38,58,212,56,16,190,128,127,122,238,184,239,236,233,29,142,166,61,116,103,178,214,107,182,252,20,33,195,69,70,91,14,233,211,221,163,132,228,122,255,145,13,95,70,72,61,13,191,23,30,30,255,48,33,142,217,195,36,231,254,2,236,236,255,238,227,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e"));
		}

		#endregion

	}

	#endregion

}

