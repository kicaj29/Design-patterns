using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    /// <summary>
    /// This is ADAPTER.
    /// </summary>
    public class DataPatternRendererAdapter : IDataPatternRendererAdapter
    {
        /// <summary>
        /// This is ADAPTEE.
        /// More here https://www.dofactory.com/net/adapter-design-pattern
        /// </summary>
        private DataRenderer _dataRenderer;


        public string ListCustomers(IEnumerable<Customer> customers)
        {
            var dbAdapter = new CustomerCollectionDbAdapter(customers);
            _dataRenderer = new DataRenderer(dbAdapter);

            var writer = new StringWriter();
            _dataRenderer.Render(writer);

            return writer.ToString();
        }

        internal class CustomerCollectionDbAdapter : IDbDataAdapter
        {
            private IEnumerable<Customer> _customers;

            public CustomerCollectionDbAdapter(IEnumerable<Customer> customers)
            {
                this._customers = customers;
            }

            public int Fill(DataSet dataSet)
            {
                var myDataTable = new DataTable();
                myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

                foreach (var customer in this._customers)
                {
                    var myRow = myDataTable.NewRow();
                    myRow[0] = customer.Id;
                    myRow[1] = customer.Name;
                    myRow[2] = customer.Description;
                    myDataTable.Rows.Add(myRow);
                }
                dataSet.Tables.Add(myDataTable);
                dataSet.AcceptChanges();

                return myDataTable.Rows.Count;
            }


            #region not implemented
            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new NotImplementedException();
            }
            #endregion

            public MissingMappingAction MissingMappingAction { get; set; }
            public MissingSchemaAction MissingSchemaAction { get; set; }
            public ITableMappingCollection TableMappings { get; }
            public IDbCommand SelectCommand { get; set; }
            public IDbCommand InsertCommand { get; set; }
            public IDbCommand UpdateCommand { get; set; }
            public IDbCommand DeleteCommand { get; set; }
        }
    }
}
