using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiCampaignDetails
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public string Subject
		{ get; set; }

		public string FromName
		{ get; set; }

		public ApiCampaignFromAddress FromAddress
		{ get; set; }

		public string HtmlContent
		{ get; set; }

		public string PlainTextContent
		{ get; set; }

		public ApiCampaignReplyActions ReplyAction
		{ get; set; }

		public string ReplyToAddress
		{ get; set; }

		public bool IsSplitTest
		{ get; set; }

		public ApiCampaignStatuses Status
		{ get; set; }

		public ApiCampaignTypes Type
		{ get; set; }

		public ApiCampaignTagList Tags
		{ get; set; }

		public StringList SplitTestOptions
		{ get; set; }

		public DateTime SentDate
		{ get; set; }
	}
}
