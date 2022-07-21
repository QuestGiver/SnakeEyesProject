using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceInteractible : MonoBehaviour
{
    [SerializeField] RectTransform diceRectTransform;
    [SerializeField] Dice _dice;
    [SerializeField] DiceSelection _diceSelection;
    [SerializeField] private bool _submitted = false;

    //adds the dice to the dice selection
    public void SubmitDice()
    {
        if (!_submitted)
        {
            _submitted = true;
            _diceSelection.AddSelectedDice(_dice);
            DecreaseSize();
        }
        else
        {
            _submitted = false;
            _diceSelection.RemoveSelectedDice(_dice);
            IncreaseSize();
        }
    }

    private void DecreaseSize()
    {
        diceRectTransform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void IncreaseSize()
    {
        diceRectTransform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

}
