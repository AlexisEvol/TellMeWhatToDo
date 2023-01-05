using TellMeWhatToDo.DTOs;
using TellMeWhatToDo.Requests;

namespace TellMeWhatToDo.Screens
{
    internal class MenuAmountParticipants
    {
        public void AmountParticipantsScreen()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("- Write the amount of participants      -");
            Console.WriteLine("- between 1 to 5.                       -");
            Console.WriteLine("-----------------------------------------");
            AmountParticipantsScreenFunction();
        }

        private void AmountParticipantsScreenFunction()
        {
            int amountParticipants = 0;
            try
            {
                amountParticipants = int.Parse(Console.ReadLine());

                if (amountParticipants >= 1 && amountParticipants <= 5)
                {
                    ParticipantsRequest participantsRequest = new ParticipantsRequest();

                    Activity activity = participantsRequest.RequestParticipantsActivity(amountParticipants).Result;

                    Console.WriteLine($"[The activity you could do is {activity.activity}]");
                }
                else
                {
                    Console.WriteLine("Please, write a number between 1 to 5.");
                    AmountParticipantsScreen();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please, write a correct amount of participants, it can only be integer numbers.");
                AmountParticipantsScreen();
            }
        }
    }
}
