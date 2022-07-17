using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Card : ScriptableObject
{
    public string cardName;
    public int manaCost;
    public CardType cardType;
    public Sprite cardArt;

    public int attacksBlocked; // how many hits we block
    public int damageBlocked; // how much damag we block from each attack

    public int amountOfAttacks; // how many times we hit
    public int damagePerAttack; // how much damage each hit does
    public int armorPiercingDamage; // how much damage from each attack ignores armor

    public string CardInfo()
    {
        return 
            amountOfAttacks + " attacks, " +
            damagePerAttack + " damage per attack. " +
            attacksBlocked + " attacks blocked, " +
            damageBlocked + " damage blocked. " +
            armorPiercingDamage + " armor piercing damage.";
    }

    public abstract void Use(CardHolder user, CardHolder opponent);
}

public enum CardType
{
    Attack,
    Defense
}
