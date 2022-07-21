using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ReactionTest : MonoBehaviour
{
    [SerializeField] public bool _startTest;
    [SerializeField] public bool _trigger;
    [SerializeField] public float _ReactionTime;
    [SerializeField] protected float _timeSinceTriggered;
    [SerializeField] protected float _TimeUntilTrigger = 10;

    // Start is called before the first frame update
    void Start()
    {
        _timeSinceTriggered = 0;
    }

    public abstract void ReactionLogic();

    public void StartTheTest()
    {
        _startTest = true;
    }
}
