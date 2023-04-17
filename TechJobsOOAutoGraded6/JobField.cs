using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        public JobField() 
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return Value;
        }
    }
}

    //make parent class, call job field, that parent class is supposed to have everything is repeated in subclasses, make a constructor in subclasses that takes from parent class