//Jaelee

using cycle.Game.Casting;
using cycle.Game.Directing;
using cycle.Game.Scripting;
using cycle.Game.Services;


namespace cycle
{
    /// The program's entry point.
    class Program
    {
        /// Starts the program using the given arguments.
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();
            Color colorG = new Color(0, 255, 0);
            Color colorR = new Color(255, 0, 0);
            cast.AddActor("snake", new Snake(200, colorG));
            cast.AddActor("score", new Score());
            cast.AddActor("food", new Food());
            cast.AddActor("snake", new Snake(605, colorR));

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}