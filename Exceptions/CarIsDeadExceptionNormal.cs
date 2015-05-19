using System;

namespace Examples.Exceptions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
    public class CarIsDeadExceptionNormal : ApplicationException
    {
        private string causeOfError;

        private DateTime errorTimeStamp;

        public CarIsDeadExceptionNormal()
        {
        }

        // Feed message to parent constructor
        public CarIsDeadExceptionNormal(string message, string cause, DateTime time)
            : base(message)
        {
            causeOfError = cause;
            errorTimeStamp = time;
        }
    }
}