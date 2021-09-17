using RDDIntegration.Models.Request.MandateActivateRequestOtps;
using RDDIntegration.Models.Request.SetUpMandate;
using RDDIntegration.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDDIntegration.Service.Interface
{
	public interface IRDDIService
	{
		Task<MandateSetUpResponse> SetUpManDatee(MandateSetUpRequest request);
		Task<MandateActivateRequestOtpResponse> RequestOtpResponse(MandateActivateRequestOtp request);
	}
}
