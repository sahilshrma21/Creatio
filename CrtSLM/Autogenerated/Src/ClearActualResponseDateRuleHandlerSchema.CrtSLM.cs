namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearActualResponseDateRuleHandlerSchema

	/// <exclude/>
	public class ClearActualResponseDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearActualResponseDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearActualResponseDateRuleHandlerSchema(ClearActualResponseDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49896338-f1b3-42b4-a897-a58e4a82829a");
			Name = "ClearActualResponseDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,220,105,169,212,134,190,14,85,17,208,222,183,201,146,90,114,236,200,15,36,84,241,239,245,35,17,36,37,162,39,107,199,51,59,59,107,115,40,81,85,144,33,217,160,148,160,196,86,39,169,224,91,90,24,9,154,10,62,28,252,12,7,145,81,148,23,100,189,87,26,203,155,78,157,44,64,195,31,48,21,140,97,230,58,168,228,25,57,74,154,29,57,167,94,101,41,248,249,27,137,125,120,178,120,232,189,122,228,154,106,138,170,151,240,4,153,22,178,151,113,146,61,73,129,33,207,65,58,170,37,143,37,22,22,38,41,3,165,102,246,64,144,247,153,54,192,86,118,137,54,41,218,85,224,202,48,124,1,158,51,148,94,85,153,47,70,51,146,57,209,63,52,100,58,157,145,215,20,84,187,81,228,158,225,56,129,21,106,105,92,16,59,200,210,59,120,179,198,237,178,79,252,161,80,218,62,60,188,18,49,173,114,66,188,95,212,33,205,59,52,183,194,232,16,156,199,118,85,97,188,186,174,103,93,74,81,161,116,79,114,118,210,142,67,167,12,83,20,168,189,83,84,73,186,179,49,136,170,129,11,214,111,168,191,69,126,222,119,39,104,78,194,46,98,255,103,246,4,253,209,68,167,91,18,7,196,126,96,189,217,87,152,219,79,109,74,254,9,204,224,173,91,231,134,150,120,23,143,194,134,115,204,223,249,104,66,174,230,132,27,198,154,54,81,221,99,141,250,68,222,22,93,7,69,200,120,232,9,86,99,237,172,30,251,5,97,145,72,116,197,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49896338-f1b3-42b4-a897-a58e4a82829a"));
		}

		#endregion

	}

	#endregion

}

