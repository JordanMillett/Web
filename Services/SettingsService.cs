namespace Web
{
    public partial class SettingService
    {
        public string Sentences = "Easy";
        public string Vocab = "Hard";
        public bool SpokenEnglish = false;

        public List<string> Sentence_Options = new List<string>()
        {
            "Easy",
        };
        
        public List<string> Vocab_Options = new List<string>()
        {
            "Easy",
            "Hard",
        };
        
        public SettingService()
        {
            Console.WriteLine("Settings Initialized");
        }
    }
}