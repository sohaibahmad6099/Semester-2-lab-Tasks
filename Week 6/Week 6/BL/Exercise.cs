using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6.BL
{
    internal class Exercise
    {
        private string NameOfExercise;
        private float WeightOfLifting;
        private string Repitition;
        private int Sets;
        public Exercise() { }
        public Exercise(string nameOfExercise, float weightOfLifting, string repitition, int sets)
        {
            NameOfExercise = nameOfExercise;
            WeightOfLifting = weightOfLifting;
            Repitition = repitition;
            Sets = sets;
        }

        public void SetNameOfExercise(string Name)
        {
            NameOfExercise = Name;
        }
        public void SetWeightToLift(int Weight)
        {
            WeightOfLifting = Weight;
        }
        public void SetRepition(string Repitition)
        {
            this.Repitition = Repitition;
        }
        public void SetSets(int Sets)
        {
            this.Sets = Sets;
        }
        public string GetRepitition() 
        {
            return Repitition;
        }
        public int GetSets() 
        {
            return Sets;
        }
        public float GetWeight()
        {
            return WeightOfLifting;
        }
        public string GetNameOfExercise()
        {
            return NameOfExercise;
        }
    }
}
