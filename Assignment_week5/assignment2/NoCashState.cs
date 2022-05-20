﻿using System;
namespace assignment2
{
    public class NoCashState : IATMState
    {
        public NoCashState()
        {
        }

        public void EnterPincode()
        {
            throw new NotImplementedException();
        }

        public void InsertCard()
        {
            throw new NotImplementedException();
        }

        public void RejectCard()
        {
            throw new NotImplementedException();
        }

        public void WithdrawCash()
        {
            throw new NotImplementedException();
        }
    }
}
