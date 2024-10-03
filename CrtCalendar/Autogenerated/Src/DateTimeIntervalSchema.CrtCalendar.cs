namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeIntervalSchema

	/// <exclude/>
	public class DateTimeIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeIntervalSchema(DateTimeIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be7d9f97-3f60-46fc-bf01-100533e7371c");
			Name = "DateTimeInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccf14817-0a4a-4532-9be8-ee78c30bd143");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,203,10,194,48,16,69,215,45,244,31,6,220,183,123,21,55,234,194,117,251,3,99,59,45,129,102,90,38,19,65,196,127,55,125,73,65,20,92,4,230,38,39,231,134,48,90,114,61,150,4,5,137,160,235,106,77,143,29,215,166,241,130,106,58,78,226,71,18,71,222,25,110,32,191,59,37,187,11,121,35,212,132,67,200,85,124,169,176,133,19,42,21,198,210,133,149,228,134,109,18,7,42,203,50,216,59,111,45,202,253,48,231,1,116,80,118,172,104,152,36,93,176,108,197,245,254,218,154,18,220,36,255,84,71,195,147,62,236,227,70,174,40,10,26,240,244,205,172,213,139,123,145,206,23,70,97,212,144,238,198,193,205,195,243,107,207,153,171,127,90,6,252,71,199,176,54,196,213,244,171,73,28,242,11,241,254,254,143,153,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7d9f97-3f60-46fc-bf01-100533e7371c"));
		}

		#endregion

	}

	#endregion

}

