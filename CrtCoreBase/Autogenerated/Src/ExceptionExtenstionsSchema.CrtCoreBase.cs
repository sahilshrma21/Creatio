namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExceptionExtenstionsSchema

	/// <exclude/>
	public class ExceptionExtenstionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExceptionExtenstionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExceptionExtenstionsSchema(ExceptionExtenstionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("faf2dccd-bc35-40d3-96eb-76d934e9f741");
			Name = "ExceptionExtenstions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("98782977-14c0-4cb2-aa85-be92ba3c008e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,203,78,195,48,16,69,215,169,212,127,24,42,22,137,64,145,216,2,173,84,65,84,21,1,155,242,3,174,51,109,71,114,38,193,227,244,161,42,255,142,243,232,19,36,118,246,204,153,59,215,215,172,50,148,66,105,132,47,180,86,73,190,112,241,75,206,11,90,150,86,57,202,185,223,219,247,123,65,41,196,75,152,237,196,97,246,116,117,247,188,49,168,107,88,226,9,50,90,210,191,152,119,226,111,95,244,229,162,156,27,210,32,206,203,107,208,70,137,64,178,213,88,212,2,201,214,33,75,173,228,201,122,113,80,88,90,43,135,7,126,154,112,153,161,85,115,131,207,199,169,17,188,162,104,228,84,177,147,49,167,51,52,139,208,173,232,76,24,240,112,138,160,209,13,210,188,59,4,59,66,147,130,69,87,218,51,238,169,109,30,239,48,60,245,226,41,251,103,38,151,104,5,155,21,25,132,240,38,60,13,121,15,92,26,19,69,13,83,53,9,92,69,32,206,214,65,77,208,141,141,249,64,17,181,68,249,215,254,90,217,83,81,46,204,253,17,70,187,190,25,202,186,13,231,35,18,123,202,127,97,24,226,61,80,4,195,17,220,14,246,4,119,240,80,61,194,30,227,206,86,53,232,132,186,176,90,235,241,91,78,28,38,188,38,155,115,134,236,226,79,220,248,15,247,90,135,101,199,231,183,17,84,208,239,253,0,195,150,40,53,122,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("faf2dccd-bc35-40d3-96eb-76d934e9f741"));
		}

		#endregion

	}

	#endregion

}

