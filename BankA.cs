using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class BankA : CardService
    {
        public string IssueDefaultCard()
        {
            return "I am bank A and I provide VISA card.";
        }
    }
}
