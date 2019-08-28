using System.Collections.Generic;

namespace aspnet_core_mvc_bootstrap_switch.Models
{
    public class OccupationGroup
    {
        public string Name { set; get; }
        public IEnumerable<Occupation> Occupations { set; get; }
    }
}