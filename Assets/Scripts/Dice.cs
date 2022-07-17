using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private int _sides;
    [SerializeField] private Image _renderer;
    [SerializeField] private List<Sprite> _faces;
    [SerializeField] private float _rollDuration = 0.5f;
    [SerializeField] private bool _isRolling = false;
    [SerializeField] private float _rollStutterDuration = 0.05f;
    bool _isRollingStutter = false;
    float _rollDurationTimer = 0;
    float _rollStutterDurationTimer = 0;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        _renderer.sprite = _faces[0];
        Debug.Log(_faces[0]);
    }

    private void Update()
    {

        if (_isRolling)
        {
            _rollDurationTimer += Time.deltaTime;
            _rollStutterDurationTimer += Time.deltaTime;

            
            if (_rollStutterDurationTimer >= _rollStutterDuration)
            {
                _isRollingStutter = !_isRollingStutter;
                _rollStutterDurationTimer = 0;
                if ((i + 1) > _faces.Count)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
                
                if (i < _faces.Count)
                {
                    _renderer.sprite = _faces[i];
                }
                else
                {
                    _renderer.sprite = _faces[0];
                }


            }

            if (_rollDurationTimer >= _rollDuration)
            {
                if (_rollDurationTimer! >= _rollDuration)
                {
                    _isRolling = false;
                }
                _isRolling = false;
                _rollDurationTimer = 0;
                _rollStutterDurationTimer = 0;
                DeterminValue();
                RenderSpriteFace();
            }
        }
    }

    public void RollTheDice()
    {
        _isRolling = true;
        Random.InitState(System.DateTime.Now.Millisecond);
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
