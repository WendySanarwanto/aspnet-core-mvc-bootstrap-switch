using System.Collections.Generic;

namespace aspnet_core_mvc_bootstrap_switch.Repositories
{
    public interface IRepository<T>
    {
         IEnumerable<T> FindAll();
    }
}