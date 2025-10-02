using System.Net;

namespace Giny.Core.IO;

public class Web
{
    public static byte[] DownloadData(string url)
    {
        using (WebClient webClient = new WebClient())
        {
            webClient.Headers.Add("User-Agent: Other");
            return webClient.DownloadData(url);
        }
    }
}