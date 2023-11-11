using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo.Models
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; }
        public List<Caretaker> Caretakers { get; set; }

        public Zoo()
        {
            Animals = new List<Animal>();
            Caretakers = new List<Caretaker>();
        }

        public void AssignCaretaker(Animal animal, Caretaker caretaker)
        {
            // Hayvan ile bakıcı arasında bir ilişki kurulabilir.
        }
    }
}
