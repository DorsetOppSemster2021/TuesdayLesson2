using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuesdayLesson2
{
    public class SuperHero
    {
      

        private string _myName;

        public SuperHero(string name)
        {
            _myName = name;
        }
        public string SampleMethod()
        {
            return "This is a sample method";
        }

        public string GetName()
        {
            return _myName;
        }



    }
}
