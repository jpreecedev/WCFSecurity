namespace PeopleService.WCFService
{
    public class PeopleService : IPeopleService
    {
        #region Public Methods and Operators

        public Person[] GetPeople()
        {
            return new[]
                       {
                           new Person { Age = 45, FirstName = "John", LastName = "Smith" }, 
                           new Person { Age = 42, FirstName = "Jane", LastName = "Smith" }
                       };
        }

        #endregion
    }
}