using System.Collections.Generic;

namespace AileHekimiHastaTakibi.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Contact { get; set; } = string.Empty;
        public string? PastIllnesses { get; set; }
        public string? PrescribedMedications { get; set; }
        public string? Notes { get; set; }
    }
}
