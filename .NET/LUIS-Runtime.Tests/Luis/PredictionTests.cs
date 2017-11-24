﻿using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Xunit;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests.Luis
{
    public class PredictionTests: BaseTest
    {
        [Fact]
        public void Prediction()
        {
            UseClientFor(async client => {
                var utterance = "hello";
                var result = await client.Prediction.GetPredictionsFromEndpointViaGetAsync(region, appId, utterance);

                Assert.Equal("Family Intent", result.TopScoringIntent.Intent);
            });
        }
    }
}