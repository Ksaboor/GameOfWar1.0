# Objective
    Provide a set of code on how you would design a
    detail version of the classic card game of war
    
# War
    
* Each player gets half a shuffled deck of cards
* Aces are higher than Kings
* Players flip one card at a time, highest card wins
* If flipped cards are same value, a War is declared
* War is played until a player wins all cards on table
* The first player to run out of cards loses.  
    
## Objects needed for the game
* Card
* Deck
* Player 
* Game (Also known as Program.cs)
 
![A playing card](A-spade.png?raw=true)
    
    FaceName: Ace of Spade
    FaceValue: =14
    Suit: ♠
    CardImg: Unicode ♠
   
# Card
    Created an Enum of Suits,
    A String call "Displayname",
    and a value for each card.
    
# Player
    I created a string call name 
    and and a queue of Decks.
# Game

# Deck
    When creating a deck class.
    I decided to create a queue to represent
    a structre of a deck playing cards.
    
    To get the full implementation of playing
    cards we   