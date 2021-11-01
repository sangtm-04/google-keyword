using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Examples.V8;
using Google.Ads.GoogleAds.Lib;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace API_Google_Key_Words.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyWordsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<KeyWordsController> _logger;

        public KeyWordsController(ILogger<KeyWordsController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Post([FromBody] RequestKeyWords requestKeyWords)
        {

            GenerateKeywordIdeas codeExample = new GenerateKeywordIdeas();

            ArrayList reports = codeExample.MainKeyWords(requestKeyWords.keywordTexts, requestKeyWords.PageUrl, requestKeyWords.LocationIds, requestKeyWords.LanguageId);
            Console.WriteLine("keywordTexts");
            Console.WriteLine(requestKeyWords.PageUrl);
            return Ok(reports);
        }
    }
}
