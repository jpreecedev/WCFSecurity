namespace PeopleService.TestClient
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PeopleServiceClient client = new PeopleServiceClient();
            client.ClientCredentials.UserName.UserName = "peoplesite";
            client.ClientCredentials.UserName.Password = "password";

            foreach (var person in client.GetPeople())
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
}
