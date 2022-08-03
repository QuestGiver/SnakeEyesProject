using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]int maxHp = 5;
    [SerializeField]int curHp;
    CardHolder myCardHolder;

    private void Start()
    {
        curHp = maxHp;
        myCardHolder = GetComponent<CardHolder>();
    }

    public void TakeDamage(AttackCard attacker)
    {
        int actualDamage = 0;
        int actualArmorValue = 0;

        for (int i = 0; i < attacker.amountOfAttacks; i++)
        {
            if(myCardHolder.activeDefensiveCards.Count != 0)
            {
                CardGameObject currentDefenseCard = myCardHolder.activeDefensiveCards[1].GetComponent<CardGameObject>();

                if (currentDefenseCard.attacksBlocked != 0)
                {
                    // calculate our armor if necessary
                    if(currentDefenseCard.damageBlocked - attacker.armorPiercingDamage < 0)
                    {
                        actualArmorValue = 0;
                    }
                    else
                    {
                        actualArmorValue = currentDefenseCard.damageBlocked - attacker.armorPiercingDamage;
                    }
                    
                    // subtract one block from our defense card and discard it if necessary
                    currentDefenseCard.attacksBlocked -= 1;
                    if(currentDefenseCard.attacksBlocked <= 0)
                    {
                        myCardHolder.RemoveDefenseCard();
                    }
                }
            }

            // calculate the damage
            actualDamage = attacker.damagePerAttack - actualArmorValue;
            curHp -= actualDamage;
            Debug.Log(actualDamage);

        }
    }
}
