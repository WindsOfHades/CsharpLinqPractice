using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPractice
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int UniverityId { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Id} - {this.Gender} - {this.Age} - {this.UniverityId}";
        }
    }
}
