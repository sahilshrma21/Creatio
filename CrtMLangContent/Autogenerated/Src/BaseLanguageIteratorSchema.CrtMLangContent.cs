namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseLanguageIteratorSchema

	/// <exclude/>
	public class BaseLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseLanguageIteratorSchema(BaseLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88e0be6b-543f-42a7-9c74-8a6542583cb1");
			Name = "BaseLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,143,155,48,16,61,103,165,253,15,35,246,146,94,224,190,77,34,181,81,21,33,237,74,171,126,156,170,30,28,51,176,150,192,160,177,221,138,86,253,239,29,59,64,13,201,70,185,225,225,249,205,155,55,15,180,104,208,116,66,34,124,69,34,97,218,210,166,251,86,151,170,114,36,172,106,245,253,221,159,251,187,149,51,74,87,240,165,55,22,155,247,139,51,227,235,26,165,7,155,244,128,26,73,201,255,152,152,150,144,235,252,230,129,176,98,52,236,107,97,204,35,124,20,6,159,132,174,156,168,48,183,200,125,91,10,184,44,203,96,99,92,211,8,234,119,195,217,131,185,136,8,146,176,220,38,249,242,102,146,237,64,53,93,141,13,106,27,70,72,71,170,44,226,234,220,177,86,18,196,209,88,18,210,130,244,90,46,74,129,71,56,107,194,4,222,150,105,146,23,106,59,36,171,144,199,121,9,204,97,128,179,9,66,225,155,65,2,217,106,125,50,45,157,128,177,190,81,160,7,239,39,236,242,24,68,172,42,180,222,240,213,223,43,77,63,240,26,122,104,75,168,135,81,128,92,141,230,122,243,105,238,207,140,253,254,3,226,163,137,154,131,153,43,120,64,93,156,156,25,206,227,194,57,34,150,156,100,7,189,81,212,90,158,3,139,43,178,115,173,172,18,181,250,205,253,52,254,2,197,4,66,115,92,121,146,40,5,151,246,198,65,120,99,186,80,233,4,137,6,52,231,127,155,184,153,171,201,110,185,161,77,22,208,39,107,70,213,23,195,178,94,44,104,206,252,110,240,108,1,218,46,96,183,88,249,140,246,181,45,110,137,219,1,173,153,182,110,224,216,3,127,24,202,246,160,10,255,80,42,164,91,125,34,148,45,21,121,145,236,62,157,81,196,30,133,139,132,214,145,54,12,117,205,240,37,69,241,51,124,97,68,196,137,27,208,199,26,55,7,167,138,157,151,63,154,108,214,190,4,163,138,209,205,146,127,44,66,190,194,250,167,160,144,106,78,201,60,170,35,114,213,43,172,61,129,239,27,160,105,68,159,23,235,137,58,172,192,239,224,173,69,156,170,243,34,215,254,1,86,135,20,148,80,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88e0be6b-543f-42a7-9c74-8a6542583cb1"));
		}

		#endregion

	}

	#endregion

}

