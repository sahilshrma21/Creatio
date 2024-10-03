namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICategoryProviderWrapperSchema

	/// <exclude/>
	public class ICategoryProviderWrapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICategoryProviderWrapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICategoryProviderWrapperSchema(ICategoryProviderWrapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f178ef2e-9d2a-41d3-899c-ea2ef4382810");
			Name = "ICategoryProviderWrapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,145,219,74,196,64,12,134,175,183,208,119,8,123,165,32,237,3,88,247,194,130,139,23,130,184,130,215,179,109,90,34,157,3,153,25,217,34,190,187,233,246,180,174,48,12,153,144,239,255,147,140,81,26,189,83,21,194,59,50,43,111,155,144,149,214,52,212,70,86,129,172,73,147,239,52,217,68,79,166,133,67,239,3,234,251,52,145,76,158,231,80,248,168,181,226,126,55,189,95,217,126,81,141,80,41,63,92,1,91,203,61,52,108,53,104,69,29,28,237,41,155,209,252,130,117,241,216,81,5,100,2,114,51,244,242,92,78,240,164,200,31,172,156,67,150,218,161,155,127,230,231,196,30,195,106,202,216,73,88,143,230,62,58,103,57,44,77,128,235,196,165,6,107,164,174,34,71,104,130,207,22,225,252,90,185,112,138,149,6,35,187,122,216,174,196,118,247,182,196,119,240,105,201,136,38,25,240,129,101,91,89,145,159,177,85,133,49,68,54,126,87,254,217,204,117,115,194,205,133,3,185,143,84,15,163,205,208,147,48,135,17,121,17,226,209,158,110,70,191,139,81,110,229,139,54,63,105,34,231,23,73,177,18,69,224,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f178ef2e-9d2a-41d3-899c-ea2ef4382810"));
		}

		#endregion

	}

	#endregion

}

