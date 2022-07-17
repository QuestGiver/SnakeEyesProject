using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInteractible : MonoBehaviour
{
    public GameObject card;
    [SerializeField] private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Add the card to the players hand
    public void AddCardToHand()
    {
        _player._hand.AddCardToHand(card);
    }
}
