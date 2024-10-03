namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetDefAuditLogSettingsSchema

	/// <exclude/>
	public class SetDefAuditLogSettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetDefAuditLogSettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetDefAuditLogSettingsSchema(SetDefAuditLogSettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb904ddf-df79-4f2c-8b8d-2d63191aa732");
			Name = "SetDefAuditLogSettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1296b383-c2ef-47b8-ae67-0601cddb70e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,144,193,106,195,48,12,134,207,29,236,29,68,79,45,148,60,64,203,14,97,219,161,48,216,33,235,238,158,163,100,6,215,14,150,52,214,150,189,251,228,132,108,75,142,163,32,25,126,244,235,179,36,8,230,136,212,25,139,240,130,41,25,138,13,23,247,49,52,174,149,100,216,197,0,183,55,23,205,133,144,11,237,196,148,112,247,91,200,178,58,81,133,204,42,9,238,102,214,41,180,248,99,237,33,26,157,188,121,103,193,122,67,4,90,124,192,166,148,218,241,83,108,127,168,91,216,239,3,177,241,190,178,201,117,252,248,137,86,56,166,140,232,167,28,41,31,209,213,48,84,113,117,32,76,250,125,64,219,47,36,19,185,134,75,238,91,204,22,40,134,9,94,141,23,92,77,59,54,176,84,98,134,150,194,239,49,185,115,191,147,206,185,220,0,39,193,245,238,95,196,178,62,186,144,177,215,33,61,119,56,28,123,188,226,21,152,163,123,78,251,210,71,83,227,27,88,243,186,169,81,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb904ddf-df79-4f2c-8b8d-2d63191aa732"));
		}

		#endregion

	}

	#endregion

}

