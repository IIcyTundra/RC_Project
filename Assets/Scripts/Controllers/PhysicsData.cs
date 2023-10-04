using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PhysicsData
{
    [Header("Walking")] 
    public float WalkSpeed = 4;
    public float Acceleration = 2;
    public float CurrentMoveLerpSpeed = 100;
    
    [Header("Detection")] 
    public LayerMask GroundMAsk;
    public float GroundOffset = -1, GroundRadius = 0.2f;
    public float WallCheckOffset = 0.5f, WallCheckRadius = 0.05f;
    
    [Header("Jumping")] 
    public float JumpForce = 15;
    public float FallMultiplier = 7;
    public float JumpVelocityFallOff = 8;
    public Transform JumpLaunchProof;
    public float WalkkJumpLock = 0.25f;
    public float WallMoveJumpLerp = 5;
    public float CoyoteTime = 0.2f;
    public bool EnableDoubleJump = true;
    
    [Header("Wall Slide")]
    [SerializeField] float SlideSpeed = 1;
    
    
    [Header("Dash")] 
    public float DashSpeed = 15;
    public float DashLength = 1;
    public Transform DashRing;

}