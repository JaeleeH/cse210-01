//Jaelee

using System.Collections.Generic;
using cycle.Game.Casting;
using cycle.Game.Services;


namespace cycle.Game.Scripting
{
    /// An update action that moves all the actors.
    /// The responsibility of MoveActorsAction is to move all the actors.
    public class MoveActorsAction : Action
    {
        /// Constructs a new instance of MoveActorsAction.
        public MoveActorsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            foreach (Actor actor in actors)
            {
                actor.MoveNext();
            }
        }
    }
}