namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoSamlProviderQueryExecutorSchema

	/// <exclude/>
	public class SsoSamlProviderQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoSamlProviderQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoSamlProviderQueryExecutorSchema(SsoSamlProviderQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d060c889-2aac-495e-a695-19e1de3d1510");
			Name = "SsoSamlProviderQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5aa7639-5b66-4d72-9308-0563d89b2353");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,203,78,195,48,16,60,167,82,255,97,21,46,137,84,229,3,130,184,244,129,212,11,20,21,184,32,14,174,179,137,44,185,118,180,182,17,81,196,191,179,113,168,170,0,237,109,119,60,59,59,179,54,226,136,174,21,18,225,25,137,132,179,181,47,86,214,212,170,9,36,188,178,166,216,59,187,71,239,149,105,220,124,214,207,103,73,112,92,79,232,132,183,23,240,98,99,188,242,10,221,69,194,189,144,222,210,200,96,206,13,97,195,91,97,165,133,115,37,240,242,199,22,205,182,218,145,253,80,21,210,83,64,234,54,159,40,3,79,197,137,183,53,214,34,104,191,84,166,98,253,204,119,45,218,58,219,198,205,221,132,159,47,224,129,243,194,29,164,67,42,113,212,255,202,166,249,59,235,42,227,145,140,208,32,7,43,112,109,0,74,88,10,135,76,121,85,228,131,208,167,131,253,114,155,244,209,241,57,164,53,206,83,24,14,192,89,119,225,160,149,28,25,109,172,175,46,205,94,28,18,43,24,148,195,63,65,152,180,249,160,146,148,112,96,95,217,244,105,241,39,125,122,134,78,206,211,28,250,175,31,183,104,170,209,112,236,71,116,10,70,236,27,15,97,122,132,75,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d060c889-2aac-495e-a695-19e1de3d1510"));
		}

		#endregion

	}

	#endregion

}

