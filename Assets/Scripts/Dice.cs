using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private int _sides;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private List<Sprite> _faces;

    // Start is called before the first frame update
    void Start()
    {
        _renderer.sprite = _faces[0];
        Debug.Log(_faces[0]);
    }

    public void RollTheDice()
    {
        DeterminValue();
        RenderSpriteFace();      
    }

    void DeterminValue()
    {
        _value = Random.Range(1, _sides);
    }

    void RenderSpriteFace()
    {
        _renderer.sprite = _faces[_value - 1];
    }

}
