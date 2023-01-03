using Newtonsoft.Json;
using TellMeWhatToDo.DTOs;

namespace TellMeWhatToDo
{
    internal class ResponseDeserializer
    {
        public Activity DeserializeResponse(string responseString, HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Activity>(responseString);
            }
            else
            {
                Console.WriteLine("There is a problem with the API.");
                return null;
            }
        }
    }
}
