
using System.ComponentModel.DataAnnotations;

namespace LocationTemplates.Models
{
    public class LocationViewModel
    {
        [UIHint("States")]
        public string State { get; set; }
        [UIHint("Countries")]
        public string Country { get; set; }
    }
}