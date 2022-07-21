using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInteractible : MonoBehaviour
{
    public DiceSelection diceSelection;//for knowing the current buying power
    public GameObject card;
    [SerializeField] private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Add the card to the players hand
    public void AddCardToHand()
    {
        if (diceSelection.CombinedSelectedDiceValue >= card.GetComponent<CardGameObject>().cardStats.manaCost)
        {
            _player._hand.AddCardToHand(card);
            foreach (var die in diceSelection.SelectedDice)
            {
                die.Used = true;
                die.DeactivateImage();
            }
            gameObject.SetActive(false);
        }
        else
        {
            //causes the card image to flicker on and off for a half second
            StartCoroutine(Flicker());
        }

    }
    //flicker the card image
    IEnumerator Flicker()
    {
        for (int i = 0; i < 5; i++)
        {
            GetComponent<Image>().enabled = false;
            yield return new WaitForSeconds(0.1f);
            GetComponent<Image>().enabled = true;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
