﻿namespace Core.Runtime.StateMachine
{
    public abstract class PlayerBaseState : State
    {
        protected PlayerStateMachine _stateMachine;
        
        public override void Enter()
        {
            throw new System.NotImplementedException();
        }

        public override void Tick(float deltaTime)
        {
            throw new System.NotImplementedException();
        }

        public override void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}