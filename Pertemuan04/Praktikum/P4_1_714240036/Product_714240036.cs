using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240036
{
    public abstract class Product_714240036
    {
        // Field Pribadi (Backing Fields) - Direkomendasikan menggunakan underscore
        private string _myType;
        private string _mytitle;

        public Product_714240036()
        {
        }

        public Product_714240036(string type, string title)
        {
            _myType = type;
            _mytitle = title;
        }

        public string MyType
        {
            get
            {
                return _myType;
            }
            set
            {
                _myType = value;
            }
        }
        public string MyTitle
        {
            get { return _mytitle; }
            set { _mytitle = value; }
        }

        public abstract void DisplayInfo();
    }
}