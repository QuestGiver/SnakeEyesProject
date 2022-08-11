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
    public ConflictResolution conflictResolution;


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
            conflictResolution.AddToExecutionOrder(player._hand.ActivateCard());
            Debug.Log("activated player card");
        }
        CheckForSpentHands();
    }

    public void AIResolvesConflict()
    {
        for (int i = 0; i < ai._hand.cardsInHand.Count; i++)
        {
            conflictResolution.AddToExecutionOrder(ai._hand.ActivateCard());
            Debug.Log("activated ai card");
        }
        CheckForSpentHands();
    }

    void CheckForSpentHands()
    {
        //if both the Ai and Player hands are empty and the ExecutionOrder is not empty, activate DisplayCardUsage()
        if (player._hand.cardsInHand.Count == 0 && ai._hand.cardsInHand.Count == 0)
        {
            if (!conflictResolution.ExecutionOrderEmpty())
            {
                conflictResolution.DisplayCardUsage();
            }
        }
    }


}
