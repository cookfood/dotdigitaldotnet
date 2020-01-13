using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiCampaignContactOpen
	{
		public int ContactId
		{ get; set; }

		public string Email
		{ get; set; }

		public string MailClient
		{ get; set; }

		public string MailClientVersion
		{ get; set; }

		public byte[] IP
		{ get; set; }

		public string IpAddress
		{ get; set; }

		public int UserAgentId
		{ get; set; }

		public string UserAgent
		{ get; set; }

		public bool IsHtml
		{ get; set; }

		public bool IsForward
		{ get; set; }

		public DateTime DateOpened
		{ get; set; }

		public int MailClientID
		{ get; set; }

		public int MailClientVersionID
		{ get; set; }
	}
}
