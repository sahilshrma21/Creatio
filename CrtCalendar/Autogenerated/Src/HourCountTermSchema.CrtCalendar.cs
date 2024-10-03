namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HourCountTermSchema

	/// <exclude/>
	public class HourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HourCountTermSchema(HourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39");
			Name = "HourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,93,107,27,49,16,124,118,32,255,97,113,94,46,16,116,239,141,123,80,156,54,53,36,80,168,251,3,228,187,141,45,208,73,174,86,10,28,161,255,189,43,201,58,159,157,143,246,197,88,123,51,187,179,51,146,145,61,210,94,182,8,107,116,78,146,125,242,98,105,205,147,218,6,39,189,178,70,44,165,70,211,73,71,151,23,47,151,23,179,64,202,108,225,231,64,30,251,219,179,51,51,181,198,54,210,72,220,163,65,167,218,87,152,7,101,126,31,139,239,76,101,0,67,174,28,110,249,0,75,45,137,224,19,124,183,193,45,109,48,158,89,125,66,212,117,13,11,10,125,47,221,208,28,206,9,1,158,33,176,25,96,199,28,18,5,90,79,176,251,176,209,170,133,54,53,63,105,205,163,30,149,9,30,39,195,102,47,105,224,168,233,17,253,206,118,81,213,143,212,39,127,61,215,147,5,73,221,6,45,61,66,199,63,107,213,99,20,214,30,124,21,35,175,62,39,46,246,210,201,30,12,103,244,121,222,201,129,230,77,73,3,226,81,44,234,132,120,155,144,54,159,55,113,51,2,111,227,192,44,227,53,205,161,15,206,208,177,187,103,145,12,43,245,8,60,216,101,159,57,49,213,33,220,149,93,198,245,170,213,87,19,122,116,114,163,113,177,42,189,238,228,208,36,181,55,160,56,151,164,234,26,226,85,154,205,30,236,182,176,217,211,149,225,208,158,165,166,42,195,51,244,54,33,179,146,188,245,55,229,200,87,215,226,56,33,43,17,95,186,46,109,91,77,152,127,62,8,230,30,61,59,179,195,180,46,4,163,60,253,111,26,37,189,121,179,102,254,152,229,135,129,48,36,195,249,207,251,25,172,71,45,208,198,235,247,143,24,162,167,188,71,100,253,138,164,106,52,254,44,130,162,241,6,166,49,21,239,138,247,13,236,249,213,242,197,46,17,29,140,223,72,66,113,50,231,216,111,100,164,171,158,138,252,152,137,205,204,175,136,86,38,198,50,141,227,138,81,249,33,165,115,174,158,22,185,246,23,93,79,14,21,157,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39"));
		}

		#endregion

	}

	#endregion

}

