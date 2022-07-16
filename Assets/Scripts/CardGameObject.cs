using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameObject : MonoBehaviour
{ 
    // will hold all the information of an individual card and allow us to save them to a list in the card holder script


    [SerializeField] Card cardStats;
    public int attacksBlocked = 0;
    public int damageBlocked = 0;

    private void Start()
    {
        if(cardStats.attacksBlocked != 0)
        {
            attacksBlocked = cardStats.attacksBlocked;
            damageBlocked = cardStats.damageBlocked;
        }
    }
}
