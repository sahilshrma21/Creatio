namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoSchema

	/// <exclude/>
	public class NotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoSchema(NotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("026063fa-ed79-499f-833f-fe2eb2fb3566");
			Name = "NotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,183,208,119,208,19,52,247,181,12,182,110,148,192,214,67,155,61,128,103,43,169,32,182,131,37,31,194,216,187,207,245,82,8,219,161,46,216,70,146,191,63,176,157,178,200,131,210,8,13,134,160,216,183,178,222,121,215,82,23,131,18,242,110,181,252,90,45,23,145,201,117,112,26,89,208,110,82,159,86,85,85,176,229,104,173,10,227,227,212,239,122,197,12,173,15,64,46,157,54,43,128,111,65,206,8,206,11,181,164,243,108,125,21,168,102,10,67,252,236,73,131,206,34,135,25,186,78,98,15,80,255,29,37,202,37,219,149,199,18,46,33,27,146,30,33,95,44,58,148,77,46,120,42,190,255,227,159,189,25,75,224,251,72,6,106,171,58,172,77,49,254,213,9,201,88,70,152,242,252,82,78,250,140,86,29,210,235,20,123,189,35,243,173,116,51,206,139,18,108,40,233,31,209,146,51,185,44,34,78,57,223,188,50,24,238,74,152,254,207,147,73,102,31,142,228,46,175,125,240,113,184,101,149,118,38,255,0,208,84,73,153,211,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("026063fa-ed79-499f-833f-fe2eb2fb3566"));
		}

		#endregion

	}

	#endregion

}

