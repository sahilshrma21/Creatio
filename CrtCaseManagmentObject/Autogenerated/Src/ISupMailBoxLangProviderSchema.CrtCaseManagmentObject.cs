namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupMailBoxLangProviderSchema

	/// <exclude/>
	public class ISupMailBoxLangProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupMailBoxLangProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupMailBoxLangProviderSchema(ISupMailBoxLangProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15f7828f-b2b8-4927-9695-3e8e4374d7a6");
			Name = "ISupMailBoxLangProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,207,106,195,48,12,198,207,11,228,29,68,79,27,140,228,1,150,229,176,13,202,160,131,66,247,2,174,43,167,130,248,15,178,61,90,198,222,125,114,178,208,177,30,7,190,72,250,73,223,39,203,41,139,49,40,141,240,142,204,42,122,147,154,103,239,12,13,153,85,34,239,234,234,179,174,110,114,36,55,192,238,28,19,218,135,63,177,240,227,136,186,192,177,89,163,67,38,45,140,80,109,219,66,23,179,181,138,207,253,79,252,130,81,51,237,49,66,58,7,188,135,116,84,9,2,251,15,58,72,110,84,110,200,106,64,48,236,45,88,69,35,236,253,73,10,198,51,144,211,2,185,4,140,3,197,52,251,107,22,157,246,151,80,200,251,145,180,52,36,100,83,150,123,221,229,240,38,211,158,252,105,35,18,219,89,143,5,45,219,93,25,157,18,219,255,153,186,118,53,103,130,98,101,193,201,191,63,174,24,53,5,146,238,184,234,55,210,13,222,0,22,129,216,116,237,4,94,250,24,83,102,23,251,205,226,102,146,37,67,200,2,47,213,130,175,51,29,96,141,105,33,111,203,232,78,188,201,205,122,184,104,222,149,75,126,213,149,188,111,117,203,182,110,7,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15f7828f-b2b8-4927-9695-3e8e4374d7a6"));
		}

		#endregion

	}

	#endregion

}

