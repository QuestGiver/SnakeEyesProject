using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ReactionTest : MonoBehaviour
{
    [SerializeField] protected bool _startTest;
    [SerializeField] public bool _trigger;
    [SerializeField] public float _playerReactionTime;
    [SerializeField] protected float _timeSinceTriggered;
    [SerializeField] protected float _TimeUntilTrigger = 10;
    [SerializeField] protected SpriteRenderer _visualIndicator;
    [SerializeField] protected List<Sprite> _faces = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        _visualIndicator.sprite = _faces[0];
        _timeSinceTriggered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ReactionLogic();
    }

    public virtual void ReactionLogic()
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

    public void StartTheTest()
    {
        _startTest = true;
    }
}
