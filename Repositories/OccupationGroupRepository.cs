using System.Collections.Generic;

using aspnet_core_mvc_bootstrap_switch.Models;

namespace aspnet_core_mvc_bootstrap_switch.Repositories
{
    public class OccupationGroupRepository : IOccupationGroupRepository
    {
        public IEnumerable<OccupationGroup> FindAll()
        {
            // TODO: Replace this hardcoded lines with actual code which access to database
            var occGroups = new OccupationGroup[] {
                new OccupationGroup {
                    Name = "IT/Software Development",
                    Occupations = new Occupation[] {
                        new Occupation{ Code = "SE", Name = "Software Engineer" },
                        new Occupation{ Code = "DE", Name = "Devops Engineer" },
                        new Occupation{ Code = "NSE", Name = "Network Security Engineer" },
                        new Occupation{ Code = "TE", Name = "Test Engineer" }
                    }
                },
                new OccupationGroup {
                    Name = "Healthcare/Medical",
                    Occupations = new Occupation[] {
                        new Occupation{ Code = "MD", Name = "Doctor of Medicine" },
                        new Occupation{ Code = "GS", Name = "General Surgery" },
                        new Occupation{ Code = "NS", Name = "Neurosurgey" },
                        new Occupation{ Code = "CS", Name = "Cardiothoracic Surgery" }
                    }
                }
            };

            return occGroups;
        }
    }
}