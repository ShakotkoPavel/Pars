using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Main.Habr
{
    class RozetkaSettings : IParserSettings
    {
        public RozetkaSettings(int start, int end)
        {
            this.StartPoint = start;
            this.EndPoint = end;
        }

        public string Url { get; set; } = "https://rozetka.com.ua/notebooks/c80004/filter";

        public string Prefix { get; set; } = "page={CurrentId}";
        
        public int StartPoint { get; set; } = 1;

        public int EndPoint { get; set; } = 2;
    }
}
