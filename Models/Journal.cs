using System;

namespace lawsite.Models
{
    public class Journal{

        public int Id{get; set;}
        public string Title {get; set;}="";

        public string Author {get; set;}="";
        public DateTime Created {get; set;} =DateTime.Now;



    }
}
