using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiDataField
	{
		public string Name
		{ get; set; }

		public ApiDataTypes Type
		{ get; set; }

		public ApiDataFieldVisibility Visibility
		{ get; set; }
	}
}
