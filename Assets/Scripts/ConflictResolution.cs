using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ConflictResolution : MonoBehaviour
{
    public static int totalCardsInPlay;

    void Start()
    {
        totalCardsInPlay = 0;  
    }
    
    
    private Queue<CardGameObject> executionOrder = new Queue<CardGameObject>();

    // Update is called once per frame
    void Update()
    {
        
    }

    //ConflictResolution state machine
    public void DisplayCardUsage()
    {
        
    }

    //Add a CardGameObject to executionOrder
    public void AddToExecutionOrder(CardGameObject card)
    {
        //do not add card if it is already in Queue
        if (executionOrder.Contains(card))
        {
            return;
        }
        
        executionOrder.Enqueue(card);
    }

    public bool ExecutionOrderEmpty()
    {
        return executionOrder.Count == 0;
    }

}
