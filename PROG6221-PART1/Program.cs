using System;
using System.Linq;
using System.Media;
using System.Threading.Tasks;

namespace CybersecurityAiChatBot
{
    class Program
    {
        
            DisplayImage();
            PLayVoiceGreeting();
            
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter Name: " ,60);
            string userName = Console.ReadLine();
            if (userName.Equals(""))
            {
                Console.WriteLine("Please enter a name!");
                
            }
            else
            {

                Print("\nWelcome " + userName + "!");
            }

            UserInteraction(userName);




            static void PLayVoiceGreeting()
            {


                var myPlayer = new SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\contr\source\repos\TestCode\TestCode\ElevenLabs_2025-03-26T15_56_04_George_pre_s50_sb75_se57_b_m2.wav";
                myPlayer.PlaySync();

            }



            static void DisplayImage()
            {

                string logo = "      ───▄█▌─▄─▄─▐█▄\r\n" +
                    "      ───██▌▀▀▄▀▀▐██\r\n" +
                    "      ───██▌─▄▄▄─▐██\r\n" +
               "      ───▀██▌▐█▌▐██▀\r\n" +
                    "      ▄██████─▀─██████▄\r\n";

                    
                  



                Console.WriteLine(logo);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("THE CYBERSECURITY AWARENESS BOT");
               
            }





        static void Main(string[] args)
        {


        }    
    }
}
