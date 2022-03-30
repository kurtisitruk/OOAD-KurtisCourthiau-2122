using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaartspel1
{
    class Deck
    {
        private Kaart[] deck;
        private int NeemKaart;
        private const int Aantal_Kaarten = 52;
        private Random rnd_nummer;



        public Deck()
        {

            string[] Kleur = { "Harten", "Schoppen", "Ruiten", "Klaveren" };
            deck = new Kaart[Aantal_Kaarten];
            NeemKaart = 0;
            rnd_nummer = new Random();

            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Kaart(Nummer(ToString)[count % 11], Kleur[count / 13]);
        }

        public void Mengen()
        {
            NeemKaart = 0;

            for (int first = 0; first < deck.Length; first++)
            {
                int second = rnd_nummer.Next(Aantal_Kaarten);
                Kaart temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Kaart Dealkaart()
        {
            if (NeemKaart < deck.Length)
                return deck[NeemKaart++];
            else
                return null;
        }
    }
}
