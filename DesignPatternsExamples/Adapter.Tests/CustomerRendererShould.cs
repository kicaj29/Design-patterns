using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Model;
using NUnit.Framework;

namespace Adapter.Tests
{
    [TestFixture]
    public class CustomerRendererShould
    {
        [Test]
        public void RenderTwoPatterns()
        {
            var myRenderer = new CustomerRenderer();

            var myList = new List<Customer>
            {
                new Customer {Id = 1, Name = "Cust One", Description = "Cust One Description"},
                new Customer {Id = 2, Name = "Cust Two", Description = "Cust Two Description"}
            };

            string result = myRenderer.ListPatterns(myList);

            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count + 2, lineCount);
        }
    }
}
