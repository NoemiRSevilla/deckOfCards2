using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(string strval, string strsuit, int intval)
        {
            stringVal = strval;
            suit = strsuit;
            val = intval;
        }
    }