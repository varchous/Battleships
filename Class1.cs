using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    class kletka:Button,ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int s;
        public object Clone()
        {
            kletka c = new kletka { x = this.x, y = this.y, s = this.s };
            c.Location = this.Location;
            c.Size = this.Size;
            c.BackgroundImage = this.BackgroundImage;
            return (kletka)c;
       

        }
    }
    public interface ICloneable
    {
        object Clone();
    }
}
