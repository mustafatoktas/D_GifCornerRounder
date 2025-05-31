using Newtonsoft.Json.Linq;

public class VersionChecker
{
    private static readonly HttpClient client = new HttpClient();

    public static async Task CheckForUpdates()
    {
        string repoApiUrl = "https://api.github.com/repos/mustafatoktas/D_GifCornerRounder/releases/latest";
        client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

        try
        {
            HttpResponseMessage response = await client.GetAsync(repoApiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var latestRelease = JObject.Parse(responseBody);
            string latestVersion = latestRelease["tag_name"].ToString();
            string downloadUrl = latestRelease["html_url"].ToString();

            string currentVersion = "v1.0.0"; // mevcut sürüm

            if (string.Compare(latestVersion, currentVersion) > 0)
            {
                MessageBox.Show($"New version available: {latestVersion}\n\nDownload here: {downloadUrl}", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are using the latest version.", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (HttpRequestException e)
        {
            MessageBox.Show($"Request error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}