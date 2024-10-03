namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLProblemTypeFeaturesSchema

	/// <exclude/>
	public class IMLProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLProblemTypeFeaturesSchema(IMLProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af781143-48a0-4837-b191-06bc575a6ccb");
			Name = "IMLProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,77,106,3,49,12,70,215,9,228,14,90,166,155,153,3,180,116,19,40,9,36,180,139,92,64,227,202,19,131,109,25,89,94,132,144,187,87,51,249,33,208,133,12,50,223,247,244,50,38,170,5,29,193,145,68,176,178,215,110,195,217,135,177,9,106,224,220,29,246,171,229,101,181,92,244,125,15,31,181,165,132,114,254,188,239,187,172,36,126,106,123,22,40,40,26,92,139,40,224,9,181,9,85,96,15,122,34,168,133,92,240,193,65,17,30,34,37,208,115,161,238,65,237,95,176,165,13,209,114,225,73,222,29,246,63,183,210,209,58,95,119,176,37,77,202,222,127,94,243,199,22,237,116,211,210,20,214,138,50,146,190,129,227,216,82,158,77,19,255,82,4,21,12,57,228,177,123,98,94,69,22,3,115,156,64,223,51,103,115,107,95,192,88,239,112,181,128,205,117,82,248,3,54,100,141,23,67,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af781143-48a0-4837-b191-06bc575a6ccb"));
		}

		#endregion

	}

	#endregion

}

