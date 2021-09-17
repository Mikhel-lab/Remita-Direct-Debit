using Newtonsoft.Json;
using RDDIntegration.Extensions;
using RDDIntegration.Models.Request.MandateActivateRequestOtps;
using RDDIntegration.Models.Request.SetUpMandate;
using RDDIntegration.Models.Response;
using RDDIntegration.Service.Interface;
using RDDIntegration.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RDDIntegration.Service.RDDIServices
{
	public class RDDIService : IRDDIService
	{
        private string _remitaBaseUrl;
        private readonly HttpClient _client;
        private readonly string _merchantId;
        private readonly string _serviceTypeId;
        private readonly string _requestId;
        private readonly string _mandateSetUpUrl;
        private readonly string _requestAuthorization;
        private readonly string _apiKey;
        private readonly string _apitoken;
        private readonly string _mandateId;
        private string _hash;
        private string _apihash;
        private string _mandateType;
        StatusCodes _statusCodes;
		public RDDIService(string merchantId,  string serviceTyeId, string apiKey, string mandateType = "DD", string remitaBaseUrl = "https://remitademo.net/remita/exapp/api/v1/send/api/echannelsvc/echannel/mandate", string mandateSetUpUrl = "/setup")
        {
            _remitaBaseUrl = remitaBaseUrl;
            _requestId = DateTime.Now.Ticks.ToString();
            _merchantId = merchantId;
            _serviceTypeId = serviceTyeId;
            _mandateSetUpUrl = mandateSetUpUrl;
            //_requestAuthorization = requestAuthor;
            _apiKey = apiKey;
           // _apitoken = apitoken;
            _mandateType = mandateType;
           // _mandateId = mandateId;
            _client = new HttpClient();
            _statusCodes = new StatusCodes();

        }

        public async Task<MandateSetUpResponse> SetUpManDatee(MandateSetUpRequest request)
		{
            try
            {
                _hash = Utilility.SHA512Hash(_merchantId + _serviceTypeId + _requestId + request.amount + _apiKey);

                request.hash = _hash;
                request.mandateType = _mandateType;
                request.requestId = _requestId;
                request.serviceTypeId = _serviceTypeId;
                request.mandateType = _mandateType;
                request.merchantId = _merchantId;
                request.startDate = Convert.ToDateTime(request.startDate).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                request.endDate = Convert.ToDateTime(request.endDate).ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                _client.BaseAddress = new Uri($"{_remitaBaseUrl}{_mandateSetUpUrl}");

                var payLoad = JsonConvert.SerializeObject(request);
                var content = new StringContent(payLoad, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    var resultStream = await response.Content.ReadAsStreamAsync();
                    var returnResult = ServiceInjectionExtension.DeserializeEmbeddedJsonP<MandateSetUpResponse>(resultStream);

                    return returnResult;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

		public async Task<MandateActivateRequestOtpResponse> RequestOtpResponse(MandateActivateRequestOtp request)
		{
			try
			{
                _apihash = Utilility.SHA512Hash( _requestId + _apitoken);
                request.mandateId = _mandateId;
                request.requestId = _requestId;

                _client.BaseAddress = new Uri($"{_remitaBaseUrl}{_mandateSetUpUrl}");

                var payLoad = JsonConvert.SerializeObject(request);
                var content = new StringContent(payLoad, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("", content);

                if (response.IsSuccessStatusCode)
                {
                    var resultStream = await response.Content.ReadAsStreamAsync();
                    var returnResult = ServiceInjectionExtension.DeserializeEmbeddedJsonP<MandateActivateRequestOtpResponse>(resultStream);

                    return returnResult;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
	}
}
