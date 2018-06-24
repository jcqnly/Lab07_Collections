
# Lab07 Collections
Implement a deck of cards using the concepts of generics and collections.

## Dependencies
This application runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab07_Collections
dotnet restore
dotnet run
```
---
## What this application does
This application shows the user a deck of cards.
The deck of cards is comprised of individual cards that were
instantiated from a class called Cards.  Each instantiated cards' values
were determined by 2 sets of enums: suits and face values.
An IEnumerable called Deck was instantiated and filled with objects of type
Card.  This list is then filled with each instantiated card.

Adding a card required instantiating a new card of type Card
with the new enum values.  This card is then passed to the Add
method within the Deck class.

Removing a card required a card to be passed to the remove
method in the Deck class.  The most recently card will be removed.

Shuffling the deck required the entire deck to be sent to the
Shuffle method in the Deck class.  A random number is generated
and it won't exceed the length of the deck.  A temp variable of 
type T is used to store the card that was removed.  The random
card will then replace that removed card.  The removed card is
then placed back into the deck.

The shuffled deck is then displayed.

---

## Screenshot Walk Through
1: View the deck:

![View Deck](/assets/viewTheDeck.png)

2: Add a card to the deck:

![Add Card](/assets/addCard.png)

3: Remove a card from the deck:

![remove Card](/assets/removeCard.png)

4. Shuffle the deck:

![shuffle Deck](/assets/shuffleDeck.png)

---
## Acknowledgements
-Thanks to Earl Jay for walking me through the process of using
the enums when instantiating each card from the Card class.

- Thanks to [jaatay](https://github.com/jaatay) for telling me 
about the remove method and how to account that with the unit tests

- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this awesome README layout.
