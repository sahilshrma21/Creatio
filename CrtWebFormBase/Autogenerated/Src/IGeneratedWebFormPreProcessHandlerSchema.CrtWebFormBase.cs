namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormPreProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormPreProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormPreProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormPreProcessHandlerSchema(IGeneratedWebFormPreProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3ffd2b0a-1f40-4b13-b22b-9f7c569366fc");
			Name = "IGeneratedWebFormPreProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,79,194,64,16,61,67,194,127,152,192,69,19,210,222,21,185,168,96,15,36,36,98,60,47,237,180,108,66,119,55,179,91,212,24,255,187,179,253,162,165,68,15,77,58,175,243,102,230,189,153,42,145,163,53,34,70,216,33,145,176,58,117,193,163,86,169,204,10,18,78,106,53,25,127,79,198,163,194,74,149,245,82,8,239,175,226,29,106,176,70,133,252,138,201,59,238,87,154,242,87,164,147,140,61,145,169,51,194,140,147,32,82,14,41,229,9,238,32,186,36,108,9,183,164,99,180,246,69,168,228,136,84,50,195,48,132,133,45,242,92,208,215,178,142,57,237,36,19,180,32,155,114,144,106,2,67,200,79,89,193,15,170,83,112,7,228,28,83,56,48,130,68,110,33,37,157,195,145,203,251,4,35,50,12,154,22,97,167,135,41,246,71,25,119,170,255,63,43,92,21,212,87,51,242,230,182,86,108,208,29,116,98,75,145,3,149,37,240,252,137,113,225,88,166,151,225,159,11,129,94,179,53,24,203,84,98,50,80,53,148,85,33,165,19,160,248,20,30,166,133,69,226,45,42,140,253,10,167,203,29,55,241,24,196,45,24,44,194,146,113,189,0,143,144,63,9,39,42,170,143,32,225,240,111,210,71,101,207,70,24,164,138,88,126,69,118,219,66,86,153,168,105,88,131,208,21,164,108,11,212,254,178,246,115,227,179,240,110,246,170,30,179,177,244,230,173,39,28,250,62,204,161,205,111,244,205,193,151,25,69,245,102,163,220,104,114,219,242,166,214,205,192,245,141,181,241,109,117,250,163,25,170,164,218,57,71,63,213,239,208,129,38,99,198,126,1,162,140,85,20,154,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ffd2b0a-1f40-4b13-b22b-9f7c569366fc"));
		}

		#endregion

	}

	#endregion

}

