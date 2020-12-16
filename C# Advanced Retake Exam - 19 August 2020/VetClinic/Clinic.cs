using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> petsList;
        private int capacity;

        public Clinic(int capacity)
        {
            this.petsList = new List<Pet>(capacity);
            this.Capacity = capacity;
        }

        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            if (this.Count < this.Capacity)
            {
                this.petsList.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = this.petsList.FirstOrDefault(x => x.Name == name);

            if (pet != null)
            {
                this.petsList.Remove(pet);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = this.petsList.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }

        public Pet GetOldestPet()
        {
            Pet pet = this.petsList.OrderByDescending(x => x.Age)
                .FirstOrDefault();

            return pet;
        }

        public int Count
        {
            get
            {
                return this.petsList.Count;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in petsList)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
