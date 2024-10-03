namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoSchema

	/// <exclude/>
	public class INotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoSchema(INotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aee85563-7cba-4466-bec1-e9df72ba319c");
			Name = "INotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,93,110,194,48,16,132,159,65,226,14,123,2,114,0,170,74,253,19,138,212,242,0,244,0,38,222,132,69,120,141,236,205,67,132,122,247,218,6,84,42,72,139,145,146,40,118,60,243,101,70,78,88,25,244,59,85,33,44,209,57,229,109,45,227,23,203,53,53,173,83,66,150,71,195,253,104,56,104,61,113,3,139,206,11,154,73,24,135,163,40,10,120,240,173,49,202,117,143,199,113,201,130,174,142,110,181,117,64,28,174,38,185,128,173,65,214,8,108,133,106,170,210,220,248,100,82,156,185,236,218,213,150,170,32,61,25,149,179,51,73,25,28,195,162,248,70,23,252,52,177,36,217,98,31,236,146,54,240,226,98,176,131,108,15,13,202,4,124,188,124,197,167,189,152,103,171,187,124,74,82,221,14,41,53,242,143,245,9,71,70,53,216,195,153,182,164,161,140,11,74,157,1,154,99,101,157,6,58,242,208,129,93,109,176,146,140,132,137,252,22,228,210,101,161,23,213,26,141,2,14,187,48,191,207,3,239,96,49,139,14,249,221,134,172,183,166,251,64,239,175,54,219,11,121,85,130,160,88,131,80,86,188,168,91,70,201,28,13,177,78,183,183,50,207,191,22,216,90,165,99,194,208,205,223,77,190,167,133,119,118,248,123,127,106,244,66,252,111,155,225,87,242,164,67,186,79,38,201,96,78,157,109,119,119,110,151,164,189,154,49,156,169,211,111,149,4,186,64,13,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aee85563-7cba-4466-bec1-e9df72ba319c"));
		}

		#endregion

	}

	#endregion

}

