using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    List<Card> cardsInHand = new List<Card>();
    List<Card> activeDefensiveCards = new List<Card>();

    public void AddCardToHand(Card newCard)
    {
        cardsInHand.Add(newCard);
    }

    public void ActivateDefensiveCard(Card newDefenseCard)
    {
        activeDefensiveCards.Add(newDefenseCard);
    }

    public void ActivateCard()
    {
        cardsInHand[1].Use();

        cardsInHand.RemoveAt(1);
    }
}
