using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    public int manaCost;

    public int attacksBlocked; // how many hits we block
    public int damageBlocked; // how much damag we block from each attack

    public int amountOfAttacks; // how many times we hit
    public int damagePerAttack; // how much damage each hit does
    public int armorPiercingDamage; // how much damage from each attack ignores armor

    public abstract void Use(CardHolder user, CardHolder opponent);
}
