using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellProcessing : MonoBehaviour
{
    public Player player;
    public AI ai;
    public Image PlayerSpell;
    public Image AISpell;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      
    //This is a high level method which is supposed to contain the order of operations for
    //resolving the duel
    public void PlayerResolveConflict()
    {
        for (int i = 0; i < player._hand.cardsInHand.Count; i++)
        {
            player._hand.ActivateCard();
            Debug.Log("activated player card");
        }
    }

    public void AIResolvesConflict()
    {
        for (int i = 0; i < ai._hand.cardsInHand.Count; i++)
        {
            ai._hand.ActivateCard();
            Debug.Log("activated ai card");
        }
    }

}
