namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationResultSchema

	/// <exclude/>
	public class ValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationResultSchema(ValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9260c4da-ff8c-4735-8588-92371799a4b2");
			Name = "ValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fde60690-6c92-48a2-8124-1d9224eb59b6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,65,11,194,48,12,133,207,14,246,31,2,222,253,1,238,40,232,73,16,39,122,238,186,103,41,116,237,72,90,65,134,255,221,174,19,65,240,18,146,151,239,189,196,171,1,50,42,13,186,128,89,73,184,199,205,46,248,187,53,137,85,180,193,111,14,240,200,45,250,27,186,125,224,161,5,63,172,70,93,77,117,181,74,98,189,161,246,41,17,67,83,87,89,89,51,76,182,209,206,41,145,45,93,149,179,125,9,58,67,146,139,133,25,83,231,172,38,61,35,127,136,213,84,168,111,212,137,195,8,142,22,57,239,84,172,203,254,19,211,133,224,168,77,90,67,104,34,131,216,144,204,229,245,67,73,228,249,213,35,68,148,193,63,112,13,223,47,23,203,188,168,191,98,214,222,79,137,188,163,49,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9260c4da-ff8c-4735-8588-92371799a4b2"));
		}

		#endregion

	}

	#endregion

}

