namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormProcessHandlerSchema(IGeneratedWebFormProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c");
			Name = "IGeneratedWebFormProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,189,10,131,64,16,132,107,5,223,97,193,94,251,16,210,4,242,211,165,8,164,62,117,206,28,120,123,178,119,6,36,228,221,115,106,4,187,148,179,124,51,179,195,202,194,247,170,6,221,33,162,188,211,161,56,58,214,166,29,68,5,227,56,75,223,89,154,228,130,54,10,186,114,128,232,136,239,232,122,6,35,50,104,30,168,78,78,236,77,92,13,239,47,138,155,14,146,165,209,86,150,37,237,253,96,173,146,241,240,211,17,123,153,6,158,204,154,69,218,9,245,139,219,112,75,78,83,120,130,106,193,148,78,224,96,194,72,90,156,165,46,134,79,72,175,90,20,107,65,185,105,232,135,170,51,245,38,251,239,155,201,180,239,51,191,155,131,155,101,232,36,231,219,23,85,204,236,27,32,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd2443d1-4e8b-456e-8121-999e79c2ef1c"));
		}

		#endregion

	}

	#endregion

}

