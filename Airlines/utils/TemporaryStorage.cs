using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.utils
{
    public class TemporaryStorage
    {
        private static TemporaryStorage instance;

        public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
        public TemporaryStorage() { }

        public void Dispose() 
        {
            Data.Clear();
        }

        public static TemporaryStorage GetInstance() 
        {

            if (instance == null)
            {
                instance = new TemporaryStorage();
            }

            return instance; 
        }
    }
}
