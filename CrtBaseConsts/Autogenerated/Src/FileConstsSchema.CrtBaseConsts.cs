namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileConstsSchema

	/// <exclude/>
	public class FileConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileConstsSchema(FileConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1");
			Name = "FileConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,95,107,219,48,20,197,159,27,200,119,184,164,47,235,131,26,59,118,211,120,221,10,105,26,151,193,24,97,253,179,103,217,186,78,68,109,217,72,242,138,9,251,238,147,228,58,137,71,214,81,246,36,124,117,206,185,63,235,74,130,22,168,42,154,34,60,160,148,84,149,153,62,255,129,201,188,170,134,131,237,112,112,82,43,46,214,112,223,40,141,197,213,112,96,42,167,18,215,188,20,176,200,169,82,31,33,230,57,46,74,161,180,114,187,85,157,228,60,5,165,169,54,75,106,53,61,201,201,214,201,118,41,49,199,156,153,152,149,243,181,123,227,177,117,128,110,42,4,226,220,10,168,96,144,115,241,172,192,42,250,93,36,82,86,138,188,129,187,154,51,167,127,48,214,199,47,12,62,131,192,23,87,254,48,186,152,68,55,139,73,60,35,222,114,233,145,219,216,247,73,116,233,223,16,207,243,111,167,222,50,10,102,139,233,232,236,170,67,248,106,154,253,5,225,95,4,214,122,148,32,120,23,193,82,104,174,155,255,224,216,7,28,165,9,163,36,157,100,134,6,209,35,44,107,105,18,75,195,166,30,26,154,244,144,198,218,43,186,70,248,137,82,153,201,41,40,51,208,27,132,204,206,234,221,108,86,254,244,154,116,39,57,91,153,232,63,9,113,22,166,73,24,80,18,134,129,79,194,105,20,144,132,49,74,168,31,78,252,89,18,164,23,209,229,1,225,156,49,174,77,30,205,161,146,101,133,82,55,240,168,112,206,10,46,190,243,245,70,43,243,3,210,220,119,141,18,132,89,223,96,84,90,218,123,223,183,239,27,172,108,206,19,205,107,252,102,114,12,244,168,175,28,237,160,198,240,73,213,69,65,101,115,221,21,98,68,214,158,26,186,1,129,74,55,88,80,135,116,190,115,141,15,109,111,83,218,64,123,158,237,188,239,219,184,14,172,219,236,144,78,81,176,246,237,185,239,95,237,155,238,21,93,237,55,69,158,138,12,25,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1"));
		}

		#endregion

	}

	#endregion

}

