using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiContactScore
	{
		public int ContactId
		{ get; set; }

		public string Email
		{ get; set; }

		public DateTime DateModified
		{ get; set; }

		public string ScoreLabel
		{ get; set; }

		public byte Score
		{ get; set; }

		public byte Engagement
		{ get; set; }

		public byte Suitability
		{ get; set; }
	}
}
