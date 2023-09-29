//Task1



//using ConsoleApp1;
//Employee employee = new()
//{
//    fullName = "Haci Ahmadov",
//    age = 28,
//    adress = "Bilacari"


//};


//Console.WriteLine(employee.GetFullData());






//Task2

////
//using ConsoleApp1;

//Employee employee1 = new()
//{
//    fullName = "Haci Ahmadov",
//    age = 28,
//    adress = "Bilacari"


//};



//Employee employee2 = new()
//{
//    fullName = "Sarvan Cebrayilzade",
//    age = 28,
//    adress = "Yasamal"


//};



//Employee employee3 = new()
//{
//    fullName = "Shahriyar Alxanov",
//    age = 37,
//    adress = "Badamdar"


//};


//Employee[] employees = {employee1, employee2, employee3};

//foreach (Employee employee in employees)

//    Console.WriteLine(employee.GetFullData());



//Task3


//using ConsoleApp1;

//Book book = new Book();





//Task4

//using ConsoleApp1;

//Book book = new Book();





//Task5



//using ConsoleApp1;

//Book book = new Book();

//book.name = "Martin Iden";
//book.author = "Mark Twen";

//Console.WriteLine(book.GetData());






////Task6


//using ConsoleApp1;

//Book book = new Book("Erix Mariya Remark","Zefer Tagi");

//Console.WriteLine(book.GetData());











//Task7




//using ConsoleApp1;

//Book book = new Book(100,"Azerbaycan");




//Task8


//using ConsoleApp1.Models;

//User user1 = new User
//{
//    id = 1,
//    fullName = "Haci Ahmadov",
//    age = 28
//};



//User user2 = new User
//{
//    id = 2,
//    fullName = "Tofiq Nesibli",
//    age = 19
//};




//User user3 = new User
//{
//    id = 3,
//    fullName = "Ali Aslanov",
//    age = 27
//};



//User user4 = new User
//{
//    id = 4,
//    fullName = "Elnur Ismayilov",
//    age = 25
//};


//User[] people = {user1, user2, user3, user4};


//foreach (var person in people)
//{
//    Console.WriteLine(person.fullName);


//}



//Task9


//using ConsoleApp1.Models;

//User user1 = new User
//{
//    id = 1,
//    fullName = "Haci Ahmadov",
//    age = 28
//};



//User user2 = new User
//{
//    id = 2,
//    fullName = "Tofiq Nesibli",
//    age = 19
//};




//User user3 = new User
//{
//    id = 3,
//    fullName = "Ali Aslanov",
//    age = 27
//};



//User user4 = new User
//{
//    id = 4,
//    fullName = "Elnur Ismayilov",
//    age = 25
//};


//User[] people = { user1, user2, user3, user4 };


//foreach (var person in people)
//{
//    if (person.id == 1)
//    {
//        Console.WriteLine(person.fullName);
//    }
//}


//var result = people.FirstOrDefault(m => m.id > 3);

//Console.WriteLine(result.fullName);




//var result = people.Where(m => m.id>2).ToArray();

//foreach (var person in result)
//{
//    Console.WriteLine(person.fullName);
//}


//Task10


//using ConsoleApp1.Models;




//static void ShowUsers()
//{

//    var result = GetAllUsers();


//    foreach (var user in result)
//    {
//        Console.WriteLine(user.fullName);
//    }

//}



//static User[] GetAllUsers()
//{

//    User user1 = new User
//    {
//        id = 1,
//        fullName = "Haci Ahmadov",
//        age = 28
//    };



//    User user2 = new User
//    {
//        id = 2,
//        fullName = "Tofiq Nesibli",
//        age = 19
//    };



//    User user3 = new User
//    {
//        id = 3,
//        fullName = "Ali Aslanov",
//        age = 27
//    };



//    User user4 = new User
//    {
//        id = 4,
//        fullName = "Elnur Ismayilov",
//        age = 25
//    };


//    User[] people = { user1, user2, user3, user4 };

//    return people;

//}



//Task11


//using ConsoleApp1;

//UserService service = new UserService();

//service.ToString();