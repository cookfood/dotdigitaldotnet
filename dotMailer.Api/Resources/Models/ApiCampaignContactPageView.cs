using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiCampaignContactPageView
	{
		public int ContactId
		{ get; set; }

		public string Email
		{ get; set; }

		public string Url
		{ get; set; }

		public DateTime DateViewed
		{ get; set; }
	}
}
