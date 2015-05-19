namespace Examples.InheritanceAndPolymorphism
{
    public class ComplexPerson
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        public int Age { private get; set; }

        public ComplexPerson(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public ComplexPerson()
        {
        }

        //public override bool Equals( object obj )
        //{
        //    var objAsPerson = obj as ComplexPerson;
        //
        //    if (objAsPerson == null)
        //        return false;
        //
        //    return objAsPerson.FirstName == FirstName && objAsPerson.LastName == LastName && objAsPerson.Age == Age;
        //}

        public override bool Equals(object obj)
        {
            // No need to cast 'obj' to a ComplexPerson anymore as everything has a ToString() method
            return obj.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            // Hash code is based on the person's ToString() value
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
        }
    }
}