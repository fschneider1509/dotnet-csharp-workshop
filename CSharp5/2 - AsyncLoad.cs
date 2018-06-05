using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Dotnet.Demo
{
    public class AsyncLoad
    {

        public async Task<string> DownloadUrl(string url)
        {
            WebClient client = new WebClient();
            client.BaseAddress = "www.microsoft.com";
            try
            {
                return await client.DownloadStringTaskAsync(url);
            }
            catch
            {
                return await client.DownloadStringTaskAsync("Azure");
            }
            finally
            {
                //Await is also allowed.
            }
        }

    }
}
