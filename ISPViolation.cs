﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IOrder
    {
        void Purchase();
        void ProcessCreditCard();
    }

    public class OnlineOrder : IOrder
    {
        public void Purchase()
        {
            //Do purchase
        }

        public void ProcessCreditCard()
        {
            //process through credit card
        }
    }

    public class InpersionOrder : IOrder
    {
        public void Purchase()
        {
            //Do purchase
        }

        public void ProcessCreditCard()
        {
            //Not required for inperson purchase
            throw new NotImplementedException();
        }
    }
}
