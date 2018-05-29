using System;

namespace DevChatter.Bot.Core.Games.Mud.FSM.MenuStates
{
    internal class ControlOptionState : State
    {
        public ControlOptionState(string name) : base(name)
        {
        }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("Control options:");
            Console.WriteLine("You type...");
        }

        public override void Exit()
        {
        }

        public override bool Run()
        {
            bool run = true;

            Menu m = new Menu(new string[] { "Back" });
            var k = m.PrintMenuInt();
            switch (k)
            {
                case 0:
                    StateMachine.MenuInstance.RemoveState();
                    break;

                default:
                    break;
            }
            return run;
        }
    }
}