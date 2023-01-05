using TellMeWhatToDo.DTOs;
using TellMeWhatToDo.Requests;

namespace TellMeWhatToDo.Screens
{
    internal class Menu
    {
        public void MainScreen()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Choose an option writing it's number. -");
            Console.WriteLine("- 1. Give me a random activity          -");
            Console.WriteLine("- 2. Choose the type of activity        -");
            Console.WriteLine("- 3. Choose the amount of participants  -");
            Console.WriteLine("-----------------------------------------");
            MainScreenFunction();
        }

        private void MainScreenFunction()
        {
            int choosedOption = 0;
            try
            {
                choosedOption = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please, write a correct option, it can only be integer numbers.");
            }

            switch (choosedOption)
            {
                case 1:
                    {
                        RandomRequest randomRequest = new RandomRequest();

                        Activity activity = randomRequest.RequestRandomActivity().Result;

                        Console.WriteLine($"[You can {activity.activity} which can be done by {activity.participants} participants.]");
                        MainScreen();
                    }
                break;

                case 2:
                    {
                        MenuTypeActivity menuTypeActivity = new MenuTypeActivity();
                        menuTypeActivity.TypesActivitiesScreen();

                        MainScreen();
                    }
                break;

                case 3: 
                    {
                        MenuAmountParticipants menuAmountParticipants = new MenuAmountParticipants();
                        menuAmountParticipants.AmountParticipantsScreen();

                        MainScreen();
                    }
                break;

                default:
                    {
                        MainScreen();
                    }
                break;
            }
        }
    }
}
