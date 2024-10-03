namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LangSupMailBoxBinderSchema

	/// <exclude/>
	public class LangSupMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LangSupMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LangSupMailBoxBinderSchema(LangSupMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99");
			Name = "LangSupMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,209,106,194,64,16,124,142,224,63,44,233,139,133,146,188,171,13,84,105,161,160,84,176,208,231,243,178,73,15,204,93,216,187,4,69,250,239,221,220,37,173,66,124,58,118,102,110,118,103,180,168,208,214,66,34,124,34,145,176,166,112,201,218,232,66,149,13,9,167,140,158,78,46,211,73,212,88,165,203,27,9,97,242,38,164,51,164,208,46,70,20,95,120,96,85,85,25,205,44,243,15,132,37,219,193,250,40,172,157,195,70,232,114,223,212,91,161,142,43,115,90,41,157,35,121,93,154,166,176,180,77,85,9,58,103,253,28,104,40,12,49,133,8,146,176,120,142,223,255,255,119,110,59,50,173,98,89,156,102,201,224,147,94,25,213,205,225,168,36,200,110,255,232,122,152,195,75,93,191,182,168,221,70,89,135,26,105,37,44,242,215,139,191,236,47,194,22,221,183,201,57,196,206,91,6,178,183,55,45,55,192,103,64,107,84,14,31,154,29,247,78,144,155,13,214,92,174,195,147,3,25,222,71,232,234,141,162,3,111,74,174,228,3,189,240,172,47,45,212,125,246,64,148,116,55,47,239,84,240,4,227,120,54,139,111,137,56,248,255,244,249,80,231,33,162,159,3,122,11,50,246,11,50,216,22,18,50,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99"));
		}

		#endregion

	}

	#endregion

}

