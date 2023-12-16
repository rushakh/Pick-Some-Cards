using System.Net.Http.Headers;
using System;

namespace PickSomeCardsUI
{
    public class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards) 
        {
            string[] pickedCards = new string [numberOfCards];
            for (int i = 0; i< numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }
        private static string RandomSuit()
        {
            string[] suits = {"Spades", "Diamonds", "Hearts", "Clubs" };
            int value = random.Next(1, 5);
            switch (value)
            {
                case 1: return "Spades";
                        break;
                case 2: return "Diamonds";
                        break;
                case 3: return "Hearts";
                        break;
                case 4: return "Clubs";
                        break;
            }
            return value.ToString();
        }
        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            switch (value)
            {
                case 1: return "Ace";
                    break;
                case 11: return "Jack";
                    break;
                case 12: return "Queen";
                    break;
                case 13: return "King";
                    break;
            }
            return value.ToString();
            
        }
    }
    
}