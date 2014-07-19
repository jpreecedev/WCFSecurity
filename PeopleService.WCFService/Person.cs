namespace PeopleService.WCFService
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Person
    {
        #region Public Properties

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        #endregion
    }
}