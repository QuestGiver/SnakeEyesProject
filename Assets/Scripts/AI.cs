using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : ReactionTest
{
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
                if (_timeSinceTriggered >= (0.400f + Random.Range(-0.100f, 100f)))
                {
                    _playerReactionTime = _timeSinceTriggered;
                }
                _visualIndicator.sprite = _faces[1];
                _timeSinceTriggered += Time.deltaTime;
            }

        }
    }
}
