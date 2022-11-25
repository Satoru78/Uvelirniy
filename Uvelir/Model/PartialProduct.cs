using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uvelir.Context;

namespace Uvelir.Model
{
    partial class Product
    {
        public string GetImage
        {
            get
            {
                return Environment.CurrentDirectory + "\\" + Image;
            }
            set
            {
                Image = value;
            }
        }

        public string Color
        {
            get
            {
                if (this.Discount > 0)
                    return "Green";
                else
                    return "";
            }
        }
    }
}
