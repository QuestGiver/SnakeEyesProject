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
            _cardCosts[i].text = AvailibleCardPrefabs[i].GetComponent<CardGameObject>().cardStats.ToString();
            _cardInteractibles[i].card = AvailibleCardPrefabs[i];          
        }
    }


    public void SetCardImage(int index, Sprite sprite)
    {
        _cardImages[index].sprite = sprite;
    }

    public void SetCardName(int index, string name)
    {
        _cardNames[index].text = name;
    }

    public void SetCardInfo(int index, string info)
    {
        _cardInfo[index].text = info;
    }

    
}
