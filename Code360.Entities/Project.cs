using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Code360.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
    }
}
