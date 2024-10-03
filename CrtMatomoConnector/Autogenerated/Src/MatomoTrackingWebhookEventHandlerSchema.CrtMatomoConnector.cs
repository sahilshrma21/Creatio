namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MatomoTrackingWebhookEventHandlerSchema

	/// <exclude/>
	public class MatomoTrackingWebhookEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MatomoTrackingWebhookEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MatomoTrackingWebhookEventHandlerSchema(MatomoTrackingWebhookEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baee10dd-b051-4ced-93f6-537b86df4580");
			Name = "MatomoTrackingWebhookEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad22e7a2-e416-4653-a99c-2d68ec80b318");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,77,79,195,48,12,134,207,69,226,63,88,112,41,210,212,222,97,76,2,196,215,161,18,72,67,28,166,29,66,234,181,17,109,92,156,100,104,154,248,239,164,73,153,86,196,199,209,206,235,199,175,237,104,209,162,233,132,68,152,35,179,48,180,178,217,21,233,149,170,28,11,171,72,31,30,108,15,15,18,103,148,174,70,18,198,179,95,242,217,141,144,150,88,161,241,10,175,57,102,172,60,8,174,26,97,204,41,20,194,82,75,115,22,242,213,215,62,227,75,77,244,122,189,70,109,239,132,46,27,228,80,148,231,57,76,141,107,91,193,155,217,16,7,0,88,2,198,142,209,248,10,104,3,12,236,64,131,247,136,3,236,121,80,71,96,246,197,203,247,128,139,63,28,44,253,123,231,94,26,37,65,134,158,255,122,134,83,184,20,6,255,156,42,217,134,201,118,251,40,208,214,84,250,141,60,132,86,241,49,248,84,186,70,86,182,36,153,247,86,147,142,201,162,180,88,2,173,253,170,85,137,176,38,85,194,189,182,200,90,52,177,69,250,100,144,253,237,180,151,246,124,55,10,39,61,40,73,190,28,222,183,29,177,189,220,12,78,11,52,70,84,8,134,28,75,28,162,19,216,134,162,181,96,104,7,193,57,104,124,255,182,143,159,89,233,152,117,182,67,189,57,116,88,8,237,179,236,121,225,170,241,203,108,178,91,180,211,57,57,89,63,238,137,102,105,244,222,119,246,3,25,203,174,87,95,112,229,90,191,224,244,104,60,233,209,228,219,232,39,161,124,112,176,223,61,187,214,33,76,123,242,94,219,104,121,177,132,237,110,238,143,88,254,49,156,16,117,25,175,24,226,152,29,39,67,238,19,223,144,92,6,94,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baee10dd-b051-4ced-93f6-537b86df4580"));
		}

		#endregion

	}

	#endregion

}

