window.textToSpeech =
{
    speak: function (text, english)
    {
        var utterance = new SpeechSynthesisUtterance(text);
        utterance.lang = english ? "en-US" : "ru-RU";
        speechSynthesis.speak(utterance);
    },
    
    trycancel: function() 
    {
        if (speechSynthesis.speaking || speechSynthesis.pending)
        {
            speechSynthesis.cancel();
        }
    }
};