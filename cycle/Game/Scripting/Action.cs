//Jaelee

using cycle.Game.Casting;


namespace cycle.Game.Scripting 
{
    /// A thing that is done.
    /// The responsibility of action is to do something that is integral or important in the game. 
    /// Thus, it has one method, Execute(...), which should be overridden by derived classes.
    public interface Action
    {
        /// Executes something that is important in the game. This method should be overriden by 
        /// derived classes.
        /// <param name="cast">The cast of actors.</param>
        /// <param name="script">The script of actions.</param>
        void Execute(Cast cast, Script script);
    }
}