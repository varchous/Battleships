using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        kletka[,] k = new kletka[10, 10];
        kletka[,] k1 = new kletka[10, 10];
        kletka[,] k2 = new kletka[10, 10];
        kletka[,] k3 = new kletka[10, 10];
        int kol = 0;
        int flag = 0, hod = 0;
        Button b = new Button();
        Button b1 = new Button();
        Button b2 = new Button();
        Button b3 = new Button();
        int flag2 = 0;
        Bitmap[,] kk = new Bitmap[10, 10];
        int[,] kk2 = new int[10, 10];
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            Bitmap B5 = new Bitmap(@"G:\13.bmp");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    k[i, j] = new kletka();
                    k2[i, j] = new kletka();
                    k[i, j].Size = new Size(54, 54);
                    k2[i, j].Size = new Size(54, 54);
                    k1[i, j] = new kletka();
                    k[i, j].Location = new Point((55 * j) + 100, 55 * (i + 1));
                    k2[i, j].Location = new Point((55 * j) + 700, 55 * (i + 1));
                    Bitmap B = new Bitmap(@"G:\1.bmp");
                    k[i, j].BackgroundImage = B;
                    k2[i, j].BackgroundImage = B;
                    frm.Controls.Add(k2[i, j]);
                    frm.Controls.Add(k[i, j]);
                    k2[i, j].Hide(); 
                    k[i, j].x = i;
                    k[i, j].y = j;
                    k[i, j].s = 0;
                    k[i, j].TabStop = false;
                    k2[i, j].x = i;
                    k2[i, j].y = j;
                    k2[i, j].s = 0;
                    k2[i, j].TabStop = false;
                }
            }
            b.Size = new Size(120, 120);
            b.Location = new Point(600, 650);
            Bitmap B2 = new Bitmap(@"G:\4.bmp");
            b.Click += new EventHandler(Click22);
            b.TabStop = false;
            b.BackgroundImage = B2;
            frm.Controls.Add(b);

            b1.Size = new Size(120, 120);
            b1.Location = new Point(775, 650);
            b1.Click += new EventHandler(Click5);
            Bitmap B3 = new Bitmap(@"G:\11.bmp");
            b1.TabStop = false;
            b1.BackgroundImage = B3;
            frm.Controls.Add(b1);

            b2.Size = new Size(120, 120);
            b2.Location = new Point(1125, 650);
            b2.Click += new EventHandler(Click6);
            Bitmap B4 = new Bitmap(@"G:\12.bmp");
            b2.TabStop = false;
            b2.BackgroundImage = B4;
            frm.Controls.Add(b2);

            b3.Size = new Size(120, 120);
            b3.Location = new Point(950, 650);
            b3.Click += new EventHandler(NEW);
            Bitmap B45 = new Bitmap(@"G:\16.bmp");
            b3.BackgroundImage = B45;
            b3.TabStop = false;
            frm.Controls.Add(b3);

            frm.Show();
            frm.Activate();
        }
        public void NEW(object sender, EventArgs e)
        {
            flag2 = 0;
            kol = 0;
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        k[i, j].s = 0;
                        k1[i, j].s = 0;
                        k[i, j].BackgroundImage = B;
                        k1[i, j].BackgroundImage = B;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        k[i, j].Click += new EventHandler(CC);
                        k[i, j].MouseEnter += new EventHandler(MouseEnter4);
                        k[i, j].MouseLeave += new EventHandler(MouseLeave4);
                    }
                }

            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        k2[i, j].s = 0;
                        k1[i, j].s = 0;
                        k2[i, j].BackgroundImage = B;
                        k1[i, j].BackgroundImage = B;
                    }
                }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            k2[i, j].Click += new EventHandler(CC);
                            k2[i, j].MouseEnter += new EventHandler(MouseEnter4);
                            k2[i, j].MouseLeave += new EventHandler(MouseLeave4);
                        }
                    }

                }
            }
        
        public void CC(object sender, EventArgs e)
        {
            int x = 11, y = 11;
            if (hod == 0)
            {
                if (kol == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if(sender.Equals(k[i,j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if(C4(x,y)==1)
                    {
                        kol++;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k[i, j].MouseEnter -= new EventHandler(MouseEnter4);
                                k[i, j].MouseLeave -= new EventHandler(MouseLeave4);
                                k[i, j].MouseEnter += new EventHandler(MouseEnter3);
                                k[i, j].MouseLeave += new EventHandler(MouseLeave3);
                            }
                        }
                    }
                    return;
                }
                if(kol>0 && kol<3)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C3(x, y) == 1)
                    {
                        kol++;
                        if (kol == 3)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].MouseEnter -= new EventHandler(MouseEnter3);
                                    k[i, j].MouseLeave -= new EventHandler(MouseLeave3);
                                    k[i, j].MouseEnter += new EventHandler(MouseEnter2);
                                    k[i, j].MouseLeave += new EventHandler(MouseLeave2);
                                }
                            }
                        }
                    }
                    return;
                }
                if (kol >= 3 && kol < 6)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C2(x, y) == 1)
                    {
                        kol++;
                        if (kol == 6)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].MouseEnter -= new EventHandler(MouseEnter2);
                                    k[i, j].MouseLeave -= new EventHandler(MouseLeave2);
                                    k[i, j].MouseEnter += new EventHandler(MouseEnter1);
                                    k[i, j].MouseLeave += new EventHandler(MouseLeave1);
                                }
                            }
                        }
                    }
                    return;
                }
                if (kol >= 6 && kol <= 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C1(x, y) == 1)
                    {
                        kol++;
                        if (kol == 10)
                        {
                            flag2 = 1;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].MouseEnter -= new EventHandler(MouseEnter1);
                                    k[i, j].MouseLeave -= new EventHandler(MouseLeave1);
                                    k[i, j].Click -= new EventHandler(CC);
                                }
                            }
                        }
                    }
                    return;
                }

            }
            if(hod==1)
            {
                if (kol == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k2[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C4(x, y) == 1)
                    {
                        kol++;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k2[i, j].MouseEnter -= new EventHandler(MouseEnter4);
                                k2[i, j].MouseLeave -= new EventHandler(MouseLeave4);
                                k2[i, j].MouseEnter += new EventHandler(MouseEnter3);
                                k2[i, j].MouseLeave += new EventHandler(MouseLeave3);
                            }
                        }
                    }
                    return;
                }
                if (kol > 0 && kol < 3)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k2[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C3(x, y) == 1)
                    {
                        kol++;
                        if (kol == 3)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].MouseEnter -= new EventHandler(MouseEnter3);
                                    k2[i, j].MouseLeave -= new EventHandler(MouseLeave3);
                                    k2[i, j].MouseEnter += new EventHandler(MouseEnter2);
                                    k2[i, j].MouseLeave += new EventHandler(MouseLeave2);
                                }
                            }
                        }
                    }
                    return;
                }
                if (kol >= 3 && kol < 6)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k2[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C2(x, y) == 1)
                    {
                        kol++;
                        if (kol == 6)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].MouseEnter -= new EventHandler(MouseEnter2);
                                    k2[i, j].MouseLeave -= new EventHandler(MouseLeave2);
                                    k2[i, j].MouseEnter += new EventHandler(MouseEnter1);
                                    k2[i, j].MouseLeave += new EventHandler(MouseLeave1);
                                }
                            }
                        }
                    }
                    return;
                }
                if (kol >= 6 && kol <= 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k2[i, j]))
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }
                    if (C1(x, y) == 1)
                    {
                        kol++;
                        if (kol == 10)
                        {
                            flag2 = 1;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].MouseEnter -= new EventHandler(MouseEnter1);
                                    k2[i, j].MouseLeave -= new EventHandler(MouseLeave1);
                                    k2[i, j].Click -= new EventHandler(CC);
                                }
                            }
                        }
                    }
                    return;
                }
            }
        }
        public void Shot(object sender, EventArgs e)
        {
            Bitmap B1 = new Bitmap(@"G:\14.bmp");
            Bitmap B2 = new Bitmap(@"G:\15.bmp");

            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]))
                        {
                            if (k[i, j].s == 0 || k[i, j].s == 2)
                            {
                                k[i, j].BackgroundImage = B1;
                                k[i, j].s = 3;
                                hod = 1;
                            }
                            if (k[i, j].s == 1)
                            {
                                k[i, j].s = 3;
                                k[i, j].BackgroundImage = B2;
                            }
                        }
                    }
                }
            }
            else
            {
                if (hod == 1)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (sender.Equals(k2[i, j]))
                            {
                                if (k2[i, j].s == 0 || k2[i, j].s == 2)
                                {
                                    k2[i, j].BackgroundImage = B1;
                                    k2[i, j].s = 3;
                                    hod = 0;
                                }
                                if (k2[i, j].s == 1)
                                {
                                    k2[i, j].BackgroundImage = B2;
                                    k2[i, j].s = 3;
                                }
                            }
                        }
                    }
                }
            }
            END();
        }
        public void END()
        {
            int kol1 = 0, kol2 = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (k[i, j].s == 1)
                    {
                        kol1++;
                    }
                    if (k2[i, j].s == 1)
                    {
                        kol2++;
                    }
                }
            }
            if (kol1 == 0)
            {
                hod = 2;
                Form3 frm = new Form3();
                label1.Text = "2 Игрко победил";
                frm.Hide();
                Show();
                button1.Hide();
                button2.Hide();
                Activate();
            }
            if (kol2 == 0)
            {
                Form3 frm = new Form3();
                label1.Text = "1 Игрко победил";
                frm.Hide();
                button1.Hide();
                button2.Hide();
                Show();
                Activate();
            }
        }
        public void Click6(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Form2 frm2 = new Form2();

            Bitmap[,] m2 = new Bitmap[10, 10];
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (flag2 == 1)
            {
                if (hod == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            k[i, j].Hide();
                            k2[i, j].Show();

                        }
                    }
                    hod = 1;
                    flag2 = 0;

                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            frm.Controls.Add(k[i, j]);
                            frm.Controls.Add(k2[i, j]);
                            k[i, j].Click += new EventHandler(Shot);
                            k2[i, j].Click += new EventHandler(Shot);
                            k[i, j].BackgroundImage = B;
                            k2[i, j].BackgroundImage = B;
                            k[i, j].Show();
                            k2[i, j].Show();
                        }

                        frm.Show();
                        frm.Activate();
                        hod = 0;
                    }
                }
            }


        }
        public void Click5(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(@"G:\1.bmp");
            Random r = new Random();

            int x = r.Next(0, 10), y = r.Next(0, 10), f = r.Next(0, 2), p = 1;
            flag2 = 1;
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        k[i, j].s = 0;
                        k1[i, j].s = 0;
                        k[i, j].BackgroundImage = B;
                        k1[i, j].BackgroundImage = B;
                    }
                }
                while (p == 1)
                {
                    if (C4(x, y) == 0)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k[i, j].s = k1[i, j].s;
                                k[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                            }
                        }
                        x = r.Next(0, 10);
                        y = r.Next(0, 10);
                        f = r.Next(0, 2);
                        flag = f;

                    }
                    else
                    {
                        p = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k1[i, j].s = k[i, j].s;
                                k1[i, j].BackgroundImage = k[i, j].BackgroundImage;
                            }
                        }
                    }
                }
                for (int z3 = 0; z3 < 2; z3++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C3(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].s = k1[i, j].s;
                                    k[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k[i, j].s;
                                    k1[i, j].BackgroundImage = k[i, j].BackgroundImage;
                                }
                            }
                        }
                    }
                }
                for (int z2 = 0; z2 < 3; z2++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C2(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].s = k1[i, j].s;
                                    k[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k[i, j].s;
                                    k1[i, j].BackgroundImage = k[i, j].BackgroundImage;
                                }
                            }
                        }
                    }
                }
                for (int z = 0; z < 4; z++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C1(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k[i, j].s = k1[i, j].s;
                                    k[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k[i, j].s;
                                    k1[i, j].BackgroundImage = k[i, j].BackgroundImage;
                                }
                            }
                        }
                    }

                }
            }
            else
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        k2[i, j].s = 0;
                        k1[i, j].s = 0;
                        k2[i, j].BackgroundImage = B;
                        k1[i, j].BackgroundImage = B;
                    }
                }
                while (p == 1)
                {
                    if (C4(x, y) == 0)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k2[i, j].s = k1[i, j].s;
                                k2[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                            }
                        }
                        x = r.Next(0, 10);
                        y = r.Next(0, 10);
                        f = r.Next(0, 2);
                        flag = f;

                    }
                    else
                    {
                        p = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                k1[i, j].s = k2[i, j].s;
                                k1[i, j].BackgroundImage = k2[i, j].BackgroundImage;
                            }
                        }
                    }
                }
                for (int z3 = 0; z3 < 2; z3++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C3(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].s = k1[i, j].s;
                                    k2[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k2[i, j].s;
                                    k1[i, j].BackgroundImage = k2[i, j].BackgroundImage;
                                }
                            }
                        }
                    }
                }
                for (int z2 = 0; z2 < 3; z2++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C2(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].s = k1[i, j].s;
                                    k2[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k2[i, j].s;
                                    k1[i, j].BackgroundImage = k2[i, j].BackgroundImage;
                                }
                            }
                        }
                    }
                }
                for (int z = 0; z < 4; z++)
                {
                    p = 1;
                    while (p == 1)
                    {
                        if (C1(x, y) == 0)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k2[i, j].s = k1[i, j].s;
                                    k2[i, j].BackgroundImage = k1[i, j].BackgroundImage;
                                }
                            }
                            x = r.Next(0, 10);
                            y = r.Next(0, 10);
                            f = r.Next(0, 2);
                            flag = f;

                        }
                        else
                        {
                            p = 0;
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < 10; j++)
                                {
                                    k1[i, j].s = k2[i, j].s;
                                    k1[i, j].BackgroundImage = k2[i, j].BackgroundImage;
                                }
                            }
                        }
                    }

                }
            }
        }
        private kletka[,] Ret()
        {
            return k;
        }
        public void Click22(object sender, EventArgs e)
        {
            Bitmap B = new Bitmap(@"G:\4.bmp");
            Bitmap B2 = new Bitmap(@"G:\10.bmp");
            if (flag == 0) { flag = 1; b.BackgroundImage = B2; }
            else { flag = 0; b.BackgroundImage = B; }
        }
        public int C1(int i, int j)
        {
            if (hod == 0)
            {
                if (k[i, j].s == 0)
                {
                    Bitmap B = new Bitmap(@"G:\2.bmp");
                    Bitmap B2 = new Bitmap(@"G:\9.bmp");
                    k[i, j].BackgroundImage = B;
                    k[i, j].s = 1;
                    for (int g = i - 1; g <= i + 1; g++)
                        for (int h = j - 1; h <= j + 1; h++)
                        {
                            if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                            {
                                if (k[g, h].s == 0)
                                {
                                    k[g, h].BackgroundImage = B2;
                                    k[g, h].s = 2;
                                }
                            }
                        }
                    return 1;
                }
            }
            if (hod == 1)
            {
                if (k2[i, j].s == 0)
                {
                    Bitmap B = new Bitmap(@"G:\2.bmp");
                    Bitmap B2 = new Bitmap(@"G:\9.bmp");
                    k2[i, j].BackgroundImage = B;
                    k2[i, j].s = 1;
                    for (int g = i - 1; g <= i + 1; g++)
                        for (int h = j - 1; h <= j + 1; h++)
                        {
                            if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                            {
                                if (k2[g, h].s == 0)
                                {
                                    k2[g, h].BackgroundImage = B2;
                                    k2[g, h].s = 2;
                                }
                            }
                        }
                    return 1;
                }
            }
            return 0;
        }
        public void Click1(object sender, EventArgs e)
        {
            int i = 11, j = 11;
            if (hod == 0)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k2[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            C1(i, j);

        }
        public int C2(int i, int j)
        {
            Bitmap B = new Bitmap(@"G:\21.bmp");
            Bitmap B2 = new Bitmap(@"G:\22.bmp");
            Bitmap B3 = new Bitmap(@"G:\9.bmp");
            Bitmap B4 = new Bitmap(@"G:\23.bmp");
            Bitmap B5 = new Bitmap(@"G:\24.bmp");
            if (hod == 0)
            {
                if (k[i, j].s == 0 && flag == 0 && j < 9)
                {
                    if (k[i, j + 1].s == 0)
                    {
                        k[i, j].BackgroundImage = B;
                        k[i, j + 1].BackgroundImage = B2;
                        k[i, j].s = 1;
                        k[i, j + 1].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 2; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B3;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
                if (k[i, j].s == 0 && flag == 1 && i < 9)
                {
                    if (k[i + 1, j].s == 0)
                    {
                        k[i, j].BackgroundImage = B5;
                        k[i + 1, j].BackgroundImage = B4;
                        k[i, j].s = 1;
                        k[i + 1, j].s = 1;
                        for (int g = i - 1; g <= i + 2; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B3;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
            }
            if (hod == 1)
            {
                if (k2[i, j].s == 0 && flag == 0 && j < 9)
                {
                    if (k2[i, j + 1].s == 0)
                    {
                        k2[i, j].BackgroundImage = B;
                        k2[i, j + 1].BackgroundImage = B2;
                        k2[i, j].s = 1;
                        k2[i, j + 1].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 2; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B3;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
                if (k2[i, j].s == 0 && flag == 1 && i < 9)
                {
                    if (k2[i + 1, j].s == 0)
                    {
                        k2[i, j].BackgroundImage = B5;
                        k2[i + 1, j].BackgroundImage = B4;
                        k2[i, j].s = 1;
                        k2[i + 1, j].s = 1;
                        for (int g = i - 1; g <= i + 2; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B3;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
            }
            return 0;
        }
        public void Click2(object sender, EventArgs e)
        {
            int i = 11, j = 11;
            if (hod == 0)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k2[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            C2(i, j);

        }
        public int C3(int i, int j)
        {
            Bitmap B = new Bitmap(@"G:\31.bmp");
            Bitmap B1 = new Bitmap(@"G:\32.bmp");
            Bitmap B2 = new Bitmap(@"G:\33.bmp");
            Bitmap B3 = new Bitmap(@"G:\34.bmp");
            Bitmap B4 = new Bitmap(@"G:\35.bmp");
            Bitmap B5 = new Bitmap(@"G:\36.bmp");
            Bitmap B6 = new Bitmap(@"G:\9.bmp");
            if (hod == 0)
            {
                if (k[i, j].s == 0 && flag == 0 && j < 8)
                {
                    if (k[i, j + 1].s == 0 && k[i, j + 2].s == 0)
                    {
                        k[i, j].BackgroundImage = B;
                        k[i, j + 1].BackgroundImage = B1;
                        k[i, j + 2].BackgroundImage = B2;
                        k[i, j].s = 1;
                        k[i, j + 1].s = 1;
                        k[i, j + 2].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 3; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B6;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
                if (k[i, j].s == 0 && flag == 1 && i < 8)
                {
                    if (k[i + 1, j].s == 0 && k[i + 2, j].s == 0)
                    {
                        k[i, j].BackgroundImage = B5;
                        k[i + 1, j].BackgroundImage = B4;
                        k[i + 2, j].BackgroundImage = B3;
                        k[i, j].s = 1;
                        k[i + 1, j].s = 1;
                        k[i + 2, j].s = 1;
                        for (int g = i - 1; g <= i + 3; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B6;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }

            }
            if (hod == 1)
            {
                if (k2[i, j].s == 0 && flag == 0 && j < 8)
                {
                    if (k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0)
                    {
                        k2[i, j].BackgroundImage = B;
                        k2[i, j + 1].BackgroundImage = B1;
                        k2[i, j + 2].BackgroundImage = B2;
                        k2[i, j].s = 1;
                        k2[i, j + 1].s = 1;
                        k2[i, j + 2].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 3; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B6;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
                if (k2[i, j].s == 0 && flag == 1 && i < 8)
                {
                    if (k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0)
                    {
                        k2[i, j].BackgroundImage = B5;
                        k2[i + 1, j].BackgroundImage = B4;
                        k2[i + 2, j].BackgroundImage = B3;
                        k2[i, j].s = 1;
                        k2[i + 1, j].s = 1;
                        k2[i + 2, j].s = 1;
                        for (int g = i - 1; g <= i + 3; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B6;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }

            }
            return 0;
        }
        public void Click3(object sender, EventArgs e)
        {
            int i = 11, j = 11;
            if (hod == 0)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k2[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            C3(i, j);

        }
        public int C4(int i, int j)
        {
            Bitmap B = new Bitmap(@"G:\41.bmp");
            Bitmap B1 = new Bitmap(@"G:\42.bmp");
            Bitmap B2 = new Bitmap(@"G:\43.bmp");
            Bitmap B3 = new Bitmap(@"G:\44.bmp");
            Bitmap B4 = new Bitmap(@"G:\45.bmp");
            Bitmap B5 = new Bitmap(@"G:\46.bmp");
            Bitmap B6 = new Bitmap(@"G:\47.bmp");
            Bitmap B7 = new Bitmap(@"G:\48.bmp");
            Bitmap B8 = new Bitmap(@"G:\9.bmp");
            if (hod == 0)
            {
                if (k[i, j].s == 0 && flag == 0 && j < 7)
                {
                    if (k[i, j + 1].s == 0 && k[i, j + 2].s == 0 && k[i, j + 3].s == 0)
                    {
                        k[i, j].BackgroundImage = B;
                        k[i, j + 1].BackgroundImage = B1;
                        k[i, j + 2].BackgroundImage = B2;
                        k[i, j + 3].BackgroundImage = B3;
                        k[i, j].s = 1;
                        k[i, j + 1].s = 1;
                        k[i, j + 2].s = 1;
                        k[i, j + 3].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 4; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B8;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }

                if (k[i, j].s == 0 && flag == 1 && i < 7)
                {
                    if (k[i + 1, j].s == 0 && k[i + 2, j].s == 0 && k[i + 3, j].s == 0)
                    {
                        k[i, j].BackgroundImage = B7;
                        k[i + 1, j].BackgroundImage = B6;
                        k[i + 2, j].BackgroundImage = B5;
                        k[i + 3, j].BackgroundImage = B4;
                        k[i, j].s = 1;
                        k[i + 1, j].s = 1;
                        k[i + 2, j].s = 1;
                        k[i + 3, j].s = 1;
                        for (int g = i - 1; g <= i + 4; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k[g, h].s == 0)
                                    {
                                        k[g, h].BackgroundImage = B8;
                                        k[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
            }
            if (hod == 1)
            {
                if (k2[i, j].s == 0 && flag == 0 && j < 7)
                {
                    if (k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 && k2[i, j + 3].s == 0)
                    {
                        k2[i, j].BackgroundImage = B;
                        k2[i, j + 1].BackgroundImage = B1;
                        k2[i, j + 2].BackgroundImage = B2;
                        k2[i, j + 3].BackgroundImage = B3;
                        k2[i, j].s = 1;
                        k2[i, j + 1].s = 1;
                        k2[i, j + 2].s = 1;
                        k2[i, j + 3].s = 1;
                        for (int g = i - 1; g <= i + 1; g++)
                        {
                            for (int h = j - 1; h <= j + 4; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B8;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }

                if (k2[i, j].s == 0 && flag == 1 && i < 7)
                {
                    if (k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 && k2[i + 3, j].s == 0)
                    {
                        k2[i, j].BackgroundImage = B7;
                        k2[i + 1, j].BackgroundImage = B6;
                        k2[i + 2, j].BackgroundImage = B5;
                        k2[i + 3, j].BackgroundImage = B4;
                        k2[i, j].s = 1;
                        k2[i + 1, j].s = 1;
                        k2[i + 2, j].s = 1;
                        k2[i + 3, j].s = 1;
                        for (int g = i - 1; g <= i + 4; g++)
                        {
                            for (int h = j - 1; h <= j + 1; h++)
                            {
                                if (g >= 0 && g <= 9 && h >= 0 && h <= 9)
                                {
                                    if (k2[g, h].s == 0)
                                    {
                                        k2[g, h].BackgroundImage = B8;
                                        k2[g, h].s = 2;
                                    }
                                }
                            }
                        }
                        return 1;
                    }
                }
            }
            return 0;
        }
        public void Click4(object sender, EventArgs e)
        {
            int i = 11, j = 11;
            if (hod == 0)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        if (sender.Equals(k2[x, y]))
                        {
                            i = x;
                            j = y;
                        }
                    }
                }
            }
            C4(i, j);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MouseEnter1(object sender, EventArgs e)
        {
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && k[i, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\2.bmp");
                            k[i, j].BackgroundImage = B;


                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && k2[i, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\2.bmp");
                            k2[i, j].BackgroundImage = B;


                        }
                    }
                }
            }
        }

        private void MouseEnter2(object sender, EventArgs e)
        {
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && j < 9 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0)
                        {

                            Bitmap B = new Bitmap(@"G:\21.bmp");
                            Bitmap B2 = new Bitmap(@"G:\22.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B2;


                        }
                        if (sender.Equals(k[i, j]) && i < 9 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0)
                        {

                            Bitmap B = new Bitmap(@"G:\23.bmp");
                            Bitmap B2 = new Bitmap(@"G:\24.bmp");
                            k[i, j].BackgroundImage = B2;
                            k[i + 1, j].BackgroundImage = B;


                        }

                        if (sender.Equals(k[i, j]) && j > 8 && flag == 0 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && i > 8 && flag == 1 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && j < 9 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0)
                        {

                            Bitmap B = new Bitmap(@"G:\21.bmp");
                            Bitmap B2 = new Bitmap(@"G:\22.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B2;


                        }
                        if (sender.Equals(k2[i, j]) && i < 9 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0)
                        {

                            Bitmap B = new Bitmap(@"G:\23.bmp");
                            Bitmap B2 = new Bitmap(@"G:\24.bmp");
                            k2[i, j].BackgroundImage = B2;
                            k2[i + 1, j].BackgroundImage = B;


                        }

                        if (sender.Equals(k2[i, j]) && j > 8 && flag == 0 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && i > 8 && flag == 1 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }
        private void MouseEnter3(object sender, EventArgs e)
        {
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && j < 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\31.bmp");
                            Bitmap B2 = new Bitmap(@"G:\32.bmp");
                            Bitmap B3 = new Bitmap(@"G:\33.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B2;
                            k[i, j + 2].BackgroundImage = B3;
                        }
                        if (sender.Equals(k[i, j]) && i < 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\34.bmp");
                            Bitmap B2 = new Bitmap(@"G:\35.bmp");
                            Bitmap B3 = new Bitmap(@"G:\36.bmp");
                            k[i, j].BackgroundImage = B3;
                            k[i + 1, j].BackgroundImage = B2;
                            k[i + 2, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && j == 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 || j < 8 && sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i == 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 || i < 8 && sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && j == 9 && flag == 0 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && i == 9 && flag == 1 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && j < 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\31.bmp");
                            Bitmap B2 = new Bitmap(@"G:\32.bmp");
                            Bitmap B3 = new Bitmap(@"G:\33.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B2;
                            k2[i, j + 2].BackgroundImage = B3;
                        }
                        if (sender.Equals(k2[i, j]) && i < 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\34.bmp");
                            Bitmap B2 = new Bitmap(@"G:\35.bmp");
                            Bitmap B3 = new Bitmap(@"G:\36.bmp");
                            k2[i, j].BackgroundImage = B3;
                            k2[i + 1, j].BackgroundImage = B2;
                            k2[i + 2, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && j == 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 || j < 8 && sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i == 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 || i < 8 && sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && j == 9 && flag == 0 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && i == 9 && flag == 1 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }

        private void MouseEnter4(object sender, EventArgs e)
        {
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && j < 7 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0 && k[i, j + 3].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\41.bmp");
                            Bitmap B2 = new Bitmap(@"G:\42.bmp");
                            Bitmap B3 = new Bitmap(@"G:\43.bmp");
                            Bitmap B4 = new Bitmap(@"G:\44.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B2;
                            k[i, j + 2].BackgroundImage = B3;
                            k[i, j + 3].BackgroundImage = B4;
                        }

                        if (sender.Equals(k[i, j]) && i < 7 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0 && k[i + 3, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\45.bmp");
                            Bitmap B2 = new Bitmap(@"G:\46.bmp");
                            Bitmap B3 = new Bitmap(@"G:\47.bmp");
                            Bitmap B4 = new Bitmap(@"G:\48.bmp");
                            k[i, j].BackgroundImage = B4;
                            k[i + 1, j].BackgroundImage = B3;
                            k[i + 2, j].BackgroundImage = B2;
                            k[i + 3, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && j == 7 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0 || sender.Equals(k[i, j]) && j < 7 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0 && k[i, j + 3].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                            k[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i == 7 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0 || sender.Equals(k[i, j]) && i < 7 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0 && k[i + 3, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                            k[i + 2, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && j == 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 || sender.Equals(k[i, j]) && j < 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i == 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 || sender.Equals(k[i, j]) && i < 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && j == 9 && flag == 0 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && i == 9 && flag == 1 && k[i, j].s == 0 || sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && j < 7 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 && k2[i, j + 3].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\41.bmp");
                            Bitmap B2 = new Bitmap(@"G:\42.bmp");
                            Bitmap B3 = new Bitmap(@"G:\43.bmp");
                            Bitmap B4 = new Bitmap(@"G:\44.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B2;
                            k2[i, j + 2].BackgroundImage = B3;
                            k2[i, j + 3].BackgroundImage = B4;
                        }

                        if (sender.Equals(k2[i, j]) && i < 7 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 && k2[i + 3, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\45.bmp");
                            Bitmap B2 = new Bitmap(@"G:\46.bmp");
                            Bitmap B3 = new Bitmap(@"G:\47.bmp");
                            Bitmap B4 = new Bitmap(@"G:\48.bmp");
                            k2[i, j].BackgroundImage = B4;
                            k2[i + 1, j].BackgroundImage = B3;
                            k2[i + 2, j].BackgroundImage = B2;
                            k2[i + 3, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && j == 7 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 || sender.Equals(k2[i, j]) && j < 7 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 && k2[i, j + 3].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                            k2[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i == 7 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 || sender.Equals(k2[i, j]) && i < 7 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 && k2[i + 3, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                            k2[i + 2, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && j == 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 || sender.Equals(k2[i, j]) && j < 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i == 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 || sender.Equals(k2[i, j]) && i < 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && j == 9 && flag == 0 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && i == 9 && flag == 1 && k2[i, j].s == 0 || sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 2)
                        {
                            Bitmap B = new Bitmap(@"G:\3.bmp");
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }

        private void MouseLeave1(object sender, EventArgs e)

        {
            Color c = Color.FromName("none");
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && k[i, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\1.bmp");
                            k[i, j].BackgroundImage = B;
                        }

                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && k2[i, j].s == 0)
                        {
                            Bitmap B = new Bitmap(@"G:\1.bmp");
                            k2[i, j].BackgroundImage = B;
                        }

                    }
                }
            }
        }


        private void MouseLeave2(object sender, EventArgs e)

        {
            Color c = Color.FromName("none");
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && j < 9 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && j < 9)
                        {

                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k[i, j]) && i < 9 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0)
                        {

                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k[i, j])&& flag == 0 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j])&& flag == 1 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && j < 9 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && j < 9)
                        {

                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k2[i, j]) && i < 9 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0)
                        {

                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j])&& flag == 1 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }

        private void MouseLeave3(object sender, EventArgs e)

        {
            Color c = Color.FromName("none");
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k[i, j]) && j < 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                            k[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i < 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                            k[i + 2, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && j == 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 || j < 8 && sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0)
                        {


                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k[i, j]) && i == 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 || i < 8 && sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0)
                        {


                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j])  && flag == 1 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]) && j < 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                            k2[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i < 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                            k2[i + 2, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && j == 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 || j < 8 && sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0)
                        {


                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k2[i, j]) && i == 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 || i < 8 && sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0)
                        {


                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j])  && flag == 1 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Bitmap B5 = new Bitmap(@"G:\13.bmp");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    k[i, j] = new kletka();
                    k2[i, j] = new kletka();
                    k[i, j].Size = new Size(54, 54);
                    k2[i, j].Size = new Size(54, 54);
                    k1[i, j] = new kletka();
                    k[i, j].Location = new Point((55 * j) + 100, 55 * (i + 1));
                    k2[i, j].Location = new Point((55 * j) + 700, 55 * (i + 1));
                    Bitmap B = new Bitmap(@"G:\1.bmp");
                    k[i, j].BackgroundImage = B;
                    k2[i, j].BackgroundImage = B;

                    frm.Controls.Add(k2[i, j]);
                    frm.Controls.Add(k[i, j]);
                    k2[i, j].Hide();
                    k[i, j].x = i;
                    k[i, j].y = j;
                    k[i, j].s = 0;
                    k[i, j].TabStop = false;
                    k2[i, j].x = i;
                    k2[i, j].y = j;
                    k2[i, j].s = 0;
                    k2[i, j].TabStop = false;
                }
            }
            b.Size = new Size(120, 120);
            b.Location = new Point(575, 650);
            Bitmap B2 = new Bitmap(@"G:\4.bmp");
            b.Click += new EventHandler(Click22);
            b.TabStop = false;
            b.BackgroundImage = B2;
            frm.Controls.Add(b);

            b1.Size = new Size(120, 120);
            b1.Location = new Point(750, 650);
            b1.Click += new EventHandler(Click5);
            Bitmap B3 = new Bitmap(@"G:\11.bmp");
            b1.TabStop = false;
            b1.BackgroundImage = B3;
            frm.Controls.Add(b1);

            b2.Size = new Size(120, 120);
            b2.Location = new Point(1125, 650);
            b2.Click += new EventHandler(click01);
            Bitmap B4 = new Bitmap(@"G:\12.bmp");
            b2.TabStop = false;
            b2.BackgroundImage = B4;
            frm.Controls.Add(b2);

            b3.Size = new Size(120, 120);
            b3.Location = new Point(950, 650);
            b3.Click += new EventHandler(NEW);
            Bitmap B45 = new Bitmap(@"G:\16.bmp");
            b3.BackgroundImage = B45;
            b3.TabStop = false;
            frm.Controls.Add(b3);

            frm.Show();
            frm.Activate();
        }
        private void shot1(object sender, EventArgs e)
        {
            Bitmap B1 = new Bitmap(@"G:\14.bmp");
            Bitmap B2 = new Bitmap(@"G:\15.bmp");
            Random r = new Random();
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (sender.Equals(k2[i, j]))
                        {
                            if (k2[i, j].s == 0 || k2[i, j].s == 2)
                            {
                                k2[i, j].BackgroundImage = B1;
                                k2[i, j].s = 3;
                                hod = 0;
                            }
                            if (k2[i, j].s == 1)
                            {
                                k2[i, j].BackgroundImage = B2;
                                k2[i, j].s = 3;
                            }
                        }
                    }
                }
            }

           if (hod == 0)
                {
                int p = 1;
                while (p == 1)
                { 
                   int x = r.Next(0, 10), y = r.Next(0, 10);

                                    if (k[x, y].s == 0 || k[x, y].s == 2)
                                    {
                                        k[x, y].BackgroundImage = B1;
                                        k[x, y].s = 3;
                                        hod = 1;
                                        p = 0;
                                    }
                                    if (k[x, y].s == 1)
                                    {
                                        k[x, y].s = 3;
                                        k[x, y].BackgroundImage = B2;
                                    }
                    }
                }
            
            END();
        }
        private void click01(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Form2 frm2 = new Form2();
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (flag2 == 1)
            {
                if (hod == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            k2[i, j].Show();
                            frm.Controls.Add(k[i, j]);
                            frm.Controls.Add(k2[i, j]);
                            k[i, j].Click += new EventHandler(shot1);
                            
                            k[i, j].BackgroundImage = B;
                        }
                    }
                    hod = 1;
                    Click5(sender,e);
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i, j].Click += new EventHandler(shot1);
                        }

                    }
                            flag2 = 0;
                    frm.Show();
                    frm.Activate();

                }
            }
        }
        private void MouseLeave4(object sender, EventArgs e)

        {
            Color c = Color.FromName("none");
            Bitmap B = new Bitmap(@"G:\1.bmp");
            if (hod == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        if (sender.Equals(k[i, j]) && j < 7 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0 && k[i, j + 3].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                            k[i, j + 2].BackgroundImage = B;
                            k[i, j + 3].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i < 7 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0 && k[i + 3, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                            k[i + 2, j].BackgroundImage = B;
                            k[i + 3, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && j == 7 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0 || j < 7 && sender.Equals(k[i, j]) && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 && k[i, j + 2].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;
                            k[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k[i, j]) && i == 7 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0 || i < 7 && sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 && k[i + 2, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;
                            k[i + 2, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && j == 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0 || sender.Equals(k[i, j]) && j < 8 && flag == 0 && k[i, j].s == 0 && k[i, j + 1].s == 0)
                        {


                            k[i, j].BackgroundImage = B;
                            k[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k[i, j]) && i == 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0 || sender.Equals(k[i, j]) && i < 8 && flag == 1 && k[i, j].s == 0 && k[i + 1, j].s == 0)
                        {


                            k[i, j].BackgroundImage = B;
                            k[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k[i, j])  && flag == 0 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k[i, j]) && flag == 1 && k[i, j].s == 0)
                        {
                            k[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
            if (hod == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        if (sender.Equals(k2[i, j]) && j < 7 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 && k2[i, j + 3].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                            k2[i, j + 2].BackgroundImage = B;
                            k2[i, j + 3].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i < 7 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 && k2[i + 3, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                            k2[i + 2, j].BackgroundImage = B;
                            k2[i + 3, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && j == 7 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0 || j < 7 && sender.Equals(k2[i, j]) && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0 && k2[i, j + 2].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;
                            k2[i, j + 2].BackgroundImage = B;
                        }
                        if (sender.Equals(k2[i, j]) && i == 7 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0 || i < 7 && sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 && k2[i + 2, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;
                            k2[i + 2, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && j == 8 && flag == 0 && k2[
                            i, j].s == 0 && k2[i, j + 1].s == 0 || sender.Equals(k2[i, j]) && j < 8 && flag == 0 && k2[i, j].s == 0 && k2[i, j + 1].s == 0)
                        {


                            k2[i, j].BackgroundImage = B;
                            k2[i, j + 1].BackgroundImage = B;

                        }
                        if (sender.Equals(k2[i, j]) && i == 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0 || sender.Equals(k2[i, j]) && i < 8 && flag == 1 && k2[i, j].s == 0 && k2[i + 1, j].s == 0)
                        {


                            k2[i, j].BackgroundImage = B;
                            k2[i + 1, j].BackgroundImage = B;

                        }

                        if (sender.Equals(k2[i, j])  && flag == 0 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }

                        if (sender.Equals(k2[i, j]) && flag == 1 && k2[i, j].s == 0)
                        {
                            k2[i, j].BackgroundImage = B;
                        }
                    }
                }
            }
        }
    }
}
