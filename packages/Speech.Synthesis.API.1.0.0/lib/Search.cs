using Microsoft.CognitiveServices.Speech;
using System;
using System.Threading.Tasks;

namespace Speech.Synthesis.API
{
    public class Search
    {
        public  async Task<SpeechSynthesisResult> SynthesisToSpeakerAsync(string key,string serviceRegion,string query)
        {            
            var config = SpeechConfig.FromSubscription(key, serviceRegion);
            using (var synthesizer = new SpeechSynthesizer(config))
            {
                return await synthesizer.SpeakTextAsync(query);                   
            }
        }
    }
}
