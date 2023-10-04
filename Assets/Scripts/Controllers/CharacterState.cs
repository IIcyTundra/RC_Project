using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState
{
    protected CharacterController m_Character;
    protected CharacterStateMachine m_StateMachine;
    
    public CharacterState(CharacterController _character, CharacterStateMachine _stateMachine)
    {
        this.m_Character = _character;
        this.m_StateMachine = _stateMachine;
    }
    
    public virtual void EnterState() {}
    
    public virtual void ExitState() {}
    public virtual void FrameUpdate() {}
    public virtual void PhysicsUpdate() {}
    public virtual void AnimationTriggerEvent() {}
    
}
