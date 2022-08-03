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
    public float ReactionBonusTolerance = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      
    //This is a high level method which is supposed to contain the order of operations for:
    //resolving the duel and ticking the right triggers for animation, sounds, and effects.
    //This function should only be triggered by player commands and this should be invisible to AI. Hopefully.
    public void ResolveConflict(float _reactionTime)
    {
        for (int i = 0; i < Mathf.Max(player._hand.cardsInHand.Count, ai._hand.cardsInHand.Count); i++)
        {
            //if both the player and ai have a non-null card during the current iteration execute logic
            if (ai._hand.cardsInHand[i] != null && player._hand.cardsInHand[i] != null)      
            {
                ai._hand.ActivateCard();
                player._hand.ActivateCard();
            }
            else if ((ai._hand.cardsInHand[i] != null))
            {
                ai._hand.ActivateCard();
            }
            else if ((player._hand.cardsInHand[i] != null))
            {
                player._hand.ActivateCard();
            }
            
        }
    }
    
    float CalculateReactionSpeedBonus(float _reactionTime)
    {
        //returns a value between 1 and zero that is higher the closer the reaction time is to 0
        return 1 - Mathf.Clamp01(_reactionTime / ReactionBonusTolerance);
    }

}
