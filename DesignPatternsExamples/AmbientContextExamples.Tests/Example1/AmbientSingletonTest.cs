using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmbientContextExamples.Example1;
using NUnit.Framework;
using FluentAssertions;

namespace AmbientContextExamples.Tests.Example1
{
    [TestFixture]
    public class AmbientSingletonTest
    {
        [SetUp]
        public void RunBeforeEveryTest()
        {
            
        }

        [TearDown]
        public void RunAfterEveryTest()
        {
            
        }

        [OneTimeSetUp]
        public void RunBefore()
        {
            
        }

        [OneTimeTearDown]
        public void RunAfter()
        {
            
        }

        [Test]
        public void Credentials_GivenAmbientContextIsSet_ShouldBeTheSameInTheSameCallContext()
        {
            //Here we are in some call context, let`s call it A
            var c = new SuperCredentials()
            {
                User = "Jacek",
                Password = "Placek"
            };
            Credentials.Instance = c;


            var d = new SuperCredentials();

            c.Should().BeSameAs(Credentials.Instance);
            d.Should().NotBeSameAs(Credentials.Instance);

            var t = new Task(() => UseAmbientContext(c));

            Debug.WriteLine(Credentials.Instance);

            //Here we start new call context, let`s call it B
            t.Start();
            t.Wait();

            Debug.WriteLine(Credentials.Instance);
            //changes from call context B do not impact call context A
            c.Should().BeSameAs(Credentials.Instance);  
        }

        private static void UseAmbientContext(SuperCredentials sc)
        {
            //call context B inherits from A
            sc.Should().BeSameAs(Credentials.Instance);

            var a = new SuperCredentials()
            {
                User = "Super",
                Password = "123456"
            };

            Credentials.Instance = a;
            Debug.WriteLine(Credentials.Instance);
            a.Should().BeSameAs(Credentials.Instance);
            sc.Should().NotBeSameAs(Credentials.Instance);


        }
    }
}
