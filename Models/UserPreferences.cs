using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommender.Models.Preferences
{
    public class UserPreferences
    {
        public string Movies { get; set; }
        public string Books { get; set; }
        public string Series { get; set; }
        public string PlatformStreaming { get; set; }
    }
}