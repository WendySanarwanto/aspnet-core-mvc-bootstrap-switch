using System.Collections.Generic;

using aspnet_core_mvc_bootstrap_switch.Models;

namespace aspnet_core_mvc_bootstrap_switch.ViewModels {
    public class HomeViewModel {
        public IEnumerable<OccupationGroup> OccupationGroups { set; get; }
    }
}