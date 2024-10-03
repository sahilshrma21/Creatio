namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailCredentialsSchema

	/// <exclude/>
	public class MailCredentialsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailCredentialsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailCredentialsSchema(MailCredentialsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fb91463-07a1-4af3-bf11-902a4739cfa3");
			Name = "MailCredentials";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,65,10,194,48,16,69,215,22,122,135,1,247,30,64,87,69,4,93,8,133,214,3,196,102,172,129,52,83,102,166,11,17,239,110,210,138,168,160,110,2,243,231,229,255,225,7,211,161,244,166,65,168,145,217,8,157,116,177,55,206,67,158,93,243,44,207,102,115,198,214,81,128,181,55,34,75,72,187,53,163,197,160,206,120,25,145,126,56,122,215,64,147,136,79,0,150,240,58,69,122,178,125,250,150,76,61,178,58,140,230,229,104,52,237,31,166,162,236,66,11,91,18,133,43,180,168,43,144,244,220,94,24,23,20,74,226,239,192,145,200,195,65,176,18,255,151,217,89,143,63,147,106,215,33,13,223,195,30,23,87,24,44,242,166,139,117,20,214,50,198,106,126,70,87,106,88,107,255,135,218,73,17,40,92,58,26,164,24,244,156,106,109,140,166,30,63,190,141,21,199,19,166,150,199,121,82,223,197,168,221,1,190,180,195,20,2,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fb91463-07a1-4af3-bf11-902a4739cfa3"));
		}

		#endregion

	}

	#endregion

}

