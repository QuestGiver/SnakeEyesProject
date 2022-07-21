using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardShop : MonoBehaviour
{
    public List<GameObject> AllCardPrefabs;
    public List<GameObject> AvailibleCardPrefabs;

    //UI lists
    [SerializeField] private List<CardInteractible> _cardInteractibles;
    [SerializeField] private List<Image> _cardImages;
    [SerializeField] private List<Text> _cardNames;
    [SerializeField] private List<Text> _cardInfo;
    [SerializeField] private List<Text> _cardCosts;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateCardShop()
    {
        AvailibleCardPrefabs.Clear();
        foreach (var artslot in _cardImages)
        {
            AvailibleCardPrefabs.Add(AllCardPrefabs[Random.Range(0, AllCardPrefabs.Count)]);
        }
        SetCards();
    }

    public void SetCards()
    {
        for (int i = 0; i < AvailibleCardPrefabs.Count; i++)
        {     
            _cardImages[i].sprite = AvailibleCardPrefabs[i].GetComponent<CardGameObject>().cardStats.cardArt;
            _cardNames[i].text = AvailibleCardPrefabs[i].GetComponent<CardGameObject>().cardStats.cardName;
            _cardInfo[i].text = AvailibleCardPrefabs[i].GetComponent<CardGameObject>().cardStats.CardInfo();
            _cardCosts[i].text = AvailibleCardPrefabs[i].GetComponent<CardGameObject>().cardStats.manaCost.ToString();
            _cardInteractibles[i].card = AvailibleCardPrefabs[i];          
        }
    }
    
}
