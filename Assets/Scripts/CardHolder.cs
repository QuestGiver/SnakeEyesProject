using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    // simulate's the player's hand and also keeps track of defense cards played.


    

    public List<GameObject> cardsInHand = new List<GameObject>();
    public List<GameObject> activeDefensiveCards = new List<GameObject>();

    [SerializeField] CardHolder opponent;

    // Adding cards to the player's hand or using them
    public void AddCardToHand(GameObject newCard)
    {
        cardsInHand.Add(newCard);
        if (cardsInHand.Count != 0)
        {
            ConflictResolution.totalCardsInPlay++;
        }

    }
    
    public CardGameObject ActivateCard()
    {
        CardGameObject temp = cardsInHand[0].GetComponent<CardGameObject>();

        temp.cardStats.Use(this, opponent);

        cardsInHand.RemoveAt(0);

        return temp;
    }

    // defense cards
    public void ActivateDefensiveCard(GameObject newDefenseCard)
    {
        activeDefensiveCards.Add(newDefenseCard);
    }

    public void RemoveDefenseCard()
    {
        activeDefensiveCards.RemoveAt(0);
    }
}
