namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailHashComposerSchema

	/// <exclude/>
	public class IEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailHashComposerSchema(IEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2");
			Name = "IEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,147,177,110,194,48,16,134,103,144,250,14,39,88,90,169,74,118,8,89,0,1,67,85,212,210,7,48,206,37,88,114,156,232,108,87,66,168,239,94,199,134,148,4,134,170,99,71,223,253,247,231,187,223,142,98,37,234,154,113,132,29,18,49,93,229,38,154,87,42,23,133,37,102,68,165,30,134,167,135,225,192,106,161,10,120,63,106,131,229,180,119,118,122,41,145,55,98,29,173,80,33,9,254,163,185,182,37,116,117,215,25,19,22,78,13,27,101,144,114,247,241,9,108,150,37,19,114,205,244,97,94,149,117,165,145,188,50,142,99,72,180,45,75,70,199,244,124,222,82,245,41,50,212,192,106,1,121,69,128,205,40,184,61,52,43,16,14,206,195,53,57,147,220,50,217,80,69,23,163,248,202,169,182,123,41,56,136,11,194,93,130,193,201,83,180,192,47,104,14,85,166,39,176,245,211,161,217,103,244,5,120,67,99,73,233,22,167,205,40,144,73,102,48,131,253,241,12,95,51,114,23,225,80,116,212,90,198,125,207,196,171,64,57,229,108,100,29,160,187,40,21,76,71,105,162,17,129,19,230,179,209,71,183,21,167,110,75,109,152,226,24,37,177,247,184,111,233,81,70,233,178,79,116,51,68,97,183,179,242,102,67,55,112,81,52,35,155,165,178,37,18,219,75,76,180,33,247,40,82,88,161,89,251,177,199,46,44,116,215,122,134,246,82,22,187,215,144,213,211,244,55,177,103,152,51,43,141,135,251,151,137,247,66,14,193,54,185,46,194,230,77,102,127,15,119,140,42,11,111,222,159,191,194,111,219,41,250,218,55,196,194,173,242,63,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4ee924f-2761-4cad-9702-50f6fc4e2bb2"));
		}

		#endregion

	}

	#endregion

}

