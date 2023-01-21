using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helpers
{
    public class Enums
    {
        public enum Statuses
        {
            DataIsNull = 1001,
            GeneralError = 1000
        }
        public enum Roles
        {
            Admin,
            SuperAdmin,
            Manager,
            Member
        }
    }
}
