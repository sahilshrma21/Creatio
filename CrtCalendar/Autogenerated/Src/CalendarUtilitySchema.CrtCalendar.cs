namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilitySchema

	/// <exclude/>
	public class CalendarUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilitySchema(CalendarUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a");
			Name = "CalendarUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,82,203,78,195,48,16,60,183,82,255,97,149,94,202,37,190,67,26,9,202,165,55,36,218,15,216,186,155,98,41,177,35,63,64,165,226,223,89,59,105,104,194,133,35,183,236,120,103,60,51,142,198,134,92,139,146,96,71,214,162,51,149,207,55,70,87,234,20,44,122,101,116,190,193,154,244,17,173,91,204,47,139,249,44,56,165,79,163,101,75,15,139,57,159,44,45,157,152,0,155,26,157,131,123,184,18,247,94,213,202,159,211,142,16,2,10,23,154,6,237,185,236,231,71,144,137,225,223,208,67,107,205,187,58,146,3,217,179,193,171,134,226,36,67,157,12,65,72,122,138,92,126,21,20,55,138,109,56,212,74,66,139,214,43,172,123,233,137,149,223,230,158,208,17,147,47,201,228,79,18,163,157,183,65,122,99,99,160,151,36,221,173,76,131,36,96,171,85,188,84,125,178,127,4,77,31,160,88,0,53,183,107,42,206,71,76,33,14,99,169,90,103,19,7,153,40,59,179,249,32,47,166,250,5,167,194,6,52,191,217,58,11,142,44,27,212,36,99,43,89,185,99,249,136,129,28,192,188,16,137,145,4,250,98,38,215,174,246,35,25,24,171,222,113,234,3,87,179,154,194,241,79,152,125,253,151,42,28,63,16,117,13,164,207,191,228,222,94,129,103,244,248,26,89,197,0,21,55,135,231,178,236,68,135,46,250,233,182,130,37,47,119,255,76,154,59,116,12,50,246,13,25,212,184,111,108,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a"));
		}

		#endregion

	}

	#endregion

}

