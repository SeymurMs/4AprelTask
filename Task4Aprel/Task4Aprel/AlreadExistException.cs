using System;
using System.Collections.Generic;
using System.Text;

namespace Task4Aprel
{
    internal class AlreadExistException:Exception
    {
        public AlreadExistException(string msg):base(msg)
        {
        }
    }
}
