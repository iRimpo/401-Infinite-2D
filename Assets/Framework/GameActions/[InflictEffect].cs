using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class GameAction
{

    /// <summary>
    /// [ : ] <see cref="GameAction"/>
    /// </summary>
    public class InflictEffect : GameAction
    {
        public UnitEffect Effect { get; private set; }
        /// <summary>
        /// Occurs when any <see cref="InflictEffect"/> is created.
        /// </summary>
        /// <remarks><inheritdoc cref="__DOC__ExternalResultantEvent"/></remarks>
        public static event GameActionEventHandler<InflictEffect> ExternalResultantEvent;
        protected override void InternalPerform()
        {
            Effect.SetActive(true);
        }

        protected override void InternalUndo()
        {
            Effect.SetActive(false);
        }

        public InflictEffect(Player performer, UnitEffect inflictedUnit) : base(performer)
        {
            Effect = inflictedUnit;
            ExternalResultantEvent?.Invoke(this);
        }
    }


}