//greed
//Jaelee Hutchinson


namespace greed.Casting
{
    /// An item of cultural or historical interest.
    /// The responsibility of an Artifact is to provide a message about itself.
    public class Artifact : Actor
    {
        private int value = 0;

        /// Constructs a new instance of Artifact.
        public Artifact()
        {

        }
    
        /// Gets the artifact's message.
        /// <returns>The message as a string.</returns>
        public int GetValue()
        {   
            return value;
        }
        
        /// Sets the artifact's message to the given value.
        /// <param name="message">The given message.</param>
        public void SetValue()
        {
            if (GetText() == "O")
            {
                this.value = -1;
            }
            else 
            {
                this.value = 1;
            }
        }
    }

}