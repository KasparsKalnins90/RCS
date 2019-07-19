using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BlackJackConsole
{
     class Game
    {
        public Player Player;
        public Player Dealer;
        public List<Card> Deck;

        public string[] Suits = new[] { "H", "D", "S", "C" };
        public string[] Values = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
         

        public Game()
        {
            Player = new Player();
            Dealer = new Player();
            Deck = new List<Card>();
        }
        public void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public void NewGame()
        {
            Deck = new List<Card>();
            foreach (string s in Suits)
            {
                foreach (string v in Values)
                {
                    Deck.Add(new Card()
                    {
                        Suit = s,
                        Value = v
                    });
                }
            }

            // sajaukt vērtības
            // ņemt pirmo kārti un dalīt spēlētājam
            // noņemt kārti no lista
            Shuffle(Deck);
            Card card = Deck[0];
            Deck.RemoveAt(0);
            Player.Hand.Add(card);

           
            
        }
    }
}
