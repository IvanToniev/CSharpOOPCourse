using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gsm
{
    class Display
    {
        private int? size;
        private int? numOfColors;

        public int? Size 
        {
            get 
            {
                return this.size; 
            }
            set
            {
                if (value > 1 || value == null)
                {
                    this.size = value;
                }
                else 
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? NumOfColors
        {
            get 
            {
                return this.numOfColors;
            }
            set 
            {
                if (value > 3 || value == null)
                {
                    this.numOfColors = value;
                }
                else 
                {
                    throw new ArgumentException();
                }
            }
        }

        public Display(int? size,int? numOfColors) 
        {
            this.Size = size;
            this.NumOfColors = numOfColors;
        }

        public Display(int size)
            :this(size,null)
        {
        }

        public Display()
            :this(null,null)
        {
        }

        public override string ToString()
        {
            return String.Format("Display(Size: {0} inches, Colors: {1}){2}",this.size,this.numOfColors,'\n');
        }
    }
}
