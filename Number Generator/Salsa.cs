/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//Der nachfolgende Code habe ich von ChatGPT und von den Nutzern user26830 und Matthias Braun.



namespace Number_Generator
{
    public class SoundPlayer
    {
        private Stream? stream;

        public SoundPlayer()
        {
        }

        public SoundPlayer(Stream? stream)
        {
            this.stream = stream;
        }

        public string SoundLocation { get; private set; }

        public static void sounds()
        { 

            Assembly assembly = Assembly.GetExecutingAssembly();
            SoundPlayer typewriter;

            // Prüfe, ob die eingebettete Ressource vorhanden ist
            if (Array.Exists(assembly.GetManifestResourceNames(), name => name.EndsWith(@"C:\Users\elias\Downloads\Desktop\Audio Number Guesser\WrongBuzzerSoundEffect.wav")))
            {
                typewriter = new SoundPlayer(assembly.GetManifestResourceStream(@"C:\Users\elias\Downloads\Desktop\Audio Number Guesser\WrongBuzzerSoundEffect.wav"));
            }
            else
            {
                typewriter = new SoundPlayer();
                typewriter.SoundLocation = Environment.CurrentDirectory + @"/C:\Users\elias\Downloads\Desktop\Audio Number Guesser\WrongBuzzerSoundEffect.wav";
            }

        }
    }
}

*/