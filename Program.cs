internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T object type

        List<int> numberList = new List<int>();

        numberList.Add(23);
        numberList.Add(10);
        numberList.Add(4);
        numberList.Add(5);
        numberList.Add(92);
        numberList.Add(34);

        List<string> colorList = new List<string>();
        colorList.Add("red");
        colorList.Add("blue");
        colorList.Add("orange");
        colorList.Add("yellow");
        colorList.Add("green");

        //Count
        Console.WriteLine(colorList.Count);
        Console.WriteLine(numberList.Count);

        foreach (var item in numberList)
        {
            Console.WriteLine(item);
        }

        foreach (var item in colorList)
        {
            Console.WriteLine(item);
        }

        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));

        // Remove element from List

        numberList.Remove(4);
        colorList.Remove("green");

        numberList.RemoveAt(0);
        colorList.RemoveAt(1);

        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));

        // Search in List

        if (numberList.Contains(10))
            Console.WriteLine("found in List");

        // Eleman ile indexe erişme
        Console.WriteLine(colorList.BinarySearch("yellow"));


        //Dizi yi List'e çevirme

        string[] animals = { "cat", "dog", "bird" };

        List<string> animalList = new List<string>(animals);

        //Clean List
        animalList.Clear();

        // List içerisinde nesne tutmak

        List<Users> UserList = new List<Users>();

        Users user1 = new Users();
        user1.Name = "Jack";
        user1.Surname = "Doe";
        user1.Age = 26;


        Users user2 = new Users();
        user2.Name = "Jane";
        user2.Surname = "Doel";
        user2.Age = 26;

        UserList.Add(user1);
        UserList.Add(user2);

        List<Users> newUserList = new List<Users>();

        newUserList.Add(new Users()
        {
            Name = "Chris",
            Surname = "fake",
            Age = 12
        });

        foreach (var user in UserList)
        {
            Console.WriteLine("User Name " + user.Name);
            Console.WriteLine("User Surname " + user.Surname);
            Console.WriteLine("User Age " + user.Age);
        }


        UserList.Clear();

    }
}

public class Users
{
    private string name;
    private string surname;
    private int age;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}