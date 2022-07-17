using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : ReactionTest, IGamePhases
{
    [SerializeField] private CardHolder _hand;
    [SerializeField] private List<Dice> _dices = new List<Dice>();
    [SerializeField] private float _constantCastingDelay;
    [SerializeField] private float _randomDelayFloor;
    [SerializeField] private float _randomDelayCeiling;
    [SerializeField] private Health _health;

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
        if (_startTest)
        {
            //count down from timeToTrigger
            _TimeUntilTrigger -= Time.deltaTime;
            if (_TimeUntilTrigger <= 0)//if time to trigger is zero, get players reaction time
            {
                _trigger = true;
                if (_timeSinceTriggered >= (_constantCastingDelay + Random.Range(_randomDelayFloor, _randomDelayCeiling)))
                {
                    _playerReactionTime = _timeSinceTriggered;
                }
                _timeSinceTriggered += Time.deltaTime;
            }

        }
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
        throw new System.NotImplementedException();
    }

    public void ReactionPhase()
    {
        throw new System.NotImplementedException();
    }
}
