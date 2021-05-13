using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___EXCEPTION.Entities.Exceptions{
    //------------------------------- START -------------------------------//
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
    //-------------------------------- END -------------------------------//
}
