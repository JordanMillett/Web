namespace Web
{
    public partial class SettingService
    {
        public string Sentences = "easy";
        public string Vocab = "hard";
        public bool SpokenEnglish = false;

        public List<string> Sentence_Options = new List<string>()
        {
            "easy",
        };
        
        public List<string> Vocab_Options = new List<string>()
        {
            "easy",
            "hard",
            "test"
        };
        
        public SettingService()
        {
            Console.WriteLine("Settings Initialized");
        }
    }
}