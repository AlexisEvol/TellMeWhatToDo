using TellMeWhatToDo.DTOs;

namespace TellMeWhatToDo.Requests
{
    internal class RandomRequest
    {
        private ResponseDeserializer responseDeserializer = new ResponseDeserializer();
        private HttpClient httpClient = new HttpClient();
        private HttpRequestMessage request = new HttpRequestMessage();
        private HttpResponseMessage response;
        private string responseString;
        public async Task<Activity> RequestRandomActivity()
        {
            request.RequestUri = new Uri($"https://www.boredapi.com/api/activity/");
            request.Method = HttpMethod.Get;

            response = httpClient.Send(request);
            responseString = await response.Content.ReadAsStringAsync();

            httpClient.Dispose();

            return responseDeserializer.DeserializeResponse(responseString, response);
        }
    }
}
