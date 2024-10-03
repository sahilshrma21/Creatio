namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITimeZoneProviderSchema

	/// <exclude/>
	public class ITimeZoneProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITimeZoneProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITimeZoneProviderSchema(ITimeZoneProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfa2b430-c6c6-4cf0-9146-f9cae961564f");
			Name = "ITimeZoneProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,80,177,78,195,48,16,157,27,41,255,112,234,4,75,188,23,211,165,66,168,27,18,153,216,220,112,9,150,234,115,116,62,183,50,136,127,199,110,147,128,138,228,193,247,238,189,231,247,76,198,97,24,77,135,208,34,179,9,190,151,102,231,169,183,67,100,35,214,83,93,125,213,213,42,6,75,3,188,166,32,232,30,150,121,231,25,155,39,18,43,22,67,134,243,66,41,5,58,68,231,12,167,237,52,191,176,63,217,119,12,32,214,33,124,122,66,56,36,24,236,9,9,130,143,220,97,51,43,213,141,84,75,26,113,52,108,28,80,78,250,184,110,47,207,165,245,182,93,188,38,11,173,22,110,81,143,241,112,180,29,88,18,228,190,244,219,23,197,91,22,76,113,88,79,94,133,189,58,127,32,231,63,184,34,176,129,235,37,111,74,251,127,173,46,192,51,202,159,74,205,194,83,183,68,205,40,145,41,252,102,206,97,103,172,144,230,100,123,234,125,177,157,231,187,251,242,215,223,117,149,207,15,148,125,101,161,169,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfa2b430-c6c6-4cf0-9146-f9cae961564f"));
		}

		#endregion

	}

	#endregion

}

