using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonProject
{

    /*Id	Name	Age	WorkPlace
	Marie	30	Get Academy*/
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string WorkPlace { get; set; }
    }
}
