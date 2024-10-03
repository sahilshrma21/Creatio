namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITemplateLoaderSchema

	/// <exclude/>
	public class ITemplateLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITemplateLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITemplateLoaderSchema(ITemplateLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0678da09-bb18-43d7-b171-709841aeb44c");
			Name = "ITemplateLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9fb8de7b-ba51-4bde-a802-902958879110");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,83,193,106,195,48,12,61,167,208,127,16,61,117,48,146,15,104,151,75,41,165,208,219,186,15,80,19,37,24,98,37,216,242,33,140,253,251,108,111,110,211,110,221,177,131,92,36,191,247,244,244,68,24,53,217,1,43,130,35,25,131,182,111,36,223,244,220,168,214,25,20,213,243,124,246,62,159,101,206,42,110,225,117,180,66,122,117,174,55,189,161,235,42,223,178,40,81,100,125,219,63,12,238,212,169,10,20,11,153,38,12,217,31,73,15,29,10,29,122,172,201,120,72,80,207,138,162,128,181,117,90,163,25,203,212,120,179,100,160,234,153,169,10,70,242,51,176,152,34,3,106,115,6,193,77,25,213,179,150,36,216,204,62,162,169,223,167,237,72,44,32,3,105,84,29,200,183,77,16,131,108,187,152,4,156,70,80,30,164,106,242,75,54,202,187,91,174,7,52,168,13,53,192,62,200,151,69,100,167,29,247,245,162,40,159,210,0,228,26,106,106,208,117,2,29,114,235,176,165,59,59,197,78,84,190,35,91,110,175,93,94,44,229,235,34,18,47,58,134,196,25,182,183,148,233,98,129,44,163,167,38,108,32,199,75,142,33,151,52,120,185,115,170,134,27,47,79,171,255,14,53,133,249,167,70,2,125,209,31,145,251,84,103,50,189,60,252,180,251,240,163,61,67,236,94,108,133,43,134,223,195,127,159,6,136,187,162,18,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0678da09-bb18-43d7-b171-709841aeb44c"));
		}

		#endregion

	}

	#endregion

}

