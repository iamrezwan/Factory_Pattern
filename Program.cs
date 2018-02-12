using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardServicesFactory cardServicesFactory = new CardServicesFactory();
            CardService forBankA, forBankB, forBankC;
            forBankA = cardServicesFactory.RecogniseBankToProvideService(BankLists.BankA);
            forBankB = cardServicesFactory.RecogniseBankToProvideService(BankLists.BankB);
            forBankC = cardServicesFactory.RecogniseBankToProvideService(BankLists.BankC);

            Console.WriteLine("--Let's see which card Bank A is generating below");
            Console.WriteLine(forBankA.IssueDefaultCard());
            Console.WriteLine("");
            Console.WriteLine("--Let's see which card Bank B is generating below");
            Console.WriteLine(forBankB.IssueDefaultCard());
            Console.WriteLine("");
            Console.WriteLine("--Let's see which card Bank C is generating below");
            Console.WriteLine(forBankC.IssueDefaultCard());
            Console.ReadLine();
        }
    }
}
