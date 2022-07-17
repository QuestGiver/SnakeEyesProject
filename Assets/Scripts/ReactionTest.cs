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

    // Start is called before the first frame update
    void Start()
    {
        _timeSinceTriggered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ReactionLogic();
    }

    public abstract void ReactionLogic();

    public void StartTheTest()
    {
        _startTest = true;
    }
}
