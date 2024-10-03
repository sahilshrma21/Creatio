namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarCountTermFactorySchema

	/// <exclude/>
	public class CalendarCountTermFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarCountTermFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarCountTermFactorySchema(CalendarCountTermFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8");
			Name = "CalendarCountTermFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,203,110,219,48,16,60,43,64,254,97,225,94,156,11,117,79,28,3,173,210,199,197,64,129,58,232,121,77,173,100,34,18,41,240,97,87,8,242,239,93,189,104,199,73,107,231,34,129,203,153,217,225,146,187,26,107,114,13,74,130,53,89,139,206,20,94,100,70,23,170,12,22,189,50,90,100,88,145,206,209,186,235,171,231,235,171,36,56,165,75,248,213,58,79,245,93,92,31,147,45,137,111,40,189,177,138,220,1,17,101,214,170,166,71,173,60,220,159,79,41,38,48,235,176,210,39,75,37,239,67,86,161,115,112,27,53,51,19,180,103,177,122,200,219,246,224,52,77,97,225,66,93,163,109,151,227,122,34,128,236,24,224,153,2,197,192,17,19,37,61,226,52,97,83,41,9,178,207,247,239,108,201,115,159,49,250,91,145,223,154,188,115,248,179,23,24,118,79,13,245,129,239,228,65,98,37,67,213,31,29,106,146,91,212,202,213,176,105,161,84,59,210,224,185,6,16,184,8,34,170,164,167,50,139,6,45,214,160,249,54,239,103,126,44,218,108,185,142,212,69,218,35,14,4,75,62,88,237,150,217,123,201,25,62,237,119,132,177,12,59,101,125,192,10,190,160,163,88,132,238,4,113,49,127,123,203,147,153,27,232,94,79,146,184,189,242,114,11,243,211,120,34,89,245,237,43,17,43,165,131,167,219,1,147,12,174,134,7,48,150,95,176,129,197,128,138,62,150,243,155,187,255,170,254,54,246,137,95,229,101,226,175,192,151,231,248,97,130,61,39,221,97,62,236,250,18,225,35,232,229,250,15,216,158,211,101,200,135,253,94,32,123,64,190,163,158,83,129,161,242,147,198,142,251,151,7,135,177,43,114,14,75,226,65,50,123,212,184,169,8,188,1,105,9,61,1,114,139,91,203,163,205,232,188,27,63,135,134,23,16,187,2,148,227,191,107,72,170,66,81,46,102,99,194,196,111,173,217,131,166,61,124,182,101,168,73,251,175,127,36,53,93,147,204,143,83,143,14,95,186,239,203,56,3,184,6,195,24,232,215,67,244,117,144,99,127,1,227,254,174,82,119,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8"));
		}

		#endregion

	}

	#endregion

}

