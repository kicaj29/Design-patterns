using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace AmbientContextExamples.Example1
{
    static partial class AmbientSingleton
    {
        public static AmbientSingleton<T> Create<T>(T defaultValue)
        {
            return new AmbientSingleton<T>(defaultValue);
        }

        public static AmbientSingleton<T> Create<T>(Func<T> defaultValueFactory)
        {
            return new AmbientSingleton<T>(defaultValueFactory);
        }
    }

    partial class AmbientSingleton<T>
    {
        private string slotName = Guid.NewGuid().ToString();
        private Lazy<T> defaultValue;

        /// </summary>
        public AmbientSingleton()
            : this(() => default(T))
        {
        }

        public AmbientSingleton(T defaultValue)
            : this(() => defaultValue)
        {
        }

        public AmbientSingleton(Func<T> defaultValueFactory)
        {
            Guard.NotNull(() => defaultValueFactory, defaultValueFactory);

            this.defaultValue = new Lazy<T>(defaultValueFactory);
        }

        public T Value
        {
            get
            {           
                var contextValue = CallContext.LogicalGetData(this.slotName);
                if (contextValue != null)
                    return (T)contextValue;

                return this.defaultValue.Value;
            }
            set
            {
                CallContext.LogicalSetData(this.slotName, value);
            }
        }
    }
}
