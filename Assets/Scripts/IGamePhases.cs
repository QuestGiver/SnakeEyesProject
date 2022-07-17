using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGamePhases
{
    public void DicePhase();
    public void CardPhase();
    public void ReactionPhase();
}
