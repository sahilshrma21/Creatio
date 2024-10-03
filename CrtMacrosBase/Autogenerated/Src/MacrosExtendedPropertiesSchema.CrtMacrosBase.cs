namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosExtendedPropertiesSchema

	/// <exclude/>
	public class MacrosExtendedPropertiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosExtendedPropertiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosExtendedPropertiesSchema(MacrosExtendedPropertiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("002c9b1f-92d2-46e4-bb93-2ab334090c0f");
			Name = "MacrosExtendedProperties";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,77,107,195,48,12,61,167,208,255,32,186,123,2,61,182,91,47,165,108,133,13,10,251,184,171,182,226,10,28,39,88,54,91,41,251,239,115,157,52,235,6,189,73,79,239,233,61,33,135,13,73,135,138,224,141,188,71,105,235,80,174,91,87,179,137,30,3,183,110,58,57,77,39,69,20,118,6,94,143,18,168,89,142,253,13,73,249,30,216,74,162,37,226,157,39,147,32,88,91,20,89,192,11,42,223,202,230,43,144,211,164,119,190,237,200,7,38,201,220,170,170,224,94,98,211,160,63,174,134,62,235,128,157,194,78,162,197,64,128,90,243,217,5,45,116,163,30,62,15,172,14,160,208,193,158,32,10,233,164,73,203,136,64,121,170,31,102,189,241,19,217,36,248,152,207,170,85,121,49,172,174,28,187,184,183,172,64,101,211,219,89,139,83,206,59,30,247,59,91,192,46,175,232,231,255,15,202,192,51,58,19,209,16,176,38,23,184,102,242,229,72,190,14,115,73,243,24,89,143,170,173,134,243,63,138,194,80,88,230,66,134,226,123,200,148,210,246,177,114,223,163,127,193,132,253,0,53,17,76,30,247,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("002c9b1f-92d2-46e4-bb93-2ab334090c0f"));
		}

		#endregion

	}

	#endregion

}

