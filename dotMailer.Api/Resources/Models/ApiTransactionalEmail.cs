using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiTransactionalEmail
	{
		public StringList ToAddresses
		{ get; set; }

		public StringList CCAddresses
		{ get; set; }

		public StringList BCCAddresses
		{ get; set; }

		public string Subject
		{ get; set; }

		public string FromAddress
		{ get; set; }

		public string HtmlContent
		{ get; set; }

		public string PlainTextContent
		{ get; set; }

		public StringList Tags
		{ get; set; }
	}
}
