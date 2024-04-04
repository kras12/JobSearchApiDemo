using JobSearchApiDemo.Models;
using System.Text;
using System.Text.Json;

namespace JobSearchApiDemo.JobSearchApi
{
    public static class JobSearchApiHandler
    {
        #region Constants

        private const string _rootApiUrl = "https://jobsearch.api.jobtechdev.se";

        #endregion

        #region Properties

        private static string SearchApiUrl
        {
            get
            {
                return $"{_rootApiUrl}/search";
            }
        }

        #endregion

        #region Methods

        public static async Task<JobSearchRoot> SearchJobs(string? searchPhrase = null, int? limit = null, int? occupationGroupId = null)
        {
            StringBuilder queries = new StringBuilder();

            if (!string.IsNullOrEmpty(searchPhrase))
            {
                if (queries.Length == 0)
                {
                    queries.Append($"?q={searchPhrase}");
                }
                else
                {
                    queries.Append($"&q={searchPhrase}");
                }
            }

            if (limit > 0)
            {
                if (queries.Length == 0)
                {
                    queries.Append($"?limit={limit}");
                }
                else
                {
                    queries.Append($"&limit={limit}");
                }
            }

            if (occupationGroupId != null)
            {
                if (queries.Length == 0)
                {
                    queries.Append($"?occupation-group={occupationGroupId}");
                }
                else
                {
                    queries.Append($"&occupation-group={occupationGroupId}");
                }
            }

            var response = await RequestData($"{SearchApiUrl}{queries}");
            var data = JsonSerializer.Deserialize<JobSearchRoot>(response);
            return data;
        }

        private static async Task<string> RequestData(string request)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }

            throw new Exception("An error occcured.");
        }

        #endregion
    }
}
