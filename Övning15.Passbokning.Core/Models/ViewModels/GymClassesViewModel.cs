using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning15Passbokning.Core.Models.ViewModels
{
    public class GymClassesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd | HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? StartTime { get; set; }

        [Required]
        public TimeSpan? Duration { get; set; }

        public DateTime EndTime => StartTime.GetValueOrDefault() + Duration.GetValueOrDefault();

        public string Description { get; set; }
        public bool Attending { get; set; }
    }
}
