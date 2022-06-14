using System;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float timeToSwitch = 0f;
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        stateMachine.InputReader.JumpEvent += OnJump; 
    }

    public override void Tick(float deltaTime)
    {
        timeToSwitch += deltaTime;
        Debug.Log(timeToSwitch);
    }

    public override void Exit()
    {
        stateMachine.InputReader.JumpEvent -= OnJump;
    }

    private void OnJump()
    {
        stateMachine.SwitchState(new PlayerTestState(stateMachine));
    }
}