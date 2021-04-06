using System;
using System.ComponentModel.DataAnnotations;


namespace lawsite.Models
{
    public class BlogContent
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string EnteredBy { get; set; }
    public DateTime EnteredOn { get; set; }
    }
}