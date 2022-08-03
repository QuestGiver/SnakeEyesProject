using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : ReactionTest, IGamePhases
{
    public List<GameObject> AllCardPrefabs;
    [SerializeField] public CardHolder _hand;
    [SerializeField] private float _constantCastingDelay;
    [SerializeField] private float _randomDelayFloor;
    [SerializeField] private float _randomDelayCeiling;
    [SerializeField] private Health _health;
    [SerializeField] private List<Dice> _dices = new List<Dice>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in _dices)
        {
            item.ForAIUse = true;
        }
        CardPhase();
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
            if (_TimeUntilTrigger <= 0)
            {
                _trigger = true;
                if (_timeSinceTriggered >= (_constantCastingDelay + Random.Range(_randomDelayFloor, _randomDelayCeiling)))
                {
                    _ReactionTime = _timeSinceTriggered;
                }
                _timeSinceTriggered += Time.deltaTime;
            }

        }
    }

    public void DicePhase()
    {

    }

    public void CardPhase()
    {
        if (AllCardPrefabs.Count == 0)
        {
            Debug.LogWarning("AI has no card prefabs");
        }
        for (int i = 0; i < 3; i++)
        {
            //Currently just simulate rolling the dice and buying a card, but it is NOT an accurate one
            _hand.AddCardToHand(AllCardPrefabs[Random.Range(0, AllCardPrefabs.Count)]);
            if ((_hand.cardsInHand[i].GetComponent<CardGameObject>().cardStats.manaCost > 6) && ((i + 1) !> 3))
            {
                i++;
            }
        }
    }

    public void ReactionPhase()
    {
        ReactionLogic();
    }
}
