namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetAllEmployeesIsActiveTrueSchema

	/// <exclude/>
	public class SetAllEmployeesIsActiveTrueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetAllEmployeesIsActiveTrueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetAllEmployeesIsActiveTrueSchema(SetAllEmployeesIsActiveTrueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd69648b-4854-fa46-2daa-e5c81be0a625");
			Name = "SetAllEmployeesIsActiveTrue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1296b383-c2ef-47b8-ae67-0601cddb70e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,93,75,195,48,20,125,118,176,255,112,233,83,3,235,199,212,138,115,42,116,91,149,190,9,219,240,57,182,119,51,144,38,53,31,115,67,252,239,102,173,101,29,130,231,33,228,126,156,155,156,115,65,208,10,117,77,11,132,21,42,69,181,220,152,112,46,197,134,109,173,162,134,73,1,95,195,1,56,88,205,196,22,150,7,109,176,154,246,83,125,158,194,127,74,225,98,230,170,109,61,138,34,184,215,182,170,168,58,60,158,82,79,108,15,41,231,144,85,53,151,7,68,80,146,99,216,163,68,231,156,218,190,113,86,64,193,169,214,176,68,227,184,29,85,231,58,45,12,219,225,74,89,132,59,200,115,161,13,229,124,89,40,86,155,108,143,133,53,82,117,234,142,56,221,126,199,238,36,43,161,237,68,127,173,81,57,99,4,22,141,43,246,44,36,253,57,14,23,59,170,192,214,37,53,8,15,32,240,19,214,77,224,159,211,70,224,57,67,211,178,98,98,45,152,241,200,112,112,225,16,58,37,190,215,254,222,27,193,92,114,91,137,240,133,42,183,43,131,202,55,78,17,233,122,95,223,81,161,239,229,165,71,194,92,103,31,150,114,255,15,227,217,178,242,24,106,215,153,94,78,210,171,89,154,4,215,179,120,17,44,178,241,56,152,164,201,56,136,227,36,78,110,230,177,195,173,71,8,153,54,15,180,34,194,206,5,50,61,233,252,238,150,217,92,220,241,3,237,62,164,248,77,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd69648b-4854-fa46-2daa-e5c81be0a625"));
		}

		#endregion

	}

	#endregion

}

