using System.Threading.Tasks;
using Microsoft.JSInterop;
using Web;

public interface ITextToSpeechService
{
    Task Speak(string text, bool english);
}

public class TextToSpeechService : ITextToSpeechService
{
    IJSRuntime Runtime;
    SettingService Settings;

    public TextToSpeechService(IJSRuntime JS, SettingService S)
    {
        Runtime = JS;
        Settings = S;
    }

    public async Task Speak(string text, bool english)
    {
        if (!Settings.SpokenEnglish && english)
            return;
            
        await TryCancel();
        await Runtime.InvokeVoidAsync("textToSpeech.speak", text, english);
    }
    
    public async Task TryCancel()
    {
        await Runtime.InvokeVoidAsync("textToSpeech.trycancel");
    }
}