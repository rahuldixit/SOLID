using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IOrder
    {
        void Purchase();
    }

    public interface IOnlineOrder
    {
        void ProcessCreditCard();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
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
    }
}
