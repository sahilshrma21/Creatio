namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFieldMapperSchema

	/// <exclude/>
	public class IFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFieldMapperSchema(IFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dfbf4d8-9185-4168-9736-2f2d7062756a");
			Name = "IFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,75,75,195,64,16,62,55,144,255,48,212,139,5,73,238,26,115,41,42,5,5,193,130,231,77,50,73,23,247,17,118,54,149,82,252,239,206,238,86,72,109,111,187,223,204,247,152,25,35,52,210,40,90,132,45,58,39,200,246,190,88,91,211,203,97,114,194,75,107,242,236,152,103,139,137,164,25,224,227,64,30,53,215,149,194,54,20,169,120,65,131,78,182,15,121,198,93,55,14,7,70,97,173,4,209,61,108,158,37,170,238,77,140,35,186,88,47,203,18,42,154,180,22,238,80,159,254,239,206,238,101,135,4,202,14,178,5,219,131,102,66,112,227,231,55,54,59,107,191,160,15,66,84,252,73,148,51,141,113,106,20,243,164,241,232,250,48,199,185,235,226,24,157,47,172,35,192,77,4,126,135,51,253,75,131,132,140,194,9,13,134,183,245,184,60,165,138,62,180,172,183,44,240,47,104,85,198,254,235,244,48,31,118,115,118,66,174,145,247,86,118,33,102,234,190,221,60,153,73,163,19,141,194,138,188,227,45,213,112,150,230,14,94,37,249,234,51,97,124,168,73,27,166,215,48,55,93,165,107,253,164,155,161,233,210,217,194,55,98,191,103,250,193,48,20,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dfbf4d8-9185-4168-9736-2f2d7062756a"));
		}

		#endregion

	}

	#endregion

}

