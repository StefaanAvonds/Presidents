using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presidents.Models
{
    public class President
    {
        private string _name;
        private int _position;
        private string _image;

        public String Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }
        public String Image
        {
            get { return _image; }
            private set { _image = value; }
        }

        public President(string name, int position, string image)
        {
            Name = name;
            Position = position;
            Image = image;
        }
    }
}
