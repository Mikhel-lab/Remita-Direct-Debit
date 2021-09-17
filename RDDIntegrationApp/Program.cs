using RDDIntegration.Models.Request.MandateActivateRequestOtps;
using RDDIntegration.Models.Request.SetUpMandate;
using RDDIntegration.Service.RDDIServices;
using System;

namespace RDDIntegrationApp
{
	class Program
	{
		static void Main(string[] args)
		{
			RDDIService service = new RDDIService("27768931", "35126630", "Q1dHREVNTzEyMzR8Q1dHREVNTw==");

			MandateSetUpRequest mandateSetUp = new MandateSetUpRequest
			{
				amount = "5000.00",
				payerAccount = "0035509366",
				endDate = "6/5/2021",
				startDate = "6/5/2021",
				maxNoOfDebits = "6",
				payerName = "Oshadami Mike",
				payerEmail = "oshadami@example.com",
				payerBankCode = "057",
				payerPhone = "08012345678"
			};

			var result = service.SetUpManDatee(mandateSetUp).Result;


			//MandateActivateRequestOtp requestOtp = new MandateActivateRequestOtp
			//{
			//	requestId = "1548920866",
			//	mandateId = "100007729391"
			//};
			//var res = service.RequestOtpResponse(requestOtp).Result;
		}
	}
}
