using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourText
{
  public class Text_Box
    {
       public string name
       {
           get;
           set;
       }
       public string val
       {
           get;
           set;
       }
        public Text_Box(string text, string name)
        {
            this.val = text;
            this.name = name;
        }
    }
}

