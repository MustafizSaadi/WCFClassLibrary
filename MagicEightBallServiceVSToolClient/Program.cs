using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceVSToolClient.ServiceReference1;

namespace MagicEightBallServiceVSToolClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Ask the Magic 8 Ball *****\n");
            using (EightBallClient ball = new EightBallClient("NetTcpBinding_IEightBall"))
            {
                //"BasicHttpBinding_IEightBall" -> This can also be used
                Console.Write("Your question: ");
                string question = Console.ReadLine();
                string answer =
                ball.ObtainAnswerToQuestion(question);
                Console.WriteLine("8-Ball says: {0}", answer);
            }
            Console.ReadLine();
        }
    }
}
