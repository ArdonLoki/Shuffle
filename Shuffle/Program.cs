
// use https://www.jdoodle.com/compile-c-sharp-online

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public char[] suit = new[] { 'H', 'C', 'D', 'S' }; // Heart, Clubs, Diamond, Spades
        static public char[] cards = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'J', 'Q', 'K' }; // 1,2,....Queen, King

        static void Main(string[] args)
        {

            // Will contain cards as an array of numbers+letters  (1,2,...JACK,QUEEN,KING) (Heart, Clubs, Diamond, Spades): {1,H,2,H,3,H,....,Q,S,K,S}
            // DO NOT CHANGE TO A LIST
            char[] deckOfCard = new char[104];

            // Initialise the Deck to valid cards
            InitialiseDeck(deckOfCard);
            Console.WriteLine("Init Done");
            PrintDeck(deckOfCard);

            //number of the card you want
            Console.WriteLine("Enter the number of the card");
            
            int cardNumb = Convert.ToInt32(Console.ReadLine());
            int resCardNumb = indexPosition(cardNumb);

            Console.WriteLine(deckOfCard[resCardNumb]);
            Console.WriteLine(deckOfCard[resCardNumb+1]);

            // Suffle the cards in the deck
            /*ShuffleDeck(deckOfCard);
            Console.WriteLine("After Shuffle");
            PrintDeck(deckOfCard);*/




            /*Current output */
            //Init Done
            //11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,
            //After Shuffle
            //11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,HH,

            //Console.ReadLine();
        }

        /// <summary>
        /// Create a fully intialiezed deck ready to be used
        /// </summary>
        /// <param name="theDeck"></param>
        static void InitialiseDeck(char[] theDeck)
        {
            int k = 0;
            // TODO write proper code that will initialise the deck with all cards
            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                theDeck[k++] = cards[j];
                theDeck[k++] = suit[i];
                }
            }
        }

        static int indexPosition(int cardNumb) 
        {
            int resCardNumb = (cardNumb - 1) * 2;
            return resCardNumb;
        }

        /// <summary>
        /// Swap two cards in the deck
        /// </summary>
        /// <param name="theDeck">The deck of card</param>
        /// <param name="card1">position of card number 1, min 0 max 51</param>
        /// <param name="card2">position of card number 2, min 0 max 51</param>
        static void swapCard(char[] theDeck, int card1, int card2)
        {

        }

        /// <summary>
        /// Will shuffle a deck of card making sure the order is random
        /// </summary>
        /// <param name="theDeck"></param>
        static void ShuffleDeck(char[] theDeck)
        {
            // TODO write the shuffling algo
            swapCard(theDeck, 0, 10);
        }

        /// <summary>
        /// Print Out a Deck
        /// </summary>        
        static void PrintDeck(char[] theDeck)
        {
            for (int i = 0; i < 52; i++)
            {
                Console.Write(theDeck[2 * i].ToString() + theDeck[2 * i + 1].ToString() + ",");
            }
            Console.WriteLine();
        }
    }
}
