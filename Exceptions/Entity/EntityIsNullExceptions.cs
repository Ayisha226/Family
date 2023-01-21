using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Entity
{
    public class EntityIsNullExceptions:Exception
    {
        private static string _message = "data could not found!";

        public EntityIsNullExceptions() : base(_message)
        {

        }
    }
}
