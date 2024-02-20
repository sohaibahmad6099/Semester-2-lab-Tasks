using System;
using System.Collections.Generic;
using System.Linq;
using week_4_Tasks.BL;

namespace week_4_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SelfAssessment1();
            //SelfAssessment2();
            //Chalenge1();
            //Challenge2();
            //Challenge3();
     
        }
        static void Challenge3()
        {
            List<Book> books = new List<Book>();
            List<Member> members = new List<Member>();
            int num = 0;
            while (num < 13)
            {
                Console.Clear();
                Ch_3_Menu();
                num = CheckNum();
                if (num == 1)
                {
                    // Take Data
                    Book book = Ch_3_Input();
                    books.Add(book);
                }
                else if (num == 2)
                {
                    // Add Aurthor
                    Add_Authors_ch3(books);
                }
                else if (num == 3)
                {
                    //Search By Title
                    Ch_3_SearchByTitle(books);
                }
                else if (num == 4)
                {
                    //Search By ISBN
                    Ch_3_SearchByISBN(books);
                }
                else if (num == 5)
                {
                    //Update Stock
                    UpdateStock_Ch3(books);
                }
                else if (num == 6)
                {
                    // Take Member Data
                    Member men = Ch_3_MemberInput();
                    members.Add(men);
                }
                else if (num == 7)
                {
                    // Search member
                    Ch_3_SearchMember(members);
                }
                else if (num == 8)
                {
                    //Display members Data
                    DisplayMembersData(members);
                }
                else if (num == 9)
                {
                    // Update member data
                    Ch_3_UpdateMembersData(members);
                }
                else if (num == 10)
                {
                    // Purchase book
                    Ch_3_PurchaseBook(books, members);
                }
                else if (num == 11)
                {
                    //Display total Sales
                    DisplaytotalSal(books, members);
                }
                else if (num == 12)
                {
                    // Display Book Data 
                    DisplayBookData(members);
                }
                Console.ReadKey();

            }
        }
        static void Ch_3_Menu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Author");
            Console.WriteLine("3. Search book using title");
            Console.WriteLine("4. Search bookin using ISBN");
            Console.WriteLine("5. Edit Stock");
            Console.WriteLine("6. Add Member");
            Console.WriteLine("7. Search member");
            Console.WriteLine("8. Display data of members");
            Console.WriteLine("9. Update Members data");
            Console.WriteLine("10. Purchase Book");
            Console.WriteLine("11. Display the total Amount of books sold and their total price");
            Console.WriteLine("12. Display Book data");
            Console.WriteLine("13. Exit");
        }
        static Book Ch_3_Input()
        {
            Book ch = new Book();
            Console.WriteLine("Enter the Title of the Book: ");
            ch.Title = Console.ReadLine();
            Console.WriteLine("Enter the publisher of the Book: ");
            ch.publisher = Console.ReadLine();
            Console.WriteLine("Enter the year of Publication: ");
            ch.YearOfPublish = Console.ReadLine();
            Console.WriteLine("Enter ISBN of the Book: ");
            ch.ISBN = Console.ReadLine();
            Console.WriteLine("Enter the Price of the Book: ");
            ch.Price = int.Parse(Console.ReadLine());
            return ch;
        }
        static void Add_Authors_ch3(List<Book> books)
        {
            int num;
            int loop;
            Ch_1_DisplayData(books);
            num = CheckNum();
            Console.WriteLine("Enter the number of Aurthors You want to Add: ");
            loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                books[num].AuthrName[i] = Console.ReadLine();
            }
        }
        static void Ch_3_SearchByTitle(List<Book> books)
        {
            Console.WriteLine("Enter the title of the book you want to find");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    Console.WriteLine($"{books[i].Title}\t{books[i].Price}\t{books[i].ISBN}");
                }
            }
        }
        static void Ch_3_SearchByISBN(List<Book> books)
        {
            Console.WriteLine("Enter the ISBN of the book you want to find");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == title)
                {
                    Console.WriteLine($"{books[i].Title}\t{books[i].Price}\t{books[i].ISBN}");
                }
            }
        }
        static void UpdateStock_Ch3(List<Book> books)
        {
            Ch_3_DisplayData(books);
            Console.WriteLine("Enter the ISBN or Title of the book you want to Update the stock of");
            string title = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == title || books[i].Title == title)
                {
                    IncreaseStock(books, i);
                }
            }
        }
        static void IncreaseStock(List<Book> books, int num)
        {
            char letter;
            int nun;
            Console.WriteLine("Enter + to add in Stock and - to subtract from stock: ");
            letter = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of books: ");
            nun = int.Parse(Console.ReadLine());
            if (letter == '+')
            {
                books[num].stock += nun;
            }
            else if (letter == '-')
            {
                books[num].stock -= nun;
            }
        }
        static void Ch_3_DisplayData(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i}\t {books[i].Title}\t{books[i].ISBN}\t{books[i].Price}");
                for (int j = 0; j < books[i].NameOfArthur.Count; j++)
                {
                    Console.WriteLine($"{books[i].NameOfArthur[j]}");
                }
            }
        }
        static Member Ch_3_MemberInput()
        {
            Member member = new Member();
            Console.WriteLine("Enter the name of the member: ");
            member.Name = Console.ReadLine();
            Console.WriteLine("Enter the Id of the member if any else enter 0: ");
            member.Member_ID = Console.ReadLine();
            return member;
        }
        static void Ch_3_SearchMember(List<Member> members)
        {
            string name;
            Console.WriteLine("Enter the name or member id you want to find: ");
            name = Console.ReadLine();
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name == name || members[i].Member_ID == name)
                {
                    Console.WriteLine("The member is given below: ");
                    Console.WriteLine($"{members[i].Name}\t{members[i].Member_ID}");
                    break;
                }
            }
            Console.WriteLine("The user is not a valid user");
        }
        static void DisplayMembersData(List<Member> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i}\t{members[i].Name}\t{members[i].Member_ID}");
                for (int j = 0; j < members[i].books.Count; j++)
                {
                    Console.WriteLine($"{members[i].books}");
                }
            }
        }
        static void Ch_3_UpdateMembersData(List<Member> members)
        {
            int idx;
            DisplayMembersData(members);
            Console.WriteLine("Enter the index if the members to update their data: ");
            idx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new name: ");
            members[idx].Name = Console.ReadLine();
            Console.WriteLine("Enter the nnew ID: ");
            members[idx].Member_ID = Console.ReadLine();
        }
        static void Ch_3_PurchaseBook(List<Book> books, List<Member> members)
        {
            Ch_1_DisplayData(books);
            int num = CheckNum();
            int quantity;
            Console.WriteLine("Enter the Quantity of the book you want to buy ");
            quantity = int.Parse(Console.ReadLine());
            if (members[num].Member_ID == "0")
            {
                books[num].stock -= quantity;
                members[num].money_Spent += quantity * members[num].Price;
                members[num].money_In_Bank += quantity * members[num].Price;
                books[num].bookMark += quantity;
            }
            else
            {
                books[num].stock -= quantity;
                books[num].bookMark += quantity;
                members[num].money_Spent += quantity * members[num].Price;
                members[num].money_In_Bank += quantity * members[num].Price;
                members[num].money_Spent = (members[num].money_Spent * 5) / 100;
                members[num].money_In_Bank = (members[num].money_Spent * 5) / 100;
            }
        }
        static void DisplaytotalSal(List<Book> books, List<Member> members)
        {
            int quantity = 0;
            int sales = 0;
            for (int i = 0; i < books.Count; i++)
            {
                quantity += books[i].bookMark;
            }
            for (int i = 0; i < books.Count; i++)
            {
                sales += members[i].money_In_Bank;
            }
            Console.WriteLine($"The total quantity of books sold are: {quantity} and sales is: {sales}");
        }
        static void DisplayMembersFinaldata(List<Member> members)
        {
            Console.WriteLine("The data is given below");
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{members[i].Name}\t{members[i].Member_ID}");
            }
        }
        static void DisplayBookFinaldata(List<Book> book)
        {
            Console.WriteLine("The data is given below");
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine($"{book[i].Title}\t{book[i].Price}\t{book[i].ISBN}\t{book[i].publisher}");
                for (int j = 0; j < book.Count; j++)
                {
                    Console.WriteLine($"{book[i].NameOfArthur[j]}");
                }
            }
        }

        static void Challenge2()
        {
            int num = 0;
            List<Member> members = new List<Member>();
            while (num < 6)
            {
                Ch_2_Menu();
                num = CheckNum();
                if (num == 1)
                {
                    // Add User
                    Member member = Ch_2_Input();
                    members.Add(member);
                }
                else if (num == 2)
                {
                    //Add Book
                    AddBook(members);
                }
                else if (num == 3)
                {
                    // Update name
                    Ch_2_UpdateName(members);
                }
                else if (num == 4)
                {
                    // Update User Id
                    Ch_2_UpdateID(members);
                }
                else if (num == 5)
                {
                    // Update Book
                    Ch_2_UpdateBook(members);
                }
                Console.ReadKey();
            }
        }
        static void Ch_2_Menu()
        {
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Update name");
            Console.WriteLine("4. Update book");
            Console.WriteLine("5. Update ID");
            Console.WriteLine("6. Exit");
        }
        static Member Ch_2_Input()
        {
            Member member = new Member();
            Console.WriteLine("write the name of the person");
            member.Name = Console.ReadLine();
            Console.WriteLine("write the Id of the member");
            member.Member_ID = Console.ReadLine();
            Console.WriteLine("write the Money in the Bank");
            member.money_In_Bank = int.Parse(Console.ReadLine());
            return member;
        }
        static void DisplayBookData(List<Member> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                members[i].Num_of_Books = members[i].books.Count;
                Console.WriteLine($"{i}\t {members[i].Name}\t{members[i].Member_ID}\t{members[i].Num_of_Books}");
                for (int j = 0; j < members[i].books.Count; j++)
                {
                    Console.WriteLine($" {members[i].books[j]}");
                }
            }
        }
        static void DisplayBookData2(List<Member> members, int num)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (i == num)
                {
                    members[i].Num_of_Books = members[i].books.Count;
                    Console.WriteLine($"{i}\t {members[i].Name}\t{members[i].Member_ID}\t{members[i].Num_of_Books}\t");
                    for (int j = 0; j < members[i].books.Count; j++)
                    {
                        Console.WriteLine($" {members[i].books[j]}");
                    }
                }
            }
        }
        static void AddBook(List<Member> members)
        {
            DisplayBookData(members);
            int num = CheckNum();
            Member men = members[num];
            Console.WriteLine("Enter the name of the book: ");
            string name = Console.ReadLine();
            men.books.Add(name);
            Console.WriteLine("Enter the price of the book: ");
            men.Price = int.Parse(Console.ReadLine());
            men.money_In_Bank -= men.Price;
            men.money_Spent += men.Price;
        }
        static void Ch_2_UpdateBook(List<Member> members)
        {
            DisplayBookData(members);
            int num = CheckNum();
            DisplayBookData2(members, num);
            int num2 = CheckNum();
            Member men = members[num];
            men.books.RemoveAt(num2);
            Console.WriteLine("Enter the price of the book: ");
            men.Price = int.Parse(Console.ReadLine());
            men.money_In_Bank += men.Price;
            men.money_Spent -= men.Price;
        }
        static void Ch_2_UpdateName(List<Member> members)
        {
            DisplayBookData(members);
            int num = CheckNum();
            members[num].Name = Console.ReadLine();
        }
        static void Ch_2_UpdateID(List<Member> members)
        {
            DisplayBookData(members);
            int num = CheckNum();
            members[num].Member_ID = Console.ReadLine();
        }
        static void Chalenge1()
        {
            int num = 0;
            List<Book> books = new List<Book>();
            while (num < 9)
            {
                Console.Clear();
                num = CheckNum();
                Ch_1_Menu();
                if (num == 1)
                {   // input Book Data 
                    Book book = Ch_1_Input();
                    books.Add(book);
                    Console.ReadKey();
                }
                else if (num == 2)
                {    // Add Authors
                    Add_Authors(books);
                }
                else if (num == 3)
                {     // update title
                    Updatetitle(books);
                }
                else if (num == 4)
                {    //Update Stock
                    UpdateStock(books);
                }
                else if (num == 5)
                {     //Update ISBN
                    UpdateISBN(books);
                }
                else if (num == 6)
                {
                    //Update publisher
                    UpdatePublisher(books);
                }
                else if (num == 7)
                {    //Update Author
                    UpdateAuthor(books);
                }
                else if (num == 8)
                {
                    // Display All Data
                    DisplayAlldata(books);
                }
                Console.ReadKey();
            }
        }
        static void Ch_1_Menu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Authors");
            Console.WriteLine("3. Update title");
            Console.WriteLine("4. Update Stock");
            Console.WriteLine("5. Update ISBN");
            Console.WriteLine("6. Update Publisher");
            Console.WriteLine("7. Update Author");
            Console.WriteLine("8. Display Data");
            Console.WriteLine("9. Exit");
        }
        static Book Ch_1_Input()
        {
            Book book = new Book();
            Console.WriteLine("write the title of the book");
            book.Title = Console.ReadLine();
            Console.WriteLine("write the price of the book");
            book.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("write the publisher of the book");
            book.publisher = Console.ReadLine();
            Console.WriteLine("write the copies available in stock");
            book.stock = int.Parse(Console.ReadLine());
            Console.WriteLine("write the ISBN of the book");
            book.ISBN = Console.ReadLine();
            return book;
        }
        static void Add_Authors(List<Book> books)
        {
            int num;
            int loop;
            Ch_1_DisplayData(books);
            num = CheckNum();
            Console.WriteLine("Enter the number of Aurthors You want to Add (The Number Should Not be greater than 4): ");
            loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                books[num].AuthrName[i] = Console.ReadLine();
            }
        }
        static void Ch_1_DisplayData(List<Book> books)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                Console.WriteLine($"{i} The Title of the book is: {books[i].Title}");
                Console.WriteLine($"    The Stock of the book is: {books[i].stock}");
                Console.WriteLine($"    The ISBN of the book is: {books[i].ISBN}");
                Console.WriteLine($"    The pages of the book is: {books[i].pages}");
                Console.WriteLine($"    The publisher of the book is: {books[i].publisher}");
            }
        }
        static int CheckNum()
        {
            int num;
            Console.WriteLine("Enter the Index: ");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static void Updatetitle(List<Book> books)
        {
            int num;
            Ch_1_DisplayData(books);
            num = CheckNum();
            books[num].Title = Console.ReadLine();
        }
        static void UpdateStock(List<Book> books)
        {
            int num;
            Ch_1_DisplayData(books);
            num = CheckNum();
            books[num].stock = int.Parse(Console.ReadLine());
        }
        static void UpdateISBN(List<Book> books)
        {
            int num;
            Ch_1_DisplayData(books);
            num = CheckNum();
            books[num].ISBN = Console.ReadLine();
        }
        static void UpdatePublisher(List<Book> books)
        {
            int num;
            Ch_1_DisplayData(books);
            num = CheckNum();
            books[num].publisher = Console.ReadLine();
        }
        static void DisplayAuthors(List<Book> books, int num)
        {
            for (int j = 0; j < books[num].AuthrName.Length; j++)
            {
                Console.WriteLine($"{books[num].AuthrName[j]}");
            }
        }
        static void UpdateAuthor(List<Book> books)
        {
            int num;
            int num2;
            Ch_1_DisplayData(books);
            num = CheckNum();
            DisplayAuthors(books, num);
            num2 = CheckNum();
            books[num].AuthrName[num2] = Console.ReadLine();
        }
        static void DisplayAlldata(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i} The Title of the book is: {books[i].Title}");
                Console.WriteLine($"    The Stock of the book is: {books[i].stock}");
                Console.WriteLine($"    The ISBN of the book is: {books[i].ISBN}");
                Console.WriteLine($"    The pages of the book is: {books[i].pages}");
                Console.WriteLine($"    The publisher of the book is: {books[i].publisher}");
                Console.WriteLine("    The Authors of the book are Given: ");
                for (int j = 0; j < books[i].AuthrName.Length; j++)
                {
                    Console.WriteLine($"{books[i].AuthrName[j]}");
                }
            }
        }









        static void SelfAssessment2()
        {
            string result;
            List<Book> books = new List<Book>();
            Book book = new Book();
            int num = 0;
            while (num <= 5)
            {
                Console.Clear();
                num = menu();
                if (num == 1)
                {
                    book = Data();
                    books.Add(book);
                }
                else if (num == 2)
                {
                    if (Availability(books) == true)
                    {
                        Console.WriteLine("The book is Available");
                    }
                    else
                    {
                        Console.WriteLine("The book is not available");
                    }
                }
                else if (num == 3)
                {
                    AddChapters(books);
                }
                else if (num == 4)
                {
                    result = Chapter(books);
                    Console.WriteLine(result);
                }
                else if (num == 5)
                {
                    int booMark;
                    booMark = getBookMark(books);
                    Console.WriteLine($"The Book mark is given on the page {booMark}");
                }
                Console.ReadKey();
            }

        }
        static int menu()
        {
            int idx;
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Check Book Availability");
            Console.WriteLine("3. Add Chapter");
            Console.WriteLine("4. Get Chapter of a book");
            Console.WriteLine("5. Get Book Mark");
            idx = int.Parse(Console.ReadLine());
            return idx;
        }
        static Book Data()
        {
            Book book = new Book();
            Console.WriteLine("write the title of the book");
            book.Title = Console.ReadLine();
            Console.WriteLine("write the author of the book");
            book.Author = Console.ReadLine();
            Console.WriteLine("write the number of pages of the book");
            book.pages = int.Parse(Console.ReadLine());
            Console.WriteLine("write the price of the book");
            book.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("write the status of the book");
            book.Available = bool.Parse(Console.ReadLine());
            Console.WriteLine("write the page number of the book mark");
            book.bookMark = int.Parse(Console.ReadLine());
            return book;
        }
        static bool Availability(List<Book> books)
        {
            string name;
            Console.WriteLine("The titles of the books are given ");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i].Title);
            }
            Console.WriteLine("Enter the name of the book: ");
            name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == name)
                {
                    return true;
                }
            }
            return false;
        }
        static void AddChapters(List<Book> books)
        {
            string name;
            string Chapter;
            int count;
            Console.WriteLine("The Titles of books: ");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i}\t{books[i].Title}");
            }
            Console.WriteLine("Enter the title of the book");
            name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (name == books[i].Title)
                {
                    Console.WriteLine("Enter the number of chapters you want to add");
                    count = int.Parse(Console.ReadLine());
                    for (int j = 0; i < count; j++)
                    {
                        Console.WriteLine("Enter the name of the Chapter:");
                        Chapter = Console.ReadLine();
                        books[i].Chapters.Add(Chapter);
                    }
                }
            }
        }
        static string Chapter(List<Book> books)
        {
            string name;
            string Chapter;
            Console.WriteLine("The Titles of books: ");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i}\t{books[i].Title}");
            }
            Console.WriteLine("Enter the title of the book");
            name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (name == books[i].Title)
                {
                    for (int j = 0; j < books[i].Chapters.Count; j++)
                    {
                        Console.WriteLine($"{j}\t{books[i].Chapters[j]}");
                    }
                    Console.WriteLine("Enter the name of Chapter: ");
                    Chapter = Console.ReadLine();
                    for (int j = 0; j < books[i].Chapters.Count; j++)
                    {
                        if (Chapter == books[i].Chapters[j])
                        {
                            return Chapter;
                        }
                    }
                    break;
                }
            }
            return "No Such Chapter Exits";
        }
        static int getBookMark(List<Book> books)
        {
            string name;
            Console.WriteLine("The Titles of books: ");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i}\t{books[i].Title}");
            }
            Console.WriteLine("Enter the title of the book");
            name = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (name == books[i].Title)
                {
                    return books[i].bookMark;
                }
            }
            return 0;
        }
        static void SelfAssessment1()
        {
            Student student = new Student();
            float merit;
            merit = student.CalculateMerit();
            bool Scholarship;
            Scholarship = student.Scholarship(merit);
            Console.WriteLine($"The merit of student is {merit}\nThe scholarship satus of the student is {Scholarship}");
            Console.ReadKey();
        }
    }
}
