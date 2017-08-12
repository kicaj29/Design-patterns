using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientContextExamples.Example1
{
    public class Credentials : ICredentials
    {
        private static readonly AmbientSingleton<ICredentials> instance = new AmbientSingleton<ICredentials>(() => new Credentials());

        public string User { get; set; }
        public string Password { get; set; }

        private Credentials()
        {
        }

        public static ICredentials Instance
        {
            get { return instance.Value; }
            set { instance.Value = value; }
        }

        public override string ToString()
        {
            return $"User: '{User}', Password: '{Password}'";
        }
    }
}
