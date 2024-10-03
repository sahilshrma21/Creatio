namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContentKitSchema

	/// <exclude/>
	public class IContentKitSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContentKitSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContentKitSchema(IContentKitSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("37dac048-4167-4f6c-9dc9-b9ea768da408");
			Name = "IContentKit";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,65,110,194,48,16,60,7,169,127,88,193,165,149,170,228,14,148,75,133,80,212,162,34,232,7,220,100,147,90,77,156,104,189,62,32,212,191,215,78,236,136,180,128,122,243,78,102,103,198,19,43,81,163,110,69,134,240,142,68,66,55,5,199,207,141,42,100,105,72,176,108,212,221,228,116,55,137,140,150,170,132,195,81,51,214,139,97,62,95,33,140,215,138,37,75,212,150,96,41,51,194,210,238,67,170,24,169,176,14,115,72,173,50,163,226,23,201,29,37,73,18,88,106,83,215,130,142,43,63,239,177,37,212,150,164,225,75,50,20,13,65,109,42,150,149,80,165,17,37,66,214,107,196,97,63,57,19,104,205,71,37,51,144,193,114,236,24,157,58,215,33,217,142,154,22,201,37,158,195,174,219,236,191,255,142,213,1,175,193,95,90,109,193,13,197,3,245,60,65,148,6,98,234,121,240,7,112,133,70,81,137,188,232,14,218,31,190,111,184,251,107,128,102,87,244,21,103,79,58,56,14,140,134,219,142,51,84,121,95,201,184,159,45,242,103,147,255,167,156,61,178,33,165,195,191,1,116,47,225,120,37,103,135,180,130,68,13,202,190,190,167,105,207,78,243,233,234,141,100,41,149,168,188,192,160,39,115,7,20,18,41,94,38,221,234,101,37,194,172,161,220,41,173,123,129,30,184,185,79,125,246,213,246,210,43,11,55,89,38,129,230,246,188,248,6,217,183,124,191,49,50,135,112,143,71,232,198,16,230,97,113,177,230,190,252,49,104,177,31,103,220,162,178,145,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37dac048-4167-4f6c-9dc9-b9ea768da408"));
		}

		#endregion

	}

	#endregion

}

