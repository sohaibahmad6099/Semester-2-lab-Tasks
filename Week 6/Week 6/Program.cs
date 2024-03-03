using System;
using Week_6.BL;
using Week_6.DL;
using Week_6.UI;

namespace Week_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
        }
        static void Task4()
        {
            int Id;
            int num;
            int num2;
            string UserName;
            string Comments;
            Posts posts;
            string post;
            int state = 0;
            while (state < 5)
            {
                PostsUI.Menu();
                state = PostsUI.Id();
                Console.Clear();
                if (state == 1)
                {
                    // Add Person
                    Id = PostsUI.Id();
                    UserName = PostsUI.Name();
                    post = PostsUI.Post();
                    posts = new Posts(post);
                    PostsDL.AddPerson(Id, UserName, posts);
                }
                else if (state == 2)
                {
                    // Remove Person
                    PostsDL.DisplayData();
                    Id = PostsUI.Id();
                    PostsDL.RemovePerson(Id);
                }
                else if (state == 3)
                {
                    // Add Post
                    PostsDL.DisplayData();
                    Id = PostsUI.Id();
                    post = PostsUI.Post();
                    posts = new Posts(post);
                    PostsDL.AddPost(Id, posts);
                }
                else if (state == 4)
                {
                    // Remove Post
                    PostsDL.DisplayData();
                    Id = PostsUI.Id();
                    num = PostsUI.Id();
                    PostsDL.RemovePost(Id, num);
                }
                else if (state == 5)
                {
                    // Add Comment
                    PostsDL.DisplayData();
                    Id = PostsUI.Id();
                    num = PostsUI.Id();
                    num2 = PostsUI.Id();
                    PostsDL.RemoveComment(Id, num, num2);
                }
            }
        }
        static void Task3()
        {
            string Name;
            string Name2;
            float Weight;
            float Weight2;
            int Sets;
            string Repitition;
            int num;
            int num2;
            Exercise ex;
            int state = 0;
            while (state < 7)
            {
                WorkoutRoutineUI.Menu();
                state = WorkoutRoutineUI.Index();
                Console.Clear();
                if (state == 1)
                {
                    // Display All data
                    WorkoutRoutineDL.DisplayData();
                }
                else if (state == 2)
                {
                    // Display data of Workout Routine of a person
                    WorkoutRoutineDL.DisplayPerson();
                    num = WorkoutRoutineUI.Index();
                    WorkoutRoutineDL.DisplayRoutines(num);
                }
                else if (state == 3)
                {
                    // Add Workout Routine;
                    Name = WorkoutRoutineUI.Name();
                    Weight = WorkoutRoutineUI.Weight();
                    Name2 = WorkoutRoutineUI.NameEx();
                    Weight2 = WorkoutRoutineUI.WeightEx();
                    Repitition = WorkoutRoutineUI.Repitition();
                    Sets = WorkoutRoutineUI.EnterSets();
                    ex = new Exercise(Name2, Weight2, Repitition, Sets);
                    WorkoutRoutineDL.AddWorkOut(Name, Weight, ex);
                }
                else if (state == 4)
                {
                    // Add Exercise
                    WorkoutRoutineDL.DisplayPerson();
                    num = WorkoutRoutineUI.Index();
                    Name2 = WorkoutRoutineUI.NameEx();
                    Weight2 = WorkoutRoutineUI.WeightEx();
                    Repitition = WorkoutRoutineUI.Repitition();
                    Sets = WorkoutRoutineUI.EnterSets();
                    ex = new Exercise(Name2, Weight2, Repitition, Sets);
                    WorkoutRoutineDL.AddExercise(num, ex);
                }
                else if (state == 5)
                {
                    // remove Exercise
                    WorkoutRoutineDL.DisplayPerson();
                    num = WorkoutRoutineUI.Index();
                    WorkoutRoutineDL.DisplayRoutines(num);
                    num2 = WorkoutRoutineUI.Index();
                    WorkoutRoutineDL.RemoveExercise(num, num2);
                }
                else if (state == 6)
                {
                    // remove Person
                    WorkoutRoutineDL.DisplayPerson();
                    num = WorkoutRoutineUI.Index();
                    WorkoutRoutineDL.RemoveWorkOut(num);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Task2()
        {
            int num, num2, state = 0;
            string Name;
            string Name2;
            string Singer;
            string Writer;
            while (state < 5)
            {
                Console.Clear();
                PlayListUI.Menu();
                state = PlayListUI.Index();
                if (state == 1)
                {
                    // Display Songs
                    PlaylistDL.DisplaySongs();
                }
                else if (state == 2)
                {
                    // REMOVE SONG
                    PlaylistDL.DisplayPlaylists();
                    num = PlayListUI.Index();
                    PlaylistDL.DisplaySong(num);
                    num2 = PlayListUI.IndexOfSong();
                    PlaylistDL.RemoveSong(num, num2);
                }
                else if (state == 3)
                {
                    // Add Playlist
                    Name2 = PlayListUI.NameOfPlaylist();
                    Name = PlayListUI.NameOfSong();
                    Singer = PlayListUI.Singer();
                    Writer = PlayListUI.Writer();
                    PlaylistDL.AddPlayList(Name, Name2, Writer, Singer);
                }
                else if (state == 4)
                {
                    // Add Song
                    PlaylistDL.DisplayPlaylists();
                    num = PlayListUI.Index();
                    Name2 = PlayListUI.Name();
                    Singer = PlayListUI.Singer();
                    Writer = PlayListUI.Writer();
                    PlaylistDL.AddSong(num, Name2, Writer, Singer);
                }
                else
                {
                    break;
                }
                Console.ReadKey();
            }
        }
        static void Task1()
        {
            int Id;
            Author author;
            string Name;
            string AuthorName;
            int Age;
            bool state = true;

            while (state == true)
            {
                Id = BookUI.IdInput();
                Name = BookUI.BookName();
                AuthorName = BookUI.AuthorName();
                Age = BookUI.Age();
                author = new Author(AuthorName, Age);
                BookDL.AddBook(Id, Name, author);
                state = bool.Parse(Console.ReadLine());
            }

            // Remove Book
            BookDL.DisplayBook(); Id = BookUI.IdRemove();
            BookDL.RemoveBook(Id); BookDL.DisplayBook();
            Console.ReadKey();
        }
    }
}
