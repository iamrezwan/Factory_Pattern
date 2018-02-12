using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class BankB : CardService
    {
        public string IssueDefaultCard()
        {
            return "I am bank B and I provide Master card.";
        }
    }
}
