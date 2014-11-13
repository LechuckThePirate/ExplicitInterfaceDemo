using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Disambiguation
{
    public class Movie : IMovie
    {
        private string _title;
        private int _year;

        public Movie(string title, int year)
        {
            _title = title;
            _year = year;
        }
        public string GetTitle()
        {
            return string.Format("{0} ({1})", _title, _year);
        }
    }
}
