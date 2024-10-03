namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SSPConstsSchema

	/// <exclude/>
	public class SSPConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SSPConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SSPConstsSchema(SSPConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee");
			Name = "SSPConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,187,110,194,48,20,134,103,34,229,29,44,166,118,48,151,196,73,136,80,7,39,113,42,38,80,161,15,224,38,78,100,41,177,35,219,64,41,226,221,107,46,45,165,67,23,58,88,242,229,247,231,79,199,103,173,185,168,193,114,167,13,107,167,174,227,58,130,182,76,119,180,96,96,197,148,162,90,86,102,144,74,81,241,122,173,168,225,82,184,206,222,117,122,221,250,173,225,5,208,198,238,21,160,104,168,214,96,185,92,216,164,54,218,158,239,143,172,94,111,56,4,47,172,230,218,156,239,2,214,82,222,0,251,86,215,80,195,0,47,153,48,188,226,76,13,142,233,91,168,98,180,148,162,217,129,231,53,47,111,48,228,72,89,93,32,179,18,60,1,193,182,167,216,67,31,7,89,70,80,26,194,40,243,99,136,34,111,4,49,182,203,9,33,81,226,135,4,231,9,238,63,78,191,229,90,46,74,208,89,253,173,84,229,93,126,133,220,48,181,91,92,80,127,57,34,148,166,120,146,32,24,196,153,7,17,33,62,76,72,128,96,134,162,156,228,97,234,71,94,114,117,156,137,13,55,247,150,239,10,249,23,177,179,26,46,109,245,206,191,34,21,168,236,96,239,134,41,65,27,32,85,77,5,255,184,116,204,223,110,55,152,92,170,249,143,187,115,177,144,202,208,198,118,232,41,246,42,184,249,37,29,230,49,206,195,145,7,125,236,89,233,32,72,97,50,10,66,232,165,249,24,121,104,156,199,200,255,146,62,184,206,225,56,249,4,46,182,142,82,247,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee"));
		}

		#endregion

	}

	#endregion

}

