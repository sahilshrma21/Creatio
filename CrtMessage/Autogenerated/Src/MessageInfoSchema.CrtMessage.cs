namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageInfoSchema

	/// <exclude/>
	public class MessageInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageInfoSchema(MessageInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9feca6c1-1d38-4545-9bd8-624db176b74f");
			Name = "MessageInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,201,110,194,48,16,61,19,41,255,96,137,107,149,220,1,33,181,161,2,164,210,162,66,63,192,216,147,96,41,182,35,143,115,136,80,255,189,182,179,148,92,90,224,230,89,222,50,99,187,70,161,10,114,104,208,130,156,199,81,125,21,38,153,46,75,96,86,104,133,201,26,20,24,193,134,150,35,24,67,81,231,214,117,25,72,94,149,21,86,0,186,122,28,41,42,1,43,202,96,212,165,114,81,212,134,122,186,56,186,248,190,201,212,64,225,66,146,149,20,113,70,118,128,72,11,216,170,92,135,114,85,159,74,193,8,243,213,113,113,210,226,7,130,189,209,21,24,111,96,70,246,1,213,214,59,6,180,198,123,238,40,200,197,151,38,8,118,30,14,69,119,248,30,97,214,181,224,36,51,64,45,240,151,102,203,111,67,173,92,251,81,72,232,145,31,234,14,181,157,230,34,23,15,201,245,208,91,245,126,129,237,78,54,2,173,54,205,35,174,223,181,245,210,230,19,152,54,252,86,231,39,173,75,178,161,248,108,45,101,103,9,202,254,131,75,211,148,44,176,150,146,154,102,217,39,86,34,60,79,151,34,200,206,32,233,215,150,35,161,138,19,211,185,65,162,115,82,186,233,252,251,197,100,96,74,175,169,250,165,12,108,11,63,217,83,152,111,73,222,122,180,91,26,189,99,49,135,222,209,35,147,133,15,229,166,178,238,62,254,118,221,118,102,103,170,10,56,54,21,116,137,131,71,118,202,189,224,96,161,83,158,130,226,237,15,10,113,155,29,39,67,46,142,126,0,28,89,50,92,39,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9feca6c1-1d38-4545-9bd8-624db176b74f"));
		}

		#endregion

	}

	#endregion

}

