namespace UWPSoundBoard.Model {
    public class Sound {
        public string Name { get; set; } = string.Empty;
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; } = string.Empty;
        public string ImageFile { get; set; } = string.Empty;

        public Sound(string name, SoundCategory category) {
            Name = name;
            Category = category;

            AudioFile = string.Format("/Assets/Audio/{0}/{1}.wav", category, name);
            ImageFile = string.Format("/Assets/Images/{0}/{1}.png", category, name);
        }
    }
}
