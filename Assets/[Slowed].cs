using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public partial class UnitEffect
{

    public class Slowed : UnitEffect
    {
        public Slowed(int d) : base(d) { }

        protected override void InternalSetup(bool val)
        {
            if (val)
            {
                GameAction.Move.OnPrompt += SlowEffect;
            } else
            {
                GameAction.Move.OnPrompt -= SlowEffect;
            }
        }

        private void SlowEffect(GameAction.Move.PromptArgs args)
        {
            if (args.MovingUnit != AffectedUnit) return;
            if (args is not GameAction.Move.PromptArgs.Pathed move) return;

            //Rounded Down
            move.Distance /= 2;
            move.MinDistance /= 2;
        }
    }
}
