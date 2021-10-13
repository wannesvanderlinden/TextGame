using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Key : Iitem, ITakeable, IUsable, Ilookable
    {
        public List<string> names => throw new NotImplementedException();

        public string akeMessage()
        {
            throw new NotImplementedException();
        }

        public string LookMessage()
        {
            throw new NotImplementedException();
        }
    }
}
