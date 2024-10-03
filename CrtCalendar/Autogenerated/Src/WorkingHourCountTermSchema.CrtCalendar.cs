namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkingHourCountTermSchema

	/// <exclude/>
	public class WorkingHourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkingHourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkingHourCountTermSchema(WorkingHourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02");
			Name = "WorkingHourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,77,79,219,64,16,61,27,137,255,48,74,47,77,133,236,158,122,40,193,82,21,16,228,128,84,169,169,56,111,236,73,178,194,187,27,237,7,200,66,252,119,102,118,109,19,66,18,196,161,82,111,222,217,247,118,222,204,155,177,22,10,221,70,84,8,115,180,86,56,179,244,249,212,232,165,92,5,43,188,52,58,159,138,6,117,45,172,59,61,121,58,61,201,130,147,122,5,127,90,231,81,157,239,156,137,217,52,88,49,205,229,215,168,209,202,138,48,132,250,98,113,69,81,152,54,194,57,248,9,119,198,222,19,239,198,4,59,53,65,123,74,174,34,176,40,10,152,184,160,148,176,109,217,157,35,2,60,65,96,209,194,99,162,194,154,184,46,239,41,197,22,103,19,22,141,172,160,138,185,246,101,122,21,112,43,117,240,184,37,33,123,138,50,6,193,183,232,215,166,102,201,191,173,241,84,27,214,9,176,43,52,6,174,209,59,240,107,4,47,21,66,208,210,71,133,239,37,166,200,70,88,161,64,147,5,23,163,90,180,110,84,246,205,6,62,230,147,34,34,246,19,8,55,42,231,148,139,62,222,35,45,250,96,181,43,231,131,16,168,184,74,66,246,87,140,221,244,69,129,121,32,255,101,141,32,169,215,84,7,19,255,50,239,235,236,74,7,133,86,44,26,156,204,122,129,151,162,45,163,200,51,184,20,30,99,26,186,24,3,207,72,150,165,28,176,16,14,243,55,143,37,74,68,146,177,221,99,52,112,142,58,149,204,112,51,205,102,241,108,101,207,157,25,132,74,126,28,52,39,90,126,196,25,74,85,133,134,148,146,232,78,46,205,82,213,9,248,103,38,197,33,29,149,92,16,13,134,225,132,73,198,97,199,134,215,121,134,118,237,74,147,61,120,53,180,126,40,239,67,183,216,222,168,106,159,85,175,207,36,112,4,194,183,163,70,141,183,157,58,180,21,67,167,225,17,241,222,129,80,105,167,13,172,248,55,193,13,249,143,44,248,149,212,153,101,82,251,129,9,221,194,220,49,52,254,73,62,239,1,7,84,106,42,92,12,93,255,241,253,124,223,50,109,37,74,207,117,204,241,145,149,73,209,183,65,138,189,0,89,227,56,106,254,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02"));
		}

		#endregion

	}

	#endregion

}

