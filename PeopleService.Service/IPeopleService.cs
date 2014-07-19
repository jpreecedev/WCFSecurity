namespace PeopleService.Service
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IPeopleService
    {
        #region Public Methods and Operators

        [OperationContract]
        Person[] GetPeople();

        #endregion
    }
}