using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    /// <summary>
    /// This is CLIENT.
    /// It calls functions from the TARGET (adapter interface).
    /// </summary>
    public class CustomerRenderer
    {
        private readonly IDataPatternRendererAdapter _dataPatternRenderer;

        public CustomerRenderer(IDataPatternRendererAdapter dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public CustomerRenderer() : this(new DataPatternRendererAdapter())
        {
        }

        public string ListPatterns(IEnumerable<Customer> patterns)
        {
            //Here we access TARGET (_dataPatternRenderer)
            return _dataPatternRenderer.ListCustomers(patterns);
        }
    }
}
