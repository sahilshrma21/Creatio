namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermCalculatorSchema

	/// <exclude/>
	public class ITermCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermCalculatorSchema(ITermCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4");
			Name = "ITermCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,145,77,78,3,49,12,133,215,68,202,29,172,174,96,51,57,64,135,217,148,13,219,78,47,144,6,79,21,105,242,35,59,65,170,16,119,111,210,146,41,5,9,216,32,101,17,219,239,203,243,83,50,91,127,128,241,200,9,221,90,10,41,188,118,200,81,27,132,29,18,105,14,83,234,54,193,79,246,144,73,39,27,124,55,34,189,90,131,101,236,164,120,147,226,78,41,5,61,103,231,52,29,135,143,122,139,145,144,209,39,6,190,232,33,21,0,140,158,77,158,117,10,212,53,82,125,66,99,222,207,214,128,245,69,60,213,37,158,171,205,102,129,138,164,58,126,179,60,55,154,12,161,88,199,224,25,225,165,84,221,2,168,175,68,31,53,105,7,53,243,227,138,147,166,244,84,128,213,48,214,235,5,238,213,89,115,69,8,83,38,207,195,246,198,163,87,173,95,133,245,149,157,117,120,93,169,169,235,228,126,25,47,150,15,235,63,164,226,48,231,250,3,255,153,106,188,241,248,45,85,83,255,148,234,93,138,114,78,145,199,124,144,104,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4"));
		}

		#endregion

	}

	#endregion

}

