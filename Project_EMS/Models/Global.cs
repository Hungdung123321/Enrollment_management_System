using Hanssens.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_EMS.Models
{
    public static class Global
    {
        public enum Role
        {
            student,
            admission,
            admin
        }

        public enum status
        {
            ispending,
            success,
            fail
        }

        public enum gender
        {
            male,
            female,
        }
    }
}
