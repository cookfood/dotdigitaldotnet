using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSplitTestCampaign
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public StringList Subjects
		{ get; set; }

		public StringList FromNames
		{ get; set; }

		public ApiCampaignFromAddressList FromAddresses
		{ get; set; }

		public StringList HtmlContents
		{ get; set; }

		public StringList PlainTextContents
		{ get; set; }

		public ApiCampaignReplyActions ReplyAction
		{ get; set; }

		public string ReplyToAddress
		{ get; set; }

		public ApiCampaignStatuses Status
		{ get; set; }

		public SplitTestOptions SplitTestOptions
		{ get; set; }

		public int SplitTestCount
		{ get; set; }
	}
}
