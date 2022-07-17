using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ReactionTest, IGamePhases
{
    [SerializeField] private CardHolder _hand;
    [SerializeField] private List<Dice> _dices = new List<Dice>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ReactionLogic()
    {
        base.ReactionLogic();
    }

    public void DicePhase()
    {
        foreach (Dice dice in _dices)
        {
            dice.RollTheDice();
        }
    }

    public void CardPhase()
    {
        
    }

    public void ReactionPhase()
    {
        throw new System.NotImplementedException();
    }
}
