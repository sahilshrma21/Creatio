namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRemindingTextFormerSchema

	/// <exclude/>
	public class IRemindingTextFormerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRemindingTextFormerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRemindingTextFormerSchema(IRemindingTextFormerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("734bc083-96cd-481d-a4cd-ea2b71a900a5");
			Name = "IRemindingTextFormer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a637eec-ed5e-4e5a-93be-edcf08166986");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,82,205,78,132,48,16,62,47,201,190,195,100,189,104,98,224,174,200,193,191,13,183,141,242,2,5,134,181,134,182,100,90,84,98,124,119,167,69,16,93,15,122,242,56,51,223,223,116,170,133,66,219,137,10,161,64,34,97,77,227,226,43,163,27,185,239,73,56,105,52,172,163,215,117,180,234,173,212,123,184,31,172,67,197,128,182,197,202,79,109,188,69,141,36,171,243,25,179,212,33,140,111,180,147,78,162,101,0,67,142,8,247,94,52,215,14,169,97,219,51,200,239,80,73,93,51,181,192,23,119,107,72,33,5,108,146,36,144,218,94,41,65,67,246,81,239,200,60,201,26,45,200,73,0,26,67,64,147,4,56,214,240,45,22,177,241,36,146,44,84,186,190,108,101,181,224,255,236,191,242,75,31,68,8,141,45,186,133,97,105,234,33,184,198,48,51,146,239,148,180,19,36,20,104,126,236,139,141,79,183,243,53,114,4,187,201,174,101,120,74,198,195,179,116,15,33,189,87,238,102,76,156,38,161,8,122,214,145,159,114,138,75,182,62,206,63,233,233,56,58,5,83,62,242,121,50,248,234,116,226,111,180,250,229,90,124,180,22,255,105,175,194,123,255,117,177,183,241,127,161,174,199,47,182,142,184,243,14,101,20,43,132,222,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("734bc083-96cd-481d-a4cd-ea2b71a900a5"));
		}

		#endregion

	}

	#endregion

}

