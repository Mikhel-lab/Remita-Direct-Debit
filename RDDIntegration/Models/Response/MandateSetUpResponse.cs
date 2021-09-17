using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDDIntegration.Models.Response
{
	public class MandateSetUpResponse
	{
		public string statuscode { get; set; }
		public string requestId { get; set; }
		public string mandateId { get; set; }
		public string status { get; set; }
	}
}
