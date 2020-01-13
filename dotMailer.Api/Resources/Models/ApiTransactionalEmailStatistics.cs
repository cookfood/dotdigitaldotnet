using System;
using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
	public class ApiTransactionalEmailStatistics
	{
		public DateTime StartDate
		{ get; set; }

		public DateTime EndDate
		{ get; set; }

		public int NumSent
		{ get; set; }

		public int NumDelivered
		{ get; set; }

		public int NumOpens
		{ get; set; }

		public int NumClicks
		{ get; set; }

		public int NumIspComplaints
		{ get; set; }

		public int NumBounces
		{ get; set; }
	}
}
