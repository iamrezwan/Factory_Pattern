using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class BankC : CardService
    {
        public string IssueDefaultCard()
        {
            return "I am bank C and I provide AMEX card.";
        }
    }
}
