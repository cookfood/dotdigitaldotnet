using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiCampaignContactClickWithGroups
	{
		public int ContactId
		{ get; set; }

		public string Email
		{ get; set; }

		public string Url
		{ get; set; }

		public byte[] Ip
		{ get; set; }

		public string IpAddress
		{ get; set; }

		public int UserAgentId
		{ get; set; }

		public string UserAgent
		{ get; set; }

		public DateTime DateClicked
		{ get; set; }

		public string Keyword
		{ get; set; }

		public int LinkId
		{ get; set; }

		public ApiCampaignLinkGroupList Groups
		{ get; set; }
	}
}
