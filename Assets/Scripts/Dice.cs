using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private int _sides;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RollTheDice()
    {
        _value = Random.Range(1, _sides + 1);
    }

}
