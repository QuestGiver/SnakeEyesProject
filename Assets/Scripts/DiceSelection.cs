using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSelection : MonoBehaviour
{
    public List<Dice> SelectedDice = new List<Dice>();
    public int CombinedSelectedDiceValue;
    // Start is called before the first frame update
    void Start()
    {
        SelectedDice.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateTotalValue();
    }

    void CalculateTotalValue()
    {
        CombinedSelectedDiceValue = 0;
        foreach (Dice dice in SelectedDice)
        {
            if(!dice.Used)
                CombinedSelectedDiceValue += dice.Value;
        }
    }

    public void AddSelectedDice(Dice _dice)
    {
        if(!SelectedDice.Contains(_dice))
        SelectedDice.Add(_dice);

    }
    
    public void RemoveSelectedDice(Dice _dice)
    {
        if (SelectedDice.Contains(_dice))
            SelectedDice.Remove(_dice);
    }


}
