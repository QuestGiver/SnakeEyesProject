using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "attackCard")]
public class AttackCard : Card
{
    public override void Use(CardHolder user, CardHolder opponent)
    {
        opponent.GetComponent<Health>().TakeDamage(this);
    }
}
