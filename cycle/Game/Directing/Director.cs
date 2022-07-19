//Jaelee

using System.Collections.Generic;
using cycle.Game.Casting;
using cycle.Game.Scripting;
using cycle.Game.Services;
#nullable disable


namespace cycle.Game.Directing
{
    /// A person who directs the game.
    /// The responsibility of a Director is to control the sequence of play.
    public class Director
    {
        private VideoService videoService = null;

        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// <param name="videoService">The given VideoService.</param>
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// Starts the game by running the main game loop for the given cast and script.
        /// <param name="cast">The given cast.</param>
        /// <param name="script">The given script.</param>
        public void StartGame(Cast cast, Script script)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                ExecuteActions("input", cast, script);
                ExecuteActions("update", cast, script);
                ExecuteActions("output", cast, script);
            }
            videoService.CloseWindow();
        }

        /// Calls execute for each action in the given group.
        /// <param name="group">The group name.</param>
        /// <param name="cast">The cast of actors.</param>
        /// <param name="script">The script of actions.</param>
        private void ExecuteActions(string group, Cast cast, Script script)
        {
            List<Action> actions = script.GetActions(group);
            foreach(Action action in actions)
            {
                action.Execute(cast, script);
            }
        }
    }
}