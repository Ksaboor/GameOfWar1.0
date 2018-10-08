using System.Collections.Generic;

namespace GameOfWar1._0
{
    public class Player
    {
        /** Will have two properties 
         * 1. name
         * 2. A Collection of Cards
         *     Queue  FIFO 
         */
        
        public string name { get; set; }
        public Queue<Card> Deck { get; set; }
    }
}