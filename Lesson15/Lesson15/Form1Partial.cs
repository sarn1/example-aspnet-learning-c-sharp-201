using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public partial class Form1
    {
        private readonly Uri _url = new Uri("http://www.wdonline.com/blog/"); 

        private void LegacyDownloadString()
        {
            using (var client = new WebClient())
            {
                client.DownloadStringCompleted += (o, args) =>
                {
                    var data = args.Result;

                    // do something with data
                };

                client.DownloadStringAsync(_url);
            }
        }

        private async Task<string> NewDownloadStringAsync()
        {
            using (var client = new WebClient())
            {
                return await client.DownloadStringTaskAsync(_url);
            }
        }
    }
}
