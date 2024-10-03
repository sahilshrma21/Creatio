namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermParametersSchema

	/// <exclude/>
	public class TermParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermParametersSchema(TermParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cce52b8e-5cff-471e-bee8-6f28959e4246");
			Name = "TermParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,77,75,3,49,16,134,207,45,244,63,140,23,81,144,93,60,219,22,164,136,136,8,98,213,123,204,78,107,32,155,44,51,137,176,136,255,221,108,246,163,187,213,250,237,97,33,201,188,51,121,159,97,54,158,149,89,195,178,100,135,249,201,100,236,123,219,100,97,181,70,233,148,53,156,156,163,65,82,50,72,38,99,35,114,228,66,72,132,91,36,18,108,87,46,104,205,74,173,61,137,74,158,44,145,158,148,196,16,206,39,227,231,201,120,148,166,41,76,217,231,185,160,114,222,236,171,40,20,130,66,53,135,196,73,43,75,123,186,194,63,104,37,65,106,193,28,19,174,59,125,136,86,149,71,5,169,39,225,16,216,133,187,37,16,138,204,26,93,130,50,14,174,148,185,85,57,222,25,229,238,133,246,8,51,56,142,8,163,55,142,226,193,66,104,52,153,32,80,25,26,167,86,10,41,233,196,125,95,173,177,115,175,178,46,235,34,131,232,104,180,70,119,18,23,220,44,94,118,222,184,225,129,149,165,224,158,139,208,110,132,172,66,146,66,75,175,235,150,126,104,227,18,203,200,119,45,20,77,91,59,156,180,236,71,85,51,230,112,211,20,143,119,242,175,189,178,213,190,178,246,47,94,151,77,241,79,189,238,116,123,131,206,147,97,112,143,194,109,188,110,230,13,4,5,215,150,40,140,248,14,199,241,132,234,58,243,211,32,31,150,225,46,125,154,182,170,30,232,131,181,26,46,120,81,107,134,64,7,135,13,82,157,183,133,155,212,195,58,159,189,25,224,239,81,119,211,244,59,234,94,246,55,128,135,211,182,13,60,140,254,21,176,27,62,41,63,129,221,46,241,69,226,32,121,31,116,119,63,246,247,63,152,142,16,236,61,43,123,179,248,210,36,103,121,225,202,238,47,13,95,236,204,43,118,231,229,6,196,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cce52b8e-5cff-471e-bee8-6f28959e4246"));
		}

		#endregion

	}

	#endregion

}

