using System.Threading.Tasks;
using Microsoft.JSInterop;

public interface IAudioPlayerService
{
    Task Play(string audioUrl);
}

public class AudioPlayerService : IAudioPlayerService
{
    IJSRuntime Runtime;

    public AudioPlayerService(IJSRuntime JS)
    {
        Runtime = JS;
    }

    public async Task Play(string url)
    {
        await Runtime.InvokeVoidAsync("audioPlayer.play", url);
    }
}