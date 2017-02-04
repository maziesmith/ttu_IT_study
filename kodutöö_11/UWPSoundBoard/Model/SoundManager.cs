using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace UWPSoundBoard.Model {
    public class SoundManager {
        public static void GetAllSounds(ObservableCollection<Sound> sounds) {
            List<Sound> allSounds = getSounds();

            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory) {
            List<Sound> allSounds = getSounds();
            List<Sound> filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();

            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds(){
            List<Sound> sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
