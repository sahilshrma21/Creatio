namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CacheUtilitiesSchema

	/// <exclude/>
	public class CacheUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CacheUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CacheUtilitiesSchema(CacheUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e686424e-171b-4e43-9ed2-8c621f1495a0");
			Name = "CacheUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,93,75,235,64,16,134,175,35,248,31,150,92,41,28,130,215,22,47,36,213,122,163,23,90,245,66,14,135,73,58,182,139,219,108,152,157,245,131,210,255,238,110,146,66,183,221,211,15,2,161,36,51,243,62,243,206,100,211,10,230,104,106,40,81,140,145,8,140,126,231,44,215,213,187,156,90,2,150,186,58,61,89,156,158,36,214,200,106,26,148,16,14,34,241,87,44,178,59,230,58,187,46,12,19,148,158,96,92,161,43,173,109,161,100,41,12,59,108,41,74,5,198,136,28,202,25,62,179,84,146,37,26,87,180,104,74,147,154,228,39,48,174,138,29,202,183,201,45,17,86,156,91,197,150,240,193,57,23,222,91,146,76,145,187,187,228,19,72,88,131,228,102,168,176,105,47,174,196,217,115,16,57,247,14,221,35,227,183,155,164,133,102,79,104,140,203,189,165,97,109,250,119,208,130,9,93,211,106,131,189,82,123,77,214,249,202,188,177,86,180,244,191,203,110,164,96,252,110,162,87,77,31,205,246,155,69,140,72,219,122,123,164,174,115,43,201,110,53,205,129,207,210,136,244,223,226,98,153,254,137,172,233,60,180,243,31,51,67,100,144,202,52,188,67,93,172,107,122,182,191,110,15,203,81,237,215,53,61,219,63,98,173,137,143,107,191,174,233,59,125,5,234,199,61,155,150,217,218,184,18,105,44,158,14,246,99,242,25,172,40,135,238,114,91,218,115,166,17,201,201,139,196,175,163,108,4,162,158,6,110,38,146,131,83,237,22,186,25,219,177,204,155,185,171,26,227,188,86,238,191,104,237,11,245,148,173,212,14,206,189,158,88,133,67,96,8,33,177,248,165,159,248,144,247,27,144,34,225,61,160,145,210,5,168,214,65,200,138,103,118,160,186,215,178,97,105,59,186,215,205,19,2,149,179,152,155,205,204,14,212,16,204,172,208,64,147,49,20,33,42,158,105,80,238,8,185,235,23,205,147,39,15,12,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e686424e-171b-4e43-9ed2-8c621f1495a0"));
		}

		#endregion

	}

	#endregion

}

