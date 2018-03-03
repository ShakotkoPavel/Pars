using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace Parser.Main
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.Url}/{settings.Prefix}/";
        }
        public async Task<string> GetSourceByPageId(int Id)
        {
            var currentUrl = url.Replace("{CurrentId}", Id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
