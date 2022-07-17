using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : ReactionTest, IGamePhases
{
    [SerializeField] public CardHolder _hand;
    [SerializeField] private List<Dice> _dices = new List<Dice>();
    [SerializeField] private Image _visualIndicator;
    [SerializeField] private List<Sprite> _faces = new List<Sprite>();
    [SerializeField] private Health _health;
    
    // Start is called before the first frame update
    void Start()
    {
        _visualIndicator.sprite = _faces[0];  
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
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _playerReactionTime = _timeSinceTriggered;
                }
                _visualIndicator.sprite = _faces[1];
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
        
    }

    public void ReactionPhase()
    {
        throw new System.NotImplementedException();
    }
}
