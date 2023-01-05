using System.Net;
using TellMeWhatToDo.DTOs;
using TellMeWhatToDo.Requests;

namespace TellMeWhatToDo.Screens
{
    internal class MenuTypeActivity
    {
        public void TypesActivitiesScreen()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Write the type of activity.           -");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("The types can only be the following ones:");
            Console.WriteLine("Education, Recreational, Social, Diy, Charity, Cooking, Relaxation, Music, Busywork.");
            TypesActivitiesScreenFunction();
        }

        private void TypesActivitiesScreenFunction()
        {
            List<string> activities = new List<string>() {"education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork"};
            string activityType = Console.ReadLine().ToLower();

            foreach (string type in activities)
            {
                if (activityType.Equals(type))
                {
                    TypesRequest typesRequest = new TypesRequest();
                    Activity activity = typesRequest.RequestTypesActivity(activityType).Result;

                    Console.WriteLine($"[The activity you could do is {activity.activity}]");
                }
            }
        }
    }
}