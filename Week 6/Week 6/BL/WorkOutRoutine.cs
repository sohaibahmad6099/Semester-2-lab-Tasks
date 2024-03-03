using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class WorkOutRoutine
    {
        private string Name;
        private float Weight;
        private List<Exercise> exercises = new List<Exercise>();
        public void AddWorkoutRoutine(string Name,float Weight,Exercise exercise)
        {
            this.Name = Name;
            this.Weight = Weight;
            Exercise ex = exercise;
            exercises.Add(ex);
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetWeight(float Weight) 
        {
            this.Weight = Weight;
        }
        public void AddExercise(Exercise exercise) 
        {
            exercises.Add(exercise);
        }
        public void RemoveExercise(int num)
        {
            exercises.RemoveAt(num);
        }
        public string GetName()
        {
            return Name;
        }
        public float GetWeight()
        {
            return Weight;
        }
        public List<Exercise> GetExercise()
        {
            return exercises;
        }
        public Exercise GetExerciseOne(int num) 
        {
            return exercises[num];
        }
    }
}
