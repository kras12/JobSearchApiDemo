namespace JobSearchApiDemo.Models
{
    public class JobSearchViewModel
    {
        public JobSearchViewModel(List<Occupation_Group> occupationGroups)
        {
            FormData = new JobSearchFormViewModel(occupationGroups);
        }

        public JobSearchViewModel(JobSearchFormViewModel formData, JobSearchRoot? searchResult = null)
        {
            FormData = formData;
            SearchResult = searchResult;
        }

        public JobSearchFormViewModel FormData { get; set; }

        public JobSearchRoot? SearchResult { get; set; } = null;
    }
}
