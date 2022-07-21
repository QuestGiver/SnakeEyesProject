using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProcessSpells : MonoBehaviour
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

    public void ResolveConflict(float _reactionTime)
    {


    }
    
    float CalculateReactionSpeedBonus(float _reactionTime)
    {
        //returns a value between 1 and zero that is higher the closer the reaction time is to 0
        return 1 - Mathf.Clamp01(_reactionTime / ReactionBonusTolerance);
    }

}
