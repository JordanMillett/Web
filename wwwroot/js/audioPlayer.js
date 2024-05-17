window.audioPlayer =
{
    play: function (url)
    {
        var audio = new Audio(url);
        audio.volume = 0.75;
        audio.play();
    }
};