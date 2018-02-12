using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class CardServicesFactory
    {
        public CardService RecogniseBankToProvideService(BankLists _bank)
        {
            if (_bank ==  BankLists.BankA)
            {
                return new BankA();
            }
            else if (_bank == BankLists.BankB)
            {
                return new BankB();
            }
            else if (_bank == BankLists.BankC)
            {
                return new BankC();
            }
           
            return null;
          
           
        }
    }
}
