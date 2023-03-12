using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBallServiceClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            EightBallClient eightBallClient = new EightBallClient();
            Console.WriteLine(eightBallClient.ObtainAnswerToQuestion("What should I do now?"));
        }
    }
}
