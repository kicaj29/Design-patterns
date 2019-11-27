using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.v1
{
    class Liskov
    {
        class Customer
        {

            public virtual double getDiscount(double TotalSales)
            {
                return 10;
            }

            public virtual void Add()
            {
                // adds customer to DB
            }
        }

        class SilverCustomer : Customer
        {
            
        }

        class GoldCustomer : Customer
        {

        }

        #region wrong approach
        class Enquiry : Customer
        {
            public override double getDiscount(double TotalSales)
            {
                return base.getDiscount(TotalSales) - 5;
            }

            public override void Add()
            {
                throw new Exception("Not allowed");
            }
        }

        private void AddCustomers()
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            Customers.Add(new Enquiry());

            foreach (Customer o in Customers)
            {

                o.Add(); //throw exception for Enquiry, Runtime error
            }
        }
        #endregion

        #region correct approach

        interface IDiscount
        {
            double getDiscount(double TotalSales);
        }


        interface IDatabase
        {
            void Add();
        }
        class EnquiryOK : IDiscount
        {
            public double getDiscount(double TotalSales)
            {
                return TotalSales - 5;
            }
        }
        class CustomerOK : IDiscount, IDatabase
        {
            public virtual void Add()
            {
                // Database code goes here  
            }

            public virtual double getDiscount(double TotalSales)
            {
                return TotalSales;
            }
        }

        class SilverCustomerOK : CustomerOK
        {

        }

        class GoldCustomerOK : CustomerOK
        {

        }

        private void AddCustomer()
        {
            List<CustomerOK> Customers = new List<CustomerOK>();
            Customers.Add(new SilverCustomerOK());
            Customers.Add(new GoldCustomerOK());

            // compilation error
            // Customers.Add(new EnquiryOK());
        }

        #endregion
    }
}
