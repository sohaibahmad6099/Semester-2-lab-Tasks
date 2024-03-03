using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_6.BL;

namespace Week_6.DL
{
    internal class WorkoutRoutineDL
    {
        public static List<WorkOutRoutine> workOutRoutines = new List<WorkOutRoutine>();

        public static void AddWorkOut(string Name,float Weight,Exercise ex)
        {
            WorkOutRoutine workOutRoutine = new WorkOutRoutine();
            workOutRoutine.AddWorkoutRoutine(Name, Weight, ex);
            workOutRoutines.Add(workOutRoutine);
        }
        public static void RemoveWorkOut(int num) 
        {
            workOutRoutines.RemoveAt(num);
        }
        public static void AddExercise(int num,Exercise ex) 
        {
            workOutRoutines[num].AddExercise(ex);
        }
        public static void RemoveExercise(int num,int num2)
        {
            workOutRoutines[num].RemoveExercise(num2);
        }
        public static void DisplayData()
        {
            for(int i=0;i<workOutRoutines.Count;i++) 
            {
                Console.WriteLine($"{i}\t{workOutRoutines[i].GetName()}\t{workOutRoutines[i].GetWeight()}");
                for(int j = 0; j < workOutRoutines[i].GetExercise().Count;j++)
                {
                    Console.WriteLine($"\t{j}\t{workOutRoutines[i].GetExerciseOne(j).GetNameOfExercise()}\t{workOutRoutines[i].GetExerciseOne(j).GetWeight()}" +
                        $"\t{workOutRoutines[i].GetExerciseOne(j).GetRepitition()}\t{workOutRoutines[i].GetExerciseOne(j).GetSets()}");
                }
            }
        }
        public static void DisplayPerson()
        {
            for (int i = 0; i < workOutRoutines.Count; i++)
            {
                Console.WriteLine($"{i}\t{workOutRoutines[i].GetName()}\t{workOutRoutines[i].GetWeight()}");
            }
        }
        public static void DisplayRoutines(int num)
        {
                Console.WriteLine($"{num}\t{workOutRoutines[num].GetName()}\t{workOutRoutines[num].GetWeight()}");
                for (int j = 0; j < workOutRoutines[num].GetExercise().Count; j++)
                {
                    Console.WriteLine($"\t{j}\t{workOutRoutines[num].GetExerciseOne(j).GetNameOfExercise()}\t{workOutRoutines[num].GetExerciseOne(j).GetWeight()}" +
                        $"\t{workOutRoutines[num].GetExerciseOne(j).GetRepitition()}\t{workOutRoutines[num].GetExerciseOne(j).GetSets()}");
                }
        }

    }
}
