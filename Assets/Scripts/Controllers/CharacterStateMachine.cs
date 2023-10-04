using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    public CharacterState CurrentState { get; set; }

    public void Initialize(CharacterState startState)
    {
        CurrentState = startState;
        CurrentState.EnterState();
    }

    public void ChangeState(CharacterState newState)
    {
        CurrentState.ExitState();
        CurrentState = newState;
        CurrentState.EnterState();
    }
}
