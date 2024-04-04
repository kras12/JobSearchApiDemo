using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JobSearchApiDemo.Models
{
    public class JobSearchFormViewModel
    {
        public JobSearchFormViewModel()
        {
            
        }

        public JobSearchFormViewModel(List<Occupation_Group> occupationGroups)
        {
            OccupationGroups = occupationGroups.Select(x => new SelectListItem(x.label, x.legacy_ams_taxonomy_id.ToString())).Prepend(new SelectListItem("Alla", "-1")).ToList();
        }

        #region Properties

        public string? SearchPhrase { get; set; } = null;

        public int? Limit { get; set; } = 25;

        [BindNever]
        public List<SelectListItem> OccupationGroups { get; set; } = new List<SelectListItem>();

        public int? SelectedOccupationGroupId { get; set; } 

        #endregion

        public void SetOccupationGroups(List<Occupation_Group> occupationGroups)
        {
            OccupationGroups = occupationGroups.Select(x => new SelectListItem(x.label, x.legacy_ams_taxonomy_id.ToString())).Prepend(new SelectListItem("Alla", "null")).ToList();
        }
    }
}
