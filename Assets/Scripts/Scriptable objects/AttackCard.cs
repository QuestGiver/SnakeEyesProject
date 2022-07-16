using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "attackCard")]
public class AttackCard : Card
{
    public int amountOfAttacks; // how many times we hit
    public int damagePerAttack; // how much damage each hit does
    public int armorPiercingDamage; // how much damage from each attack ignores armor

    public override void Use()
    {

    }
}
