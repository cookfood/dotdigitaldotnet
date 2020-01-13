using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiTransactionalDataImportReportFault
	{
		public string Key
		{ get; set; }

		public ApiTransactionalDataImportFaultReason Reason
		{ get; set; }
	}
}
