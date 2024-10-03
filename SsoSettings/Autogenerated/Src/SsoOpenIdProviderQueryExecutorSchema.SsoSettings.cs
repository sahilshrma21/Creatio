namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoOpenIdProviderQueryExecutorSchema

	/// <exclude/>
	public class SsoOpenIdProviderQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoOpenIdProviderQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoOpenIdProviderQueryExecutorSchema(SsoOpenIdProviderQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c5a8959-a182-473a-b083-85bc786758d3");
			Name = "SsoOpenIdProviderQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e5aa7639-5b66-4d72-9308-0563d89b2353");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,81,193,78,195,48,12,61,111,210,254,193,42,151,86,154,250,1,69,92,54,134,180,11,12,13,184,32,14,89,234,86,145,138,83,57,14,162,170,248,119,210,148,9,138,24,187,217,47,207,239,61,59,164,94,209,181,74,35,60,32,179,114,182,146,124,109,169,50,181,103,37,198,82,190,119,118,143,34,134,106,183,152,247,139,249,204,187,80,79,232,140,151,39,240,124,67,98,196,160,59,73,184,81,90,44,143,140,192,185,96,172,131,43,172,27,229,92,1,193,252,174,69,218,150,59,182,111,166,68,190,247,200,221,230,29,181,15,83,113,226,249,26,43,229,27,89,25,42,131,126,42,93,139,182,74,183,209,185,155,240,179,37,220,134,125,225,10,146,255,133,147,236,37,40,27,18,100,82,13,232,33,204,153,44,80,192,74,57,12,164,39,195,226,85,115,60,218,175,196,179,62,166,254,94,212,146,19,246,195,17,194,190,59,127,104,140,30,25,109,172,207,216,166,143,14,57,104,16,234,225,183,192,79,218,108,208,153,21,112,8,201,210,233,211,242,143,27,36,63,193,99,254,36,131,254,227,43,51,82,57,198,142,253,136,78,193,136,125,2,30,47,153,0,85,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c5a8959-a182-473a-b083-85bc786758d3"));
		}

		#endregion

	}

	#endregion

}

