namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomFieldMapperSchema

	/// <exclude/>
	public class ICustomFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomFieldMapperSchema(ICustomFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dec5d6ef-4d67-4ef9-831c-8d603fb196b8");
			Name = "ICustomFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,65,107,195,48,12,133,207,9,228,63,8,118,79,238,235,216,37,108,99,135,141,66,7,59,187,137,156,154,198,86,176,228,142,80,250,223,103,187,93,201,40,108,224,139,236,167,247,61,89,78,89,228,73,117,8,31,232,189,98,210,82,183,228,180,25,130,87,98,200,85,229,177,42,139,192,198,13,176,153,89,208,174,98,29,207,157,199,33,190,67,59,42,230,123,120,109,3,11,217,103,131,99,255,166,166,9,125,85,70,85,211,52,240,192,193,90,229,231,199,75,189,246,116,48,61,50,140,52,152,14,72,131,141,13,9,208,101,15,248,194,237,142,104,15,58,153,113,253,99,211,44,124,166,176,29,99,175,113,130,94,167,248,183,124,136,161,126,197,41,210,36,55,137,242,197,11,10,131,236,240,138,102,10,190,195,250,218,176,100,23,44,62,165,253,60,107,55,89,10,71,24,80,86,112,202,99,255,67,65,39,70,102,112,241,243,255,70,60,101,225,123,212,45,252,139,211,101,3,232,250,243,18,18,51,131,191,1,140,118,194,110,207,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dec5d6ef-4d67-4ef9-831c-8d603fb196b8"));
		}

		#endregion

	}

	#endregion

}

