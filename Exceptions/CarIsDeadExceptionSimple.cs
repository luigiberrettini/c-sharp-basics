using System;

namespace Examples.Exceptions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
    public class CarIsDeadExceptionSimple : ApplicationException
    {
        private readonly string messageDetails = String.Empty;

        private string causeOfError;

        private DateTime errorTimeStamp;

        public CarIsDeadExceptionSimple()
        {
        }

        public CarIsDeadExceptionSimple(string message, string cause, DateTime time)
        {
            messageDetails = message;
            causeOfError = cause;
            errorTimeStamp = time;
        }

        // Override the Exception.Message property
        public override string Message
        {
            get
            {
                return string.Format("ExceptionalCar Error Message: {0}", messageDetails);
            }
        }
    }
}