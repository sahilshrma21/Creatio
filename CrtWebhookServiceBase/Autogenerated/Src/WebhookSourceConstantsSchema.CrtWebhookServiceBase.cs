namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookSourceConstantsSchema

	/// <exclude/>
	public class WebhookSourceConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookSourceConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookSourceConstantsSchema(WebhookSourceConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5c4d12fa-2a84-42e8-8c1f-ddb1a7a5cd70");
			Name = "WebhookSourceConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,65,107,195,48,12,133,207,13,228,63,136,246,158,220,215,109,48,122,221,97,144,65,207,170,235,100,102,181,92,36,187,37,148,253,247,169,206,156,117,59,12,6,6,35,201,223,123,207,34,244,86,142,104,44,188,90,102,148,208,199,102,19,168,119,67,98,140,46,80,93,93,234,106,145,196,209,0,221,40,209,250,117,93,105,167,109,91,184,151,228,61,242,248,248,85,43,24,209,145,192,217,238,222,66,120,7,9,137,85,90,44,159,156,222,38,144,68,164,40,77,17,104,111,20,142,105,119,112,6,204,1,69,96,59,41,116,89,96,83,56,125,117,201,238,139,21,219,65,211,193,60,186,131,151,204,79,227,223,233,114,99,251,51,85,31,24,158,145,246,250,51,215,204,208,109,162,57,210,213,4,36,242,117,9,5,129,7,88,206,184,9,126,185,254,195,186,251,182,68,26,203,126,254,225,250,164,148,26,22,147,149,165,253,180,129,92,127,212,149,158,79,97,44,180,128,204,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c4d12fa-2a84-42e8-8c1f-ddb1a7a5cd70"));
		}

		#endregion

	}

	#endregion

}

