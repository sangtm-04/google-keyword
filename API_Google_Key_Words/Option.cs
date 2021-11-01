using CommandLine;
using Google.Ads.GoogleAds.V8.Common;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V8.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V8
{
    public class Options : OptionsBase
    {
        /// <summary>
        /// The customer ID for which the call is made.
        /// </summary>
        [Option("customerId", Required = true, HelpText =
            "The customer ID for which the call is made.")]
        public long CustomerId { get; set; }

        /// <summary>
        /// Location criteria IDs. For example, specify 21167 for New York. For more
        /// information on determining this value, see
        /// https://developers.google.com/google-ads/api/reference/data/geotargets.
        /// </summary>
        [Option("locationIds", Required = true, HelpText =
            "Location criteria IDs. For example, specify 21167 for New York. For more " +
            "information on determining this value, see " +
            "https://developers.google.com/google-ads/api/reference/data/geotargets.")]
        public IEnumerable<long> LocationIds { get; set; }

        /// <summary>
        /// A language criterion ID. For example, specify 1000 for English. For more information
        /// on determining this value, see
        /// https://developers.google.com/google-ads/api/reference/data/codes-formats#languages.
        /// </summary>
        [Option("languageId", Required = true, HelpText =
            "A language criterion ID. For example, specify 1000 for English. For more " +
            "information on determining this value, see " +
            "https://developers.google.com/google-ads/api/reference/data/codes-formats#languages.")]
        public long LanguageId { get; set; }

        /// <summary>
        /// The list of seed keywords.
        /// </summary>
        [Option("keywordTexts", Required = false, HelpText =
            "The list of seed keywords.", Default = new string[] { })]
        public IEnumerable<string> KeywordTexts { get; set; }

        /// <summary>
        /// Specify a URL string related to your business to generate ideas.
        /// </summary>
        [Option("pageUrl", Required = false, HelpText =
            "Specify a URL string related to your business to generate ideas.")]
        public string PageUrl { get; set; }
    }
}
