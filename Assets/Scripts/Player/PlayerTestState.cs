using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float timeToSwitch = Mathf.Infinity;
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Enter");
        timeToSwitch = 10f;
    }

    public override void Tick(float deltaTime)
    {
        timeToSwitch -= deltaTime;
        Debug.Log("Time to Switch " + timeToSwitch);

        if (timeToSwitch <= 0f) {
            stateMachine.SwitchState(new PlayerTestState(stateMachine));
        }
    }

    public override void Exit()
    {
        Debug.Log("Exit");
    }
}