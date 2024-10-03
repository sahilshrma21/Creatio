namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDefaultValueManagerSchema

	/// <exclude/>
	public class IDefaultValueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDefaultValueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDefaultValueManagerSchema(IDefaultValueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("823db1cb-37ea-4cab-bf5f-dc43956066ce");
			Name = "IDefaultValueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,77,107,195,48,12,134,207,11,228,63,136,158,54,40,201,15,88,215,203,202,74,15,187,172,251,56,43,137,28,60,18,57,200,118,71,25,251,239,147,155,174,31,107,193,96,75,178,30,189,126,205,216,147,31,176,38,120,37,17,244,206,132,226,209,177,177,109,20,12,214,113,177,36,38,61,82,243,65,213,147,147,126,77,178,177,53,229,217,119,158,221,68,111,185,133,245,214,7,234,239,255,197,202,233,58,170,19,196,143,20,91,31,239,156,142,19,74,121,93,101,89,194,204,199,190,71,217,206,247,241,11,133,40,236,161,33,131,177,11,176,193,46,146,7,227,4,90,187,33,134,14,185,73,68,221,128,56,216,176,45,254,80,229,9,107,136,85,103,107,176,28,72,76,122,240,106,49,18,223,19,240,25,25,91,18,189,151,158,117,33,100,151,88,83,184,166,226,56,243,114,232,152,25,80,176,7,86,171,31,38,209,147,168,193,60,26,51,153,175,216,7,100,149,227,12,164,26,212,135,98,49,43,119,157,215,65,95,227,119,172,26,101,52,73,131,177,218,173,148,189,31,103,221,11,187,35,170,170,153,15,162,213,41,184,234,83,199,204,97,73,163,3,254,118,25,109,3,7,236,20,222,206,164,194,185,242,187,244,101,63,121,166,43,207,126,1,66,192,70,241,70,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("823db1cb-37ea-4cab-bf5f-dc43956066ce"));
		}

		#endregion

	}

	#endregion

}

