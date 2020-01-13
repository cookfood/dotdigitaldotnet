using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiProgram
	{
		public int ID
		{ get; set; }

		public string Name
		{ get; set; }

		public ApiProgramStatus Status
		{ get; set; }

		public DateTime DateCreated
		{ get; set; }
	}
}
