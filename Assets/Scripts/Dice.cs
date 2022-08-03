using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField] public bool Used;
    [SerializeField] public int Value;
    [SerializeField] private int _sides;
    [SerializeField] private Image _renderer;
    [SerializeField] private List<Sprite> _faces;
    [SerializeField] private float _rollDuration = 0.5f;
    [SerializeField] private bool _isRolling = false;
    [SerializeField] private float _rollStutterDuration = 0.05f;
    [HideInInspector] public bool ForAIUse;
    bool _isRollingStutter = false;
    float _rollDurationTimer = 0;
    float _rollStutterDurationTimer = 0;
    int i = 0;

    public Dice()
    {
        Used = false;
        Value = 0;
        _sides = 6;
        _faces = new List<Sprite>();
        _rollDuration = 0.5f;
        _isRolling = false;
        _rollStutterDuration = 0.05f;
        _isRollingStutter = false;
        _rollDurationTimer = 0;
        _rollStutterDurationTimer = 0;
        i = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        _renderer.enabled = true;
        Used = false;
        _renderer.sprite = _faces[0];
        Debug.Log(_faces[0]);
    }

    private void Update()
    {//replace with a state machine. In fact, replace the entire UI system with a state machine. This really should not be in the Dice script.
        

        if (_isRolling)
        {
            if (!ForAIUse)
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
            else
            {
                DeterminValue();
                _isRolling = false;
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
        Value = Random.Range(1, _sides);
        if (Value == 1)//re-roll once if the value is shit. Bad luck protection for everybody.
        {
            Value = Random.Range(1, _sides);
        }
    }

    void RenderSpriteFace()
    {
        _renderer.sprite = _faces[Value - 1];
    }

    public void DeactivateImage()
    {
        _renderer.enabled = false;
    }

}
