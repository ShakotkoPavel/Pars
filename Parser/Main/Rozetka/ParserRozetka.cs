using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser.Main.Habr
{
    class ParserRozetka : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var goods = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("g-i-tile-i-title clearfix"));
            //var items = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("g-price-uah-sign"));
            foreach (var item in goods)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
