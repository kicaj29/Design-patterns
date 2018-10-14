using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    /// <summary>
    /// This is TARGET. It will be used by the CLIENT (CustomerRenderer) client.
    /// </summary>
    public interface IDataPatternRendererAdapter
    {
        string ListCustomers(IEnumerable<Customer> customers);
    }
}
