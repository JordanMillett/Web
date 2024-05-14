using System.Threading.Tasks;
using Microsoft.JSInterop;

public interface ITextToSpeechService
{
    Task Speak(string text, bool english);
}

public class TextToSpeechService : ITextToSpeechService
{
    IJSRuntime Runtime;

    public TextToSpeechService(IJSRuntime JS)
    {
        Runtime = JS;
    }

    public async Task Speak(string text, bool english)
    {
        await TryCancel();
        await Runtime.InvokeVoidAsync("textToSpeech.speak", text, english);
    }
    
    public async Task TryCancel()
    {
        await Runtime.InvokeVoidAsync("textToSpeech.trycancel");
    }
}