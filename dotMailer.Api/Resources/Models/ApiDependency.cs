using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiDependency
	{
		public ApiBusinessObjectType Type
		{ get; set; }

		public int ObjectId
		{ get; set; }
	}
}
