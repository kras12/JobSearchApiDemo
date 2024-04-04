using System.Text.Json.Serialization;

namespace JobSearchApiDemo.Models
{
    public class JobSearchRoot
    {
        public Total total { get; set; }
        public int positions { get; set; }
        public int query_time_in_millis { get; set; }
        public int result_time_in_millis { get; set; }
        public object[] stats { get; set; }
        public Freetext_Concepts freetext_concepts { get; set; }
        public Hit[] hits { get; set; }
    }

    public class Total
    {
        public int value { get; set; }
    }

    public class Freetext_Concepts
    {
        public string[] skill { get; set; }
        public object[] occupation { get; set; }
        public object[] location { get; set; }
        public object[] skill_must { get; set; }
        public object[] occupation_must { get; set; }
        public object[] location_must { get; set; }
        public object[] skill_must_not { get; set; }
        public object[] occupation_must_not { get; set; }
        public object[] location_must_not { get; set; }
    }

    public class Hit
    {
        public float relevance { get; set; }
        public string id { get; set; }
        public string external_id { get; set; }
        public object original_id { get; set; }
        public string label { get; set; }
        public string webpage_url { get; set; }
        public string logo_url { get; set; }
        public string headline { get; set; }
        public DateTime application_deadline { get; set; }
        public int number_of_vacancies { get; set; }
        public Description description { get; set; }
        public Employment_Type employment_type { get; set; }
        public Salary_Type salary_type { get; set; }
        public string salary_description { get; set; }
        public Duration duration { get; set; }
        public Working_Hours_Type working_hours_type { get; set; }
        public Scope_Of_Work scope_of_work { get; set; }
        public object access { get; set; }
        public Employer employer { get; set; }
        public Application_Details application_details { get; set; }
        public bool experience_required { get; set; }
        public bool access_to_own_car { get; set; }
        public bool driving_license_required { get; set; }
        public object driving_license { get; set; }
        public Occupation occupation { get; set; }
        public Occupation_Group occupation_group { get; set; }
        public Occupation_Field occupation_field { get; set; }
        public Workplace_Address workplace_address { get; set; }
        public Must_Have must_have { get; set; }
        public Nice_To_Have nice_to_have { get; set; }
        public Application_Contacts[] application_contacts { get; set; }
        public DateTime publication_date { get; set; }
        public DateTime last_publication_date { get; set; }
        public bool removed { get; set; }
        public object removed_date { get; set; }
        public string source_type { get; set; }
        public long timestamp { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public string text_formatted { get; set; }
        public object company_information { get; set; }
        public object needs { get; set; }
        public object requirements { get; set; }
        public string conditions { get; set; }
    }

    public class Employment_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Salary_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Duration
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Working_Hours_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Scope_Of_Work
    {
        public int? min { get; set; }
        public int? max { get; set; }
    }

    public class Employer
    {
        public object phone_number { get; set; }
        public object email { get; set; }
        public string url { get; set; }
        public string organization_number { get; set; }
        public string name { get; set; }
        public string workplace { get; set; }
    }

    public class Application_Details
    {
        public object information { get; set; }
        public object reference { get; set; }
        public object email { get; set; }
        public bool via_af { get; set; }
        public string url { get; set; }
        public object other { get; set; }
    }

    public class Occupation
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Occupation_Group
    {
        [JsonIgnore]
        private static List<Occupation_Group> allGroups = new List<Occupation_Group>()
        {
            new Occupation_Group(label: "Systemanalytiker och IT-arkitekter m.fl.", id: "2511"),
            new Occupation_Group(label: "Mjukvaru- och systemutvecklare m.fl.", id: "2512"),
            new Occupation_Group(label: "Utvecklare inom spel och digitala media", id: "2513"),
            new Occupation_Group(label: "Systemtestare och testledare", id: "2514"),
            new Occupation_Group(label: "Systemförvaltare m.fl.", id: "2515"),
            new Occupation_Group(label: "IT-säkerhetsspecialister", id: "2516"),
            new Occupation_Group(label: "Övriga IT-specialister", id: "2519"),
            new Occupation_Group(label: "Drifttekniker, IT", id: "3511"),
            new Occupation_Group(label: "Supporttekniker, IT", id: "3512"),
            new Occupation_Group(label: "Systemadministratörer", id: "3513"),
            new Occupation_Group(label: "Nätverks- och systemtekniker m.fl.", id: "3514"),
            new Occupation_Group(label: "Webbmaster och webbadministratörer", id: "3515")
        };

        public Occupation_Group()
        {
            
        }

        public Occupation_Group(string label, string id)
        {
            this.label = label;
            this.legacy_ams_taxonomy_id = id;
        }

        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }

        [JsonIgnore]
        public static List<Occupation_Group> AllGroups
        {
            get
            {
                return allGroups;
            }
        }
    }

    public class Occupation_Field
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Workplace_Address
    {
        public string municipality { get; set; }
        public string municipality_code { get; set; }
        public string municipality_concept_id { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string region_concept_id { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string country_concept_id { get; set; }
        public object street_address { get; set; }
        public object postcode { get; set; }
        public object city { get; set; }
        public float?[] coordinates { get; set; }
    }

    public class Must_Have
    {
        public object[] skills { get; set; }
        public object[] languages { get; set; }
        public Work_Experiences[] work_experiences { get; set; }
        public object[] education { get; set; }
        public object[] education_level { get; set; }
    }

    public class Work_Experiences
    {
        public int weight { get; set; }
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Nice_To_Have
    {
        public object[] skills { get; set; }
        public object[] languages { get; set; }
        public object[] work_experiences { get; set; }
        public object[] education { get; set; }
        public object[] education_level { get; set; }
    }

    public class Application_Contacts
    {
        public object name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string contact_type { get; set; }
    }

}
