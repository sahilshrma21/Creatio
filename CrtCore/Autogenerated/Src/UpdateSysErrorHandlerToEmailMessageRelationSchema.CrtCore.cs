namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSysErrorHandlerToEmailMessageRelationSchema

	/// <exclude/>
	public class UpdateSysErrorHandlerToEmailMessageRelationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSysErrorHandlerToEmailMessageRelationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSysErrorHandlerToEmailMessageRelationSchema(UpdateSysErrorHandlerToEmailMessageRelationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f69597b-1185-4732-b96f-2a663e953947");
			Name = "UpdateSysErrorHandlerToEmailMessageRelation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a6ded360-42cd-4008-9952-fcaf8207688b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,223,111,155,48,16,199,223,39,237,127,56,241,68,164,66,154,148,148,102,105,43,45,132,116,121,232,52,149,118,175,147,129,75,234,201,216,145,109,178,161,170,255,251,46,128,10,201,154,90,72,24,251,238,115,223,251,1,128,100,5,154,45,203,16,30,81,107,102,212,218,250,145,146,107,190,41,53,179,92,73,120,249,252,9,104,149,134,203,13,36,149,177,88,204,254,63,34,39,33,48,219,123,24,255,14,37,106,158,29,152,245,241,69,161,228,201,75,141,31,92,249,177,180,220,114,52,100,211,88,13,135,67,184,54,101,81,48,93,221,118,71,79,219,156,89,132,77,163,4,176,96,92,128,169,36,109,181,86,26,40,107,195,54,8,26,69,157,102,15,54,60,164,109,203,84,16,33,19,204,152,22,75,41,199,123,202,55,38,115,129,250,81,197,123,252,125,131,124,104,137,240,5,86,43,105,44,19,34,201,52,223,218,248,47,102,165,165,216,109,69,9,173,249,110,175,242,174,228,57,252,194,3,228,3,166,92,230,112,83,95,250,63,152,54,232,58,151,163,52,156,224,52,245,198,105,126,238,5,151,1,243,210,171,32,247,130,44,13,67,54,154,132,1,27,57,131,217,7,252,86,228,41,126,176,92,94,140,151,115,111,49,141,2,47,184,186,136,189,175,227,241,194,155,132,211,81,20,5,180,194,243,154,255,22,161,41,206,78,81,128,38,63,116,159,12,106,26,33,217,76,3,181,177,255,57,232,178,7,168,155,89,213,109,233,215,179,61,190,57,114,109,122,95,37,217,51,117,243,158,73,74,67,211,168,217,230,120,94,125,167,81,118,157,228,8,230,156,29,43,152,117,2,118,76,67,166,100,206,235,185,165,136,18,255,192,130,215,118,52,1,215,198,106,154,193,51,80,233,111,114,190,237,107,7,120,1,103,149,19,254,221,198,189,118,150,175,189,128,124,13,238,251,233,250,75,180,217,243,82,171,98,49,119,59,77,131,193,97,208,19,206,9,90,250,1,203,66,254,100,162,164,42,212,38,145,202,177,167,240,168,245,253,58,156,230,178,29,186,107,38,12,246,205,223,146,107,55,244,162,231,31,132,139,185,206,77,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f69597b-1185-4732-b96f-2a663e953947"));
		}

		#endregion

	}

	#endregion

}

