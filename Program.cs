namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }


        public record Person(string FirstName, string LastName, string[] PhoneNumbers);

        public static void Main()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davio", phoneNumbers);
            Person person2 = new("Nancy", "Davio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }


    }
}