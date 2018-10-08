namespace GameOfWar1._0
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
    public class Card
    {
        public string DiplayName { get; set; }
        public Suit suit { get; set; }
        public int Value { get; set; }
        
        
    }
}