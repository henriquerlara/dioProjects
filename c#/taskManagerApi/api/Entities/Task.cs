using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
