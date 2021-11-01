using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Google_Key_Words
{
    public class RequestKeyWords
    {
        public string[]? keywordTexts { get; set; }

        public string PageUrl { get; set; }

        public long[] LocationIds { get; set; }

        public long LanguageId { get; set; }
    }
}
