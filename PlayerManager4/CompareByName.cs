using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    public class CompareByName: IComparer<Player>
    {
        private bool ascending;
        public CompareByName(bool order)
        {
            this.ascending = order;
        }

        public int Compare(Player playerOne, Player playerTwo)
        {
            if(ascending)
            {
                return string.Compare(playerOne.Name, playerTwo.Name);
            }
            else
            {
                return -(string.Compare(playerOne.Name, playerTwo.Name));
            }
        }
    }
}