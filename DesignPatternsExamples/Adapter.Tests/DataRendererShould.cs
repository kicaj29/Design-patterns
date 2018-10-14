using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Adapter.Tests
{
    [TestFixture]
    public class DataRendererShould
    {
        [Test]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }

        [Test, Explicit]
        public void RenderTwoRowsGivenOleDbDataAdapter()
        {
            var adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM Pattern");
            adapter.SelectCommand.Connection =
                new OleDbConnection(
                    @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=C:\Users\Steve\Documents\My Dropbox\PluralsightCurrent\009 - Adapter Pattern\AdapterDemo\AdapterDemo\Sample.sdf");
            var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(4, lineCount);
        }
    }
}
