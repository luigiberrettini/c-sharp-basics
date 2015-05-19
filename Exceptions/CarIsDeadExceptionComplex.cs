using System;
using System.Runtime.Serialization;

namespace Examples.Exceptions
{
    /*
        .NET best practices require that a custom exception:
         - Is marked with the [System.Serializable] attribute
         - Derives from Exception/ApplicationException
         - Defines a default constructor
         - Defines a constructor that sets the inherited Message property
         - Defines a constructor to handle “inner exceptions”
         - Defines a constructor to handle the serialization of your type
    */
    [Serializable]
    public class CarIsDeadExceptionComplex : ApplicationException
    {
        public string CauseOfError { get; private set; }

        public DateTime ErrorTimeStamp { get; private set; }

        public CarIsDeadExceptionComplex()
        {
        }

        public CarIsDeadExceptionComplex(string message)
            : base(message)
        {
        }

        public CarIsDeadExceptionComplex(string message, Exception inner)
            : base(message, inner)
        {
        }

        public CarIsDeadExceptionComplex(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        protected CarIsDeadExceptionComplex(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");

            base.GetObjectData(info, context);
            info.AddValue("CauseOfError", CauseOfError);
            info.AddValue("ErrorTimeStamp", ErrorTimeStamp);
        }
    }
}