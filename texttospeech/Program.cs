using System.Speech.Synthesis;
class Program
{
    static void Main(string[] args)
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        synthesizer.Speak("Hello, welcome to the text to speech application.");
    }
}