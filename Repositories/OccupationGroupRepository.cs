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
                        new Occupation{ Id = "SE", Text = "Software Engineer" },
                        new Occupation{ Id = "DE", Text = "Devops Engineer" },
                        new Occupation{ Id = "NSE", Text = "Network Security Engineer" },
                        new Occupation{ Id = "TE", Text = "Test Engineer" }
                    }
                },
                new OccupationGroup {
                    Name = "Healthcare/Medical",
                    Occupations = new Occupation[] {
                        new Occupation{ Id = "MD", Text = "Doctor of Medicine" },
                        new Occupation{ Id = "GS", Text = "General Surgery" },
                        new Occupation{ Id = "NS", Text = "Neurosurgey" },
                        new Occupation{ Id = "CS", Text = "Cardiothoracic Surgery" }
                    }
                }
            };

            return occGroups;
        }
    }
}