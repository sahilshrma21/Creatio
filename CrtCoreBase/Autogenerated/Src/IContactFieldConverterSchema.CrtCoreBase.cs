namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactFieldConverterSchema

	/// <exclude/>
	public class IContactFieldConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactFieldConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactFieldConverterSchema(IContactFieldConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e41c16cf-8b54-48e0-a08f-2fb93df528b9");
			Name = "IContactFieldConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,106,195,48,16,60,59,144,127,88,220,75,115,177,238,121,248,82,72,201,161,37,144,222,74,15,170,178,118,4,182,108,36,185,16,66,255,189,43,69,126,36,141,73,64,135,149,52,179,51,59,172,226,37,154,154,11,132,15,212,154,155,42,179,201,75,165,50,153,55,154,91,89,41,56,77,39,17,157,39,141,185,187,110,148,69,157,17,97,14,27,2,90,46,236,90,98,177,167,250,7,53,253,77,39,132,102,140,193,210,52,101,201,245,49,13,247,128,134,120,221,20,5,40,18,142,33,115,84,16,45,55,105,169,108,192,173,155,239,66,10,144,173,240,168,110,116,242,218,157,213,173,174,106,250,146,104,230,176,245,77,206,255,215,230,70,221,25,172,57,165,80,105,16,7,42,4,169,24,224,20,211,49,233,250,12,157,70,14,246,249,5,187,142,231,194,139,162,28,237,194,23,38,20,191,193,40,170,253,217,235,165,241,55,180,135,106,255,136,235,53,105,92,56,182,90,170,28,52,218,70,43,67,120,68,16,26,179,85,28,230,219,229,101,204,82,10,211,88,174,4,142,204,225,95,220,12,165,239,187,138,125,247,244,191,82,178,100,30,214,179,130,116,122,95,122,201,90,172,35,247,32,120,69,219,223,158,195,72,78,117,182,184,19,197,93,209,46,153,27,163,60,24,133,161,142,15,77,55,18,204,205,16,135,73,132,129,251,20,222,9,251,60,200,135,28,204,252,26,93,239,80,216,171,203,181,162,183,63,213,15,35,115,229,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e41c16cf-8b54-48e0-a08f-2fb93df528b9"));
		}

		#endregion

	}

	#endregion

}

