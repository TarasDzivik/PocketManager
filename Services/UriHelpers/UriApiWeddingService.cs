using System.Diagnostics;

namespace PocketManager.Services.UriHelpers;
public static class UriApiWeddingService
{
    public static string PlayWedding(string serverUrl, string apiKey)
    {
        try
        {
            if (serverUrl is not null)
            {
                if (serverUrl is not null && apiKey is not null)
                {
                    if (serverUrl.EndsWith("/") && apiKey.StartsWith("/"))
                    {
                        return DeleteDoubleSlash(serverUrl + apiKey.Substring(1));
                    }
                    else if (!serverUrl.EndsWith("/") && !apiKey.StartsWith("/"))
                    {
                        return DeleteDoubleSlash(serverUrl + "/" + apiKey);
                    }
                    else
                    {
                        return DeleteDoubleSlash(serverUrl + apiKey);
                    }
                }
                else if (serverUrl is not null && apiKey is null)
                {
                    return NormalizeServerAddress(serverUrl);
                }
            }
            {
                throw new NullReferenceException("Server url or api kay is null");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Cant wedding server Uri and ApiKey.{0}", ex.Message);
            return null;
        }
    }
    private static string NormalizeServerAddress(string serverUrl) => !serverUrl.EndsWith("/") ? serverUrl += "/" : serverUrl;
    private static string DeleteDoubleSlash(string url) =>
            url.Substring(8).Contains("//") ? (url.Substring(0, (url.IndexOf("//") + 2)) + url.Substring(8).Replace("//", "/")) : url;

}
