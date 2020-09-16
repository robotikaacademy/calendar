using System;

namespace calendar.Model.Models

{
    public class tab_course
            {
            public int id { get; set; }
            public string name { get; set; }
            public string age_group { get; set; }
            public DateTime date_start { get; set; }
            public DateTime date_end { get; set; }
            public int free_places { get; set; }
            public string level { get; set; }
        }
}