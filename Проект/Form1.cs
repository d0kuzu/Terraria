using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form1 : Form
    {
        int X = -160;
        int Y = 0;
        int XP = 430;
        int YP = 320;
        bool jump = false;
        bool fall = true;
        Bitmap B_player = Resource1.стойка_в_право;
        int a = -20;
        Rectangle background;
        Rectangle player;
        List<Rectangle> dirt = new List<Rectangle>();
        List<Rectangle> grass = new List<Rectangle>();
        Rectangle rectangle;
        Rectangle mrectangle;
        int max = 1000;
        int max1 = 1000;
        int mid = 1000;
        List<Rectangle> blocks = new List<Rectangle>();
        int left_up = 1000;
        int mid_up = 1000;
        int right_up = 1000;
        int napravlenie = 1;
        int dvizhenie = -1;
        bool dvizhenie1 = false;
        Rectangle Inventory = new Rectangle(20, 20, 400, 50);
        Bitmap B_Inventory = Resource1.inventory;
        List<Rectangle> Items = new List<Rectangle>();
        int inventory = 1;
        Rectangle Slot1;
        Rectangle Slot2;
        Rectangle Slot3;
        Rectangle Slot4;
        Rectangle Slot5;
        Rectangle Slot6;
        Rectangle Slot7;
        Rectangle Slot8;
        Rectangle Slot9;
        int x1 = 15;
        int x2 = -100;
        int x3 = -100;
        int x4 = -100;
        int x5 = -100;
        int x6 = -100;
        int x7 = -100;
        int x8 = -100;
        int x9 = -100;
        Rectangle item_fall;
        List<Rectangle> thrown = new List<Rectangle>();
        List<Rectangle> Rectangles = new List<Rectangle>();
        int empty_slot;
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        int six = 0;
        int seven = 0;
        int eight = 0;
        int nine = 0;
        List<int> Slots = new List<int>();
        int min;
        Bitmap B_kirka = Resource1.кирка;
        Rectangle empty_block;
        int dvizhenie_kirki1 = -1;
        Bitmap B_sword = Resource1.анимация_меча;
        int dvizhenie_mecha1 = -1;
        Rectangle slime;
        int XS = 200;
        int YS = 100;
        int slime_down_left = 1000;
        int slime_down_right = 1000;
        bool slime_jump = false;
        bool slime_fall = false;
        Rectangle life_bar;
        Bitmap B_life_bar = Resource1.life_bar;
        int life = 18;
        int death = 0;
        int player_side = 0;
        int slime_right_up = 0;
        int slime_left_up = 0;
        List<Rectangle> tree = new List<Rectangle>();
        int YT = 1000;
        List<Rectangle> empty_tree = new List<Rectangle>();
        List<Rectangle> wood_block = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (life == 18)
            {
                B_life_bar = Resource1.life_bar;
            }
            if (life == 17)
            {
                B_life_bar = Resource1._12;
            }
            if (life == 16)
            {
                B_life_bar = Resource1._21;
            }
            if (life == 15)
            {
                B_life_bar = Resource1._31;
            }
            if (life == 14)
            {
                B_life_bar = Resource1._41;
            }
            if (life == 13)
            {
                B_life_bar = Resource1._51;
            }
            if (life == 12)
            {
                B_life_bar = Resource1._61;
            }
            if (life == 11)
            {
                B_life_bar = Resource1._71;
            }
            if (life == 10)
            {
                B_life_bar = Resource1._81;
            }
            if (life == 9)
            {
                B_life_bar = Resource1._91;
            }
            if (life == 8)
            {
                B_life_bar = Resource1._10;
            }
            if (life == 7)
            {
                B_life_bar = Resource1._111;
            }
            if (life == 6)
            {
                B_life_bar = Resource1._121;
            }
            if (life == 5)
            {
                B_life_bar = Resource1._13;
            }
            if (life == 4)
            {
                B_life_bar = Resource1._14;
            }
            if (life == 3)
            {
                B_life_bar = Resource1._15;
            }
            if (life == 2)
            {
                B_life_bar = Resource1._16;
            }
            if (life == 1)
            {
                B_life_bar = Resource1._17;
            }
            if (life == 0)
            {
                X = -160;
                Y = 0;
                XP = 430;
                YP = 320;
                life = 18;
                Random rnd = new Random();
                XS = rnd.Next(-150, 1010);
                for (int i = 0; i < grass.Count; i++)
                {
                    rectangle = grass[i];
                    rectangle.X -= death;
                    grass[i] = rectangle;
                }
                for (int i = 0; i < dirt.Count; i++)
                {
                    rectangle = dirt[i];
                    rectangle.X -= death;
                    dirt[i] = rectangle;
                }
                for (int i = 0; i < tree.Count; i++)
                {
                    rectangle = tree[i];
                    rectangle.X -= death;
                    tree[i] = rectangle;
                }
                death = 0;
            }
            if (jump == true || fall == true)
            {
                if (napravlenie == 1)
                {
                    B_player = Resource1.Прыжок_в_право;
                }
                if (napravlenie == -1)
                {
                    B_player = Resource1.Прыжок_в_лево;
                }
                dvizhenie1 = true;
            }
            if (jump == false && fall == false)
            {
                if (dvizhenie1 == false)
                {
                    if (napravlenie == 1)
                    {
                        B_player = Resource1.стойка_в_право;
                    }
                    if (napravlenie == -1)
                    {
                        B_player = Resource1.стойка_в_лево;
                    }
                }
            }
            background = new Rectangle(X, Y, 1220, 600);
            player = new Rectangle(XP, YP, 40, 70);
            slime = new Rectangle(XS, YS, 40, 30);
            life_bar = new Rectangle(670, 29, 200, 20);
            Refresh();
            max = 1000;
            max1 = 1000;
            mid = 1000;
            left_up = 0;
            mid_up = 0;
            right_up = 0;
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXP = (XP / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP == rectangle.X)
                {
                    if (YP + 70 <= rectangle.Y)
                    {
                        if (rectangle.Y < max)
                        {
                            max = rectangle.Y;
                        }
                    }
                }
            }
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXP = (XP / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 20 == rectangle.X)
                {
                    if (YP + 70 <= rectangle.Y)
                    {
                        if (rectangle.Y < max1)
                        {
                            max1 = rectangle.Y;
                        }
                    }
                }
            }
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXP = (XP / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 20 == rectangle.X)
                {
                    if (YP + 70 <= rectangle.Y)
                    {
                        if (rectangle.Y < mid)
                        {
                            mid = rectangle.Y;
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                int mXP = (XP / 20) * 20;
                int mYP = (YP / 20) * 20;
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP == rectangle.X)
                {
                    if (mYP >= rectangle.Y + 20)
                    {
                        if (rectangle.Y > left_up)
                        {
                            left_up = rectangle.Y;
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                int mXP = (XP / 20) * 20;
                int mYP = (YP / 20) * 20;
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 20 == rectangle.X)
                {
                    if (mYP >= rectangle.Y + 20)
                    {
                        if (rectangle.Y > mid_up)
                        {
                            mid_up = rectangle.Y;
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                int mXP = (XP / 20) * 20;
                int mYP = (YP / 20) * 20;
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 20 == rectangle.X)
                {
                    if (mYP >= rectangle.Y + 20)
                    {
                        if (rectangle.Y > right_up)
                        {
                            right_up = rectangle.Y;
                        }
                    }
                }
            }
            if (max < max1 && max < mid)
            {
                if (jump == true)
                {
                    if (YP + 70 <= max - 1)
                    {
                        YP -= 7;
                    }
                    if (max - (YP + 70) >= 70)
                    {
                        jump = false;
                        fall = true;
                    }
                }
                if (jump == false)
                {
                    if (YP + 70 < max)
                    {
                        YP += 7;
                    }
                    if (YP + 70 >= max)
                    {
                        YP = max - 1;
                        YP -= 70;
                        fall = false;
                        dvizhenie1 = false;
                    }
                }
            }
            if (max1 <= max && max1 <= mid)
            {
                if (jump == true)
                {
                    if (YP + 70 <= max1 - 1)
                    {
                        YP -= 7;
                    }
                    if (max1 - (YP + 70) >= 70)
                    {
                        jump = false;
                        fall = true;
                    }
                }
                if (jump == false)
                {
                    if (YP + 70 < max1)
                    {
                        YP += 7;
                    }
                    if (YP + 70 >= max1)
                    {
                        YP = max1 - 1;
                        YP -= 70;
                        fall = false;
                        dvizhenie1 = false;
                    }
                }
            }
            if (mid <= max && mid < max1)
            {
                if (jump == true)
                {
                    if (YP + 70 <= mid - 1)
                    {
                        YP -= 7;
                    }
                    if (mid - (YP + 70) >= 70)
                    {
                        jump = false;
                        fall = true;
                    }
                }
                if (jump == false)
                {
                    if (YP + 70 < mid)
                    {
                        YP += 7;
                    }
                    if (YP + 70 >= mid)
                    {
                        YP = mid - 1;
                        YP -= 70;
                        fall = false;
                        dvizhenie1 = false;
                    }
                }
            }
            if (left_up > mid_up && left_up > right_up)
            {
                if (jump == true)
                {
                    if (YP <= left_up + 20)
                    {
                        jump = false;
                    }
                }
            }
            if (mid_up >= left_up && mid_up >= right_up)
            {
                if (jump == true)
                {
                    if (YP <= mid_up + 20)
                    {
                        jump = false;
                    }
                }
            }
            if (right_up >= left_up && right_up > mid_up)
            {
                if (jump == true)
                {
                    if (YP <= right_up + 20)
                    {
                        jump = false;
                    }
                }
            }
            slime_down_left = 1000;
            slime_down_right = 1000;
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXS = (XS / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXS == rectangle.X)
                {
                    if (YS + 30 <= rectangle.Y)
                    {
                        if (rectangle.Y < slime_down_left)
                        {
                            slime_down_left = rectangle.Y;
                        }
                    }
                }
            }
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXS = (XS / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXS + 20 == rectangle.X)
                {
                    if (YS + 30 <= rectangle.Y)
                    {
                        if (rectangle.Y < slime_down_right)
                        {
                            slime_down_right = rectangle.Y;
                        }
                    }
                }
            }
            if (slime_down_left <= slime_down_right)
            {
                if (slime_jump == true)
                {
                    if (XP > XS)
                    {
                        if (YS + 30 <= slime_down_left - 1)
                        {
                            YS -= 7;
                            XS += 2;
                        }
                    }
                    if (XP <= XS)
                    {
                        if (YS + 30 <= slime_down_left - 1)
                        {
                            YS -= 7;
                            XS -= 2;
                        }
                    }
                    if (slime_down_left - (YS + 30) >= 70)
                    {
                        slime_jump = false;
                        slime_fall = true;
                    }
                }
                if (slime_fall == true)
                {
                    if (player_side == 1)
                    {
                        if (YS + 30 < slime_down_left)
                        {
                            YS += 7;
                            XS += 3;
                        }
                    }
                    if (player_side == -1)
                    {
                        if (YS + 30 < slime_down_left)
                        {
                            YS += 7;
                            XS -= 3;
                        }
                    }
                    if (YS + 30 >= slime_down_left)
                    {
                        YS = slime_down_left - 1;
                        YS -= 30;
                        slime_fall = false;
                        slime_life.Enabled = true;
                    }
                }
            }
            if (slime_down_right < slime_down_left)
            {
                if (slime_jump == true)
                {
                    if (XP > XS)
                    {
                        if (YS + 30 <= slime_down_right - 1)
                        {
                            YS -= 7;
                            XS += 2;
                        }
                    }
                    if (XP <= XS)
                    {
                        if (YS + 30 <= slime_down_right - 1)
                        {
                            YS -= 7;
                            XS -= 2;
                        }
                    }
                    if (slime_down_right - (YS + 30) >= 70)
                    {
                        slime_jump = false;
                        slime_fall = true;
                    }
                }
                if (slime_fall == true)
                {
                    if (player_side == 1)
                    {
                        if (YS + 30 < slime_down_right)
                        {
                            YS += 7;
                            XS += 3;
                        }
                    }
                    if (player_side == -1)
                    {
                        if (YS + 30 < slime_down_right)
                        {
                            YS += 7;
                            XS -= 3;
                        }
                    }
                    if (YS + 30 >= slime_down_right)
                    {
                        YS = slime_down_right - 1;
                        YS -= 30;
                        slime_fall = false;
                        slime_life.Enabled = true;
                    }
                }
            }
            if (player_side == 1)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    mrectangle = blocks[i];
                    rectangle.X = (mrectangle.X / 20) * 20;
                    rectangle.Y = (mrectangle.Y / 20) * 20;
                    int mXS = (XS / 20) * 20;
                    if (mXS + 40 == rectangle.X)
                    {
                        if (YS + 30 >= rectangle.Y && YS + 30 <= rectangle.Y + 20)
                        {
                            if (mrectangle.X - XS <= 40)
                            {
                                XS -= 3;
                            }
                        }
                    }
                }
            }
            if (player_side == -1)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    mrectangle = blocks[i];
                    rectangle.X = (mrectangle.X / 20) * 20;
                    rectangle.Y = (mrectangle.Y / 20) * 20;
                    int mXS = (XS / 20) * 20;
                    if (mXS == rectangle.X)
                    {
                        if (YS + 30 >= rectangle.Y && YS + 30 <= rectangle.Y + 20)
                        {
                            if (mrectangle.X - XS <= 40)
                            {
                                XS += 3;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                int mXS = (XS / 20) * 20;
                int mYS = (YS / 20) * 20;
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXS == rectangle.X)
                {
                    if (mYS >= rectangle.Y + 20)
                    {
                        if (rectangle.Y > slime_left_up)
                        {
                            slime_left_up = rectangle.Y;
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                int mXS = (XS / 20) * 20;
                int mYS = (YS / 20) * 20;
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXS + 20 == rectangle.X)
                {
                    if (mYS >= rectangle.Y + 20)
                    {
                        if (rectangle.Y > slime_right_up)
                        {
                            slime_right_up = rectangle.Y;
                        }
                    }
                }
            }
            if (slime_left_up >= slime_right_up)
            {
                if (slime_jump == true)
                {
                    if (YS <= slime_left_up + 20)
                    {
                        slime_jump = false;
                        slime_fall = true;
                    }
                }
            }
            if (slime_right_up > slime_left_up)
            {
                if (slime_jump == true)
                {
                    if (YS <= slime_right_up + 20)
                    {
                        slime_jump = false;
                        slime_fall = true;
                    }
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                napravlenie = -1;
                dvizhenie += 1;
                death += 3;
                if (dvizhenie % 10 == 0)
                {
                    this.B_player = Resource1.Снимок_экрана__36_;
                }
                if (dvizhenie % 10 == 1)
                {
                    this.B_player = Resource1.Снимок_экрана__37_;
                }
                if (dvizhenie % 10 == 2)
                {
                    this.B_player = Resource1.Снимок_экрана__38_;
                }
                if (dvizhenie % 10 == 3)
                {
                    this.B_player = Resource1.Снимок_экрана__39_;
                }
                if (dvizhenie % 10 == 4)
                {
                    this.B_player = Resource1.Снимок_экрана__40_;
                }
                if (dvizhenie % 10 == 5)
                {
                    this.B_player = Resource1.Снимок_экрана__41_;
                }
                if (dvizhenie % 10 == 6)
                {
                    this.B_player = Resource1.Снимок_экрана__42_;
                }
                if (dvizhenie % 10 == 7)
                {
                    this.B_player = Resource1.Снимок_экрана__43_;
                }
                if (dvizhenie % 10 == 8)
                {
                    this.B_player = Resource1.Снимок_экрана__44_;
                }
                if (dvizhenie % 10 == 9)
                {
                    this.B_player = Resource1.Снимок_экрана__48_;
                }
                dvizhenie1 = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                napravlenie = 1;
                dvizhenie += 1;
                death -= 3;
                if (dvizhenie % 13 == 0)
                {
                    this.B_player = Resource1._1111;
                }
                if (dvizhenie % 10 == 1)
                {
                    this.B_player = Resource1._2222;
                }
                if (dvizhenie % 10 == 2)
                {
                    this.B_player = Resource1._3333;
                }
                if (dvizhenie % 10 == 3)
                {
                    this.B_player = Resource1._4444;
                }
                if (dvizhenie % 10 == 4)
                {
                    this.B_player = Resource1._5555;
                }
                if (dvizhenie % 10 == 5)
                {
                    this.B_player = Resource1._6666;
                }
                if (dvizhenie % 10 == 6)
                {
                    this.B_player = Resource1._7777;
                }
                if (dvizhenie % 10 == 7)
                {
                    this.B_player = Resource1._8888;
                }
                if (dvizhenie % 10 == 8)
                {
                    this.B_player = Resource1._9999;
                }
                if (dvizhenie % 10 == 9)
                {
                    this.B_player = Resource1._101010;
                }
                dvizhenie1 = true;
            }

            if (X > -317 && X < -3)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    X -= 3;
                    XS -= 3;
                    for (int i = 0; i < grass.Count; i++)
                    {
                        rectangle = grass[i];
                        rectangle.X -= 3;
                        grass[i] = rectangle;
                    }
                    for (int i = 0; i < dirt.Count; i++)
                    {
                        rectangle = dirt[i];
                        rectangle.X -= 3;
                        dirt[i] = rectangle;
                    }
                    for (int i = 0; i < tree.Count; i++)
                    {
                        rectangle = tree[i];
                        rectangle.X -= 3;
                        tree[i] = rectangle;
                    }
                    for (int i = 0; i < wood_block.Count; i++)
                    {
                        rectangle = wood_block[i];
                        rectangle.X -= 3;
                        wood_block[i] = rectangle;
                    }
                    for (int j = 0; j < Items.Count; j++)
                    {
                        for (int k = 0; k < thrown.Count; k++)
                        {
                            if (Items[j] == thrown[k])
                            {
                                rectangle = Items[j];
                                rectangle.X -= 3;
                                Items[j] = rectangle;
                                rectangle = thrown[k];
                                rectangle.X -= 3;
                                thrown[k] = rectangle;
                            }
                        }
                    }
                    for (int i = 0; i < blocks.Count; i++)
                    {
                        mrectangle = blocks[i];
                        rectangle.X = (mrectangle.X / 20) * 20;
                        rectangle.Y = (mrectangle.Y / 20) * 20;
                        int mXP = (XP / 20) * 20;
                        if (mXP + 40 == rectangle.X)
                        {
                            if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                            {
                                if (mrectangle.X - XP <= 40)
                                {
                                    X += 3;
                                    XS += 3;
                                    for (int j = 0; j < grass.Count; j++)
                                    {
                                        rectangle = grass[j];
                                        rectangle.X += 3;
                                        grass[j] = rectangle;
                                    }
                                    for (int j = 0; j < dirt.Count; j++)
                                    {
                                        rectangle = dirt[j];
                                        rectangle.X += 3;
                                        dirt[j] = rectangle;
                                    }
                                    for (int j = 0; j < Items.Count; j++)
                                    {
                                        for (int k = 0; k < thrown.Count; k++)
                                        {
                                            if (Items[j] == thrown[k])
                                            {
                                                rectangle = Items[j];
                                                rectangle.X += 3;
                                                Items[j] = rectangle;
                                                rectangle = thrown[k];
                                                rectangle.X += 3;
                                                thrown[k] = rectangle;
                                            }
                                        }
                                    }
                                    for (int j = 0; j < tree.Count; j++)
                                    {
                                        rectangle = tree[j];
                                        rectangle.X += 3;
                                        tree[j] = rectangle;
                                    }
                                    for (int j = 0; j < wood_block.Count; j++)
                                    {
                                        rectangle = wood_block[i];
                                        rectangle.X += 3;
                                        wood_block[i] = rectangle;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    X += 3;
                    XS += 3;
                    for (int i = 0; i < grass.Count; i++)
                    {
                        rectangle = grass[i];
                        rectangle.X += 3;
                        grass[i] = rectangle;
                    }
                    for (int i = 0; i < dirt.Count; i++)
                    {
                        rectangle = dirt[i];
                        rectangle.X += 3;
                        dirt[i] = rectangle;
                    }
                    for (int i = 0; i < tree.Count; i++)
                    {
                        rectangle = tree[i];
                        rectangle.X += 3;
                        tree[i] = rectangle;
                    }
                    for (int i = 0; i < wood_block.Count; i++)
                    {
                        rectangle = wood_block[i];
                        rectangle.X += 3;
                        wood_block[i] = rectangle;
                    }
                    for (int j = 0; j < Items.Count; j++)
                    {
                        for (int k = 0; k < thrown.Count; k++)
                        {
                            if (Items[j] == thrown[k])
                            {
                                rectangle = Items[j];
                                rectangle.X += 3;
                                Items[j] = rectangle;
                                rectangle = thrown[k];
                                rectangle.X += 3;
                                thrown[k] = rectangle;
                            }
                        }
                    }
                    for (int i = 0; i < blocks.Count; i++)
                    {
                        mrectangle = blocks[i];
                        rectangle.X = (mrectangle.X / 20) * 20;
                        rectangle.Y = (mrectangle.Y / 20) * 20;
                        int mXP = (XP / 20) * 20;
                        int mYP = (YP / 20) * 20;
                        if (mXP == rectangle.X + 20)
                        {
                            if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                            {
                                if (mrectangle.X - XP >= -20)
                                {
                                    X -= 3;
                                    XS -= 3;
                                    for (int j = 0; j < grass.Count; j++)
                                    {
                                        rectangle = grass[j];
                                        rectangle.X -= 3;
                                        grass[j] = rectangle;
                                    }
                                    for (int j = 0; j < dirt.Count; j++)
                                    {
                                        rectangle = dirt[j];
                                        rectangle.X -= 3;
                                        dirt[j] = rectangle;
                                    }
                                    for (int j = 0; j < Items.Count; j++)
                                    {
                                        for (int k = 0; k < thrown.Count; k++)
                                        {
                                            if (Items[j] == thrown[k])
                                            {
                                                rectangle = Items[j];
                                                rectangle.X -= 3;
                                                Items[j] = rectangle;
                                                rectangle = thrown[k];
                                                rectangle.X -= 3;
                                                thrown[k] = rectangle;
                                            }
                                        }
                                    }
                                    for (int j = 0; j < tree.Count; j++)
                                    {
                                        rectangle = tree[j];
                                        rectangle.X -= 3;
                                        tree[j] = rectangle;
                                    }
                                    for (int j = 0; j < wood_block.Count; j++)
                                    {
                                        rectangle = wood_block[i];
                                        rectangle.X -= 3;
                                        wood_block[i] = rectangle;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (X <= -317)
            {
                if (XP <= 430)
                {
                    XP = 430;
                    X = -316;
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    if (XP >= 847)
                    {
                        XP = 847;
                    }
                    if (XP < 847)
                    {
                        XP += 3;
                        for (int i = 0; i < blocks.Count; i++)
                        {
                            mrectangle = blocks[i];
                            rectangle.X = (mrectangle.X / 20) * 20;
                            rectangle.Y = (mrectangle.Y / 20) * 20;
                            int mXP = (XP / 20) * 20;
                            if (mXP + 40 == rectangle.X)
                            {
                                if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                                {
                                    if (mrectangle.X - XP <= 41)
                                    {
                                        XP -= 3;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    XP -= 3;
                    for (int i = 0; i < blocks.Count; i++)
                    {
                        mrectangle = blocks[i];
                        rectangle.X = (mrectangle.X / 20) * 20;
                        rectangle.Y = (mrectangle.Y / 20) * 20;
                        int mXP = (XP / 20) * 20;
                        if (mXP == rectangle.X + 20)
                        {
                            if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                            {
                                if (mrectangle.X - XP >= -20)
                                {
                                    XP += 3;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (X >= -3)
            {
                if (XP >= 430)
                {
                    XP = 430;
                    X = -4;
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    XP += 3;
                    for (int i = 0; i < blocks.Count; i++)
                    {
                        mrectangle = blocks[i];
                        rectangle.X = (mrectangle.X / 20) * 20;
                        rectangle.Y = (mrectangle.Y / 20) * 20;
                        int mXP = (XP / 20) * 20;
                        int mYP = (YP / 20) * 20;

                        if (mXP + 40 == rectangle.X)
                        {
                            if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                            {
                                if (mrectangle.X - XP <= 41)
                                {
                                    XP -= 3;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    if (XP <= 3)
                    {
                        XP = 3;
                    }
                    if (XP > 3)
                    {
                        XP -= 3;
                        for (int i = 0; i < blocks.Count; i++)
                        {
                            mrectangle = blocks[i];
                            rectangle.X = (mrectangle.X / 20) * 20;
                            rectangle.Y = (mrectangle.Y / 20) * 20;
                            int mXP = (XP / 20) * 20;
                            int mYP = (YP / 20) * 20;
                            if (mXP == rectangle.X + 20)
                            {
                                if (YP + 51 >= rectangle.Y && YP + 51 <= rectangle.Y + 20)
                                {
                                    if (mrectangle.X - XP >= -20)
                                    {
                                        XP += 3;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < blocks.Count; i++)
            {
                rectangle = blocks[i];
                rectangle.X = (rectangle.X / 20) * 20;
                int mXP = (XP / 20) * 20;
                if (mXP == rectangle.X)
                {
                    rectangle.X = XP + 40;
                    rectangle.Y = YP;
                    if (YP + 70 == max - 1)
                    {
                        if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W || e.KeyCode == Keys.Space)
                        {
                            jump = true;
                        }
                    }
                    if (rectangle.Y + 70 == max1 - 1)
                    {
                        if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W || e.KeyCode == Keys.Space)
                        {
                            jump = true;
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.D1)
            {
                x1 = 15;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 1;
            }
            if (e.KeyCode == Keys.D2)
            {
                x1 = -100;
                x2 = 59;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 2;
            }
            if (e.KeyCode == Keys.D3)
            {
                x1 = -100;
                x2 = -100;
                x3 = 105;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 3;
            }
            if (e.KeyCode == Keys.D4)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = 150;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 4;
            }
            if (e.KeyCode == Keys.D5)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = 195;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 5;
            }
            if (e.KeyCode == Keys.D6)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = 240;
                x7 = -100;
                x8 = -100;
                x9 = -100;
                inventory = 6;
            }
            if (e.KeyCode == Keys.D7)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = 285;
                x8 = -100;
                x9 = -100;
                inventory = 7;
            }
            if (e.KeyCode == Keys.D8)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = 330;
                x9 = -100;
                inventory = 8;
            }
            if (e.KeyCode == Keys.D9)
            {
                x1 = -100;
                x2 = -100;
                x3 = -100;
                x4 = -100;
                x5 = -100;
                x6 = -100;
                x7 = -100;
                x8 = -100;
                x9 = 376;
                inventory = 9;
            }
            empty_slot = 1000;
            one = 0;
            two = 0;
            three = 0;
            four = 0;
            five = 0;
            six = 0;
            seven = 0;
            eight = 0;
            nine = 0;
            Slots.Clear();
            for (int i = 0; i < thrown.Count; i++)
            {
                int mXP = (XP / 20) * 20;
                rectangle = thrown[i];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 20 == rectangle.X || mXP == rectangle.X)
                {
                    for (int j = 0; j < Items.Count; j++)
                    {
                        if (Items[j].X != 387)
                        {
                            nine++;
                        }
                        if (Items[j].X != 342)
                        {
                            eight++;
                        }
                        if (Items[j].X != 296)
                        {
                            seven++;
                        }
                        if (Items[j].X != 253)
                        {
                            six++;
                        }
                        if (Items[j].X != 206)
                        {
                            five++;
                        }
                        if (Items[j].X != 161)
                        {
                            four++;
                        }
                        if (Items[j].X != 116)
                        {
                            three++;
                        }
                        if (Items[j].X != 70)
                        {
                            two++;
                        }
                        if (Items[j].X != 25)
                        {
                            one++;
                        }
                    }
                    if (one >= two && one >= three && one >= four && one >= five && one >= six && one >= seven && one >= eight && one >= nine)
                    {
                        Slots.Add(1);
                    }
                    if (two >= one && two >= three && two >= four && two >= five && two >= six && two >= seven && two >= eight && two >= nine)
                    {
                        Slots.Add(2);
                    }
                    if (three >= one && three >= two && three >= four && three >= five && three >= six && three >= seven && three >= eight && three >= nine)
                    {
                        Slots.Add(3);
                    }
                    if (four >= one && four >= two && four >= three && four >= five && four >= six && four >= seven && four >= eight && four >= nine)
                    {
                        Slots.Add(4);
                    }
                    if (five >= one && five >= two && five >= three && five >= four && five >= six && five >= seven && five >= eight && five >= nine)
                    {
                        Slots.Add(5);
                    }
                    if (six >= one && six >= two && six >= three && six >= four && six >= five && six >= seven && six >= eight && six >= nine)
                    {
                        Slots.Add(6);
                    }
                    if (seven >= one && seven >= two && seven >= three && seven >= four && seven >= five && seven >= six && seven >= eight && seven >= nine)
                    {
                        Slots.Add(7);
                    }
                    if (eight >= one && eight >= two && eight >= three && eight >= four && eight >= five && eight >= six && eight >= seven && eight >= nine)
                    {
                        Slots.Add(8);
                    }
                    if (nine >= one && nine >= two && nine >= three && nine >= four && nine >= five && nine >= six && nine >= seven && nine >= eight)
                    {
                        Slots.Add(9);
                    }
                    min = Slots.Min();
                    if (min == 1)
                    {
                        empty_slot = 25;
                    }
                    if (min == 2)
                    {
                        empty_slot = 70;
                    }
                    if (min == 3)
                    {
                        empty_slot = 116;
                    }
                    if (min == 4)
                    {
                        empty_slot = 161;
                    }
                    if (min == 5)
                    {
                        empty_slot = 206;
                    }
                    if (min == 6)
                    {
                        empty_slot = 253;
                    }
                    if (min == 7)
                    {
                        empty_slot = 296;
                    }
                    if (min == 8)
                    {
                        empty_slot = 342;
                    }
                    if (min == 9)
                    {
                        empty_slot = 387;
                    }
                    for (int j = 0; j < Items.Count; j++)
                    {
                        if (Items[j] == thrown[i])
                        {
                            rectangle = Items[j];
                            if (Items[j] == Items[5])
                            {
                                rectangle = Items[3];
                                mrectangle = Items[j];
                            }
                            if (Items[j] != Items[5])
                            {
                                rectangle = Items[j];
                            }
                            rectangle.X = empty_slot;
                            rectangle.Y = 29;
                            if (Items[j] == Items[5])
                            {
                                Items[3] = rectangle;
                            }
                            if (Items[j] != Items[5])
                            {
                                Items[j] = rectangle;
                            }
                            item_fall = Items[j];
                            if (Items[j] == Items[5])
                            {
                                for (int u = 0; u < thrown.Count; u++)
                                {
                                    Rectangles.Add(thrown[u]);
                                }
                                thrown.Clear();
                                for (int u = 0; u < Rectangles.Count; u++)
                                {
                                    if (Rectangles[u] != item_fall)
                                    {
                                        thrown.Add(Rectangles[u]);
                                    }
                                }
                                Rectangles.Clear();
                                rectangle = Items[5];
                                rectangle.X = -100;
                                rectangle.Y = -100;
                                Items[5] = rectangle;
                                i--;
                            }
                            if (Items[j] != Items[5])
                            {
                                for (int u = 0; u < thrown.Count; u++)
                                {
                                    Rectangles.Add(thrown[u]);
                                }
                                thrown.Clear();
                                for (int u = 0; u < Rectangles.Count; u++)
                                {
                                    if (Rectangles[u] != item_fall)
                                    {
                                        thrown.Add(Rectangles[u]);
                                    }
                                }
                                Rectangles.Clear();
                                i--;
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.T)
            {
                if (inventory == 1)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 25)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 2)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 70)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 3)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 116)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 4)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 161)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 5)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 206)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 6)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 253)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 7)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 296)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 8)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 342)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
                if (inventory == 9)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rectangle = Items[i];
                        if (rectangle.X == 387)
                        {
                            if (napravlenie == 1)
                            {
                                rectangle.X = XP + 40;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                            if (napravlenie == -1)
                            {
                                rectangle.X = XP - 20;
                                rectangle.Y = YP + 20;
                                item_fall = rectangle;
                                Items[i] = rectangle;
                            }
                        }
                    }
                    Item_fall.Enabled = true;
                }
            }
            if (Items[3].Y == 29)
            {
                rectangle = Items[3];
                rectangle.Width = 30;
                rectangle.Height = 30;
                Items[3] = rectangle;
            }
        }
        private void Item_fall_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                rectangle = Items[i];
                if (rectangle == item_fall)
                {
                    if (napravlenie == 1)
                    {
                        rectangle.X += 3;
                        rectangle.Y += 7;
                        item_fall = rectangle;
                        Items[i] = rectangle;
                    }
                    if (napravlenie == -1)
                    {
                        rectangle.X -= 3;
                        rectangle.Y += 7;
                        item_fall = rectangle;
                        Items[i] = rectangle;
                    }
                }
            }
            max = 1000;
            for (int j = 0; j < blocks.Count; j++)
            {
                int mXP = (XP / 20) * 20;
                rectangle = blocks[j];
                rectangle.X = (rectangle.X / 20) * 20;
                if (mXP + 40 == rectangle.X)
                {
                    if (YP + 70 <= rectangle.Y)
                    {
                        if (rectangle.Y < max)
                        {
                            max = rectangle.Y;
                        }
                    }
                }
            }
            if (item_fall.Y + 30 >= max)
            {
                thrown.Add(item_fall);
                Item_fall.Enabled = false;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Height > 500 || this.Width > 900)
            {
                this.Width = 900;
                this.Height = 500;
            }
            if (this.Height < 500 || this.Width < 900)
            {
                this.Width = 900;
                this.Height = 500;
            }
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(Resource1.Background, background);
            g.DrawImage(B_Inventory, Inventory);
            g.DrawImage(B_life_bar, life_bar);
            g.DrawImage(B_kirka, Items[4]);
            g.DrawImage(B_sword, Items[6]);
            g.DrawImage(B_player, player);
            g.DrawImage(Resource1.slime, slime);
            for (int i = 0; i < tree.Count; i++)
            {
                g.DrawImage(Resource1.wood, tree[i]);
            }
            Slot1 = new Rectangle(x1, 20, 50, 50);
            Slot2 = new Rectangle(x2, 20, 50, 50);
            Slot3 = new Rectangle(x3, 20, 50, 50);
            Slot4 = new Rectangle(x4, 20, 50, 50);
            Slot5 = new Rectangle(x5, 20, 50, 50);
            Slot6 = new Rectangle(x6, 20, 50, 50);
            Slot7 = new Rectangle(x7, 20, 50, 50);
            Slot8 = new Rectangle(x8, 20, 50, 50);
            Slot9 = new Rectangle(x9, 20, 50, 50);
            g.DrawImage(Resource1.Slot1, Slot1);
            g.DrawImage(Resource1.Slot2, Slot2);
            g.DrawImage(Resource1.Slot3, Slot3);
            g.DrawImage(Resource1.Slot4, Slot4);
            g.DrawImage(Resource1.Slot5, Slot5);
            g.DrawImage(Resource1.Slot6, Slot6);
            g.DrawImage(Resource1.Slot7, Slot7);
            g.DrawImage(Resource1.Slot8, Slot8);
            g.DrawImage(Resource1.Slot9, Slot9);
            blocks.Clear();
            for (int i = 0; i < grass.Count; i++)
            {
                blocks.Add(grass[i]);
            }
            for (int i = 0; i < dirt.Count; i++)
            {
                blocks.Add(dirt[i]);
            }
            for (int i = 0; i < wood_block.Count; i++)
            {
                blocks.Add(wood_block[i]);
            }
            for (int i = 0; i < grass.Count; i++)
            {
                g.DrawImage(Resource1.Grass, blocks[i]);
            }
            for (int i = grass.Count; i < dirt.Count + grass.Count; i++)
            {
                g.DrawImage(Resource1.Dirt, blocks[i]);
            }
            for (int i = grass.Count + dirt.Count; i < dirt.Count + grass.Count + wood_block.Count; i++)
            {
                g.DrawImage(Resource1.wood, blocks[i]);
            }
            g.DrawImage(Resource1.короткий_меч, Items[0]);
            g.DrawImage(Resource1.кирка, Items[1]);
            g.DrawImage(Resource1.топор, Items[2]);
            g.DrawImage(Resource1.dirt_item, Items[3]);
            g.DrawImage(Resource1.Dirt, Items[5]);
            g.DrawImage(Resource1.wood, Items[7]);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            a = -20;
            for (int i = 0; i < 45; i++)
            {
                a += 20;
                for (int j = 0; j < 1; j++)
                {
                    rectangle = new Rectangle(a, 420, 20, 20);
                    grass.Add(rectangle);
                    rectangle = new Rectangle(a, 440, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 460, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 480, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 500, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 520, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 540, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 560, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 580, 20, 20);
                    dirt.Add(rectangle);
                }
            }
            a = 880;
            for (int i = 0; i < 8; i++)
            {
                a += 20;
                for (int j = 0; j < 1; j++)
                {
                    rectangle = new Rectangle(a, 400, 20, 20);
                    grass.Add(rectangle);
                    rectangle = new Rectangle(a, 420, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 440, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 460, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 480, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 500, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 520, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 540, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 560, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 580, 20, 20);
                    dirt.Add(rectangle);
                }
            }
            a = -180;
            for (int i = 0; i < 8; i++)
            {
                a += 20;
                for (int j = 0; j < 1; j++)
                {
                    rectangle = new Rectangle(a, 400, 20, 20);
                    grass.Add(rectangle);
                    rectangle = new Rectangle(a, 420, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 440, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 460, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 480, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 500, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 520, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 540, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 560, 20, 20);
                    dirt.Add(rectangle);
                    rectangle = new Rectangle(a, 580, 20, 20);
                    dirt.Add(rectangle);
                }
            }
            rectangle = new Rectangle(25, 29, 30, 30);
            Items.Add(rectangle);
            rectangle = new Rectangle(70, 29, 30, 30);
            Items.Add(rectangle);
            rectangle = new Rectangle(116, 29, 30, 30);
            Items.Add(rectangle);
            rectangle = new Rectangle(-100, -100, 30, 30);
            Items.Add(rectangle);
            rectangle = new Rectangle(-100, -100, 55, 55);
            Items.Add(rectangle);
            rectangle = new Rectangle(-100, -100, 15, 15);
            Items.Add(rectangle);
            rectangle = new Rectangle(-100, -100, 60, 20);
            Items.Add(rectangle);
            rectangle = new Rectangle(-100, -100, 60, 20);
            Items.Add(rectangle);
            Random rnd = new Random();
            XS = rnd.Next(-150, 1010);
            for (int i = 0; i < grass.Count; i++)
            {
                blocks.Add(grass[i]);
            }
            for (int i = 0; i < dirt.Count; i++)
            {
                blocks.Add(dirt[i]);
            }
            Random random = new Random();
            for (int i = 0; tree.Count <= 4 * 4; i++)
            {
                a = random.Next(-160, 1040);
                a = (a / 20) * 20;
                YT = 1000;
                for (int j = 0; j < grass.Count + dirt.Count; j++)
                {
                    rectangle = blocks[j];
                    rectangle.X = (rectangle.X / 20) * 20;
                    rectangle.Y = (rectangle.Y / 20) * 20;
                    if (rectangle.X == a)
                    {
                        if (rectangle.Y <= YT)
                        {
                            YT = rectangle.Y;
                        }
                    }
                }
                if (tree.Count >= 1)
                {
                    for (int o = 0; o < tree.Count; o++)
                    {
                        rectangle = tree[o];
                        rectangle.X = (rectangle.X / 20) * 20;
                        rectangle.Y = (rectangle.Y / 20) * 20;
                        if (a + 20 == rectangle.X || a + 40 == rectangle.X || a - 20 == rectangle.X || a - 40 == rectangle.X || a == rectangle.X)
                        {
                            a = 1;
                        }
                    }
                    if (a != 1)
                    {
                        rectangle = new Rectangle(a, YT - 20, 20, 20);
                        tree.Add(rectangle);
                        rectangle = new Rectangle(a, YT - 40, 20, 20);
                        tree.Add(rectangle);
                        rectangle = new Rectangle(a, YT - 60, 20, 20);
                        tree.Add(rectangle);
                        rectangle = new Rectangle(a, YT - 80, 20, 20);
                        tree.Add(rectangle);
                    }
                }
                if (tree.Count < 1)
                {
                    rectangle = new Rectangle(a, YT - 20, 20, 20);
                    tree.Add(rectangle);
                    rectangle = new Rectangle(a, YT - 40, 20, 20);
                    tree.Add(rectangle);
                    rectangle = new Rectangle(a, YT - 60, 20, 20);
                    tree.Add(rectangle);
                    rectangle = new Rectangle(a, YT - 80, 20, 20);
                    tree.Add(rectangle);
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (jump == false && fall == false && e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                dvizhenie = -1;
                dvizhenie1 = false;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {           
            var mouse = this.PointToClient(Cursor.Position);
            if (inventory == 1 && Items[1].X == 25 || inventory == 2 && Items[1].X == 70 || inventory == 3 && Items[1].X == 116 || inventory == 4 && Items[1].X == 161 || inventory == 5 && Items[1].X == 206 || inventory == 6 && Items[1].X == 253 || inventory == 7 && Items[1].X == 296 || inventory == 8 && Items[1].X == 342 || inventory == 9 && Items[1].X == 387)
            {
                for (int j = 0; j < grass.Count; j++)
                {
                    rectangle = grass[j];
                    if (mouse.X >= rectangle.X && mouse.X <= rectangle.X + 20 && mouse.Y >= rectangle.Y && mouse.Y <= rectangle.Y + 20)
                    {
                        empty_block = grass[j];
                        for (int i = 0; i < grass.Count; i++)
                        {
                            Rectangles.Add(grass[i]);
                        }
                        grass.Clear();
                        for (int i = 0; i < Rectangles.Count; i++)
                        {
                            if (Rectangles[i] != empty_block)
                            {
                                grass.Add(Rectangles[i]);
                            }
                        }
                        Rectangles.Clear();
                        rectangle = Items[5];
                        rectangle.Location = empty_block.Location;
                        rectangle.Width = 10;
                        rectangle.Height = 10;
                        rectangle.X += 5;
                        rectangle.Y += 5;
                        item_fall = rectangle;
                        Items[5] = rectangle;
                        thrown.Add(Items[5]);
                        Item_fall.Enabled = true;
                    }
                }
                for (int j = 0; j < dirt.Count; j++)
                {
                    rectangle = dirt[j];
                    if (mouse.X >= rectangle.X && mouse.X <= rectangle.X + 20 && mouse.Y >= rectangle.Y && mouse.Y <= rectangle.Y + 20)
                    {
                        empty_block = dirt[j];
                        for (int i = 0; i < dirt.Count; i++)
                        {
                            Rectangles.Add(dirt[i]);
                        }
                        dirt.Clear();
                        for (int i = 0; i < Rectangles.Count; i++)
                        {
                            if (Rectangles[i] != empty_block)
                            {
                                dirt.Add(Rectangles[i]);
                            }
                        }
                        Rectangles.Clear();
                        rectangle = Items[5];
                        rectangle.Location = empty_block.Location;
                        rectangle.Width = 10;
                        rectangle.Height = 10;
                        rectangle.X += 5;
                        rectangle.Y += 5;
                        item_fall = rectangle;
                        Items[5] = rectangle;
                        thrown.Add(Items[5]);
                        Item_fall.Enabled = true;
                    }
                }
                dvizhenie_kirki.Enabled = true;
            }
            if (inventory == 1 && Items[3].X == 25 || inventory == 2 && Items[3].X == 70 || inventory == 3 && Items[3].X == 116 || inventory == 4 && Items[3].X == 161 || inventory == 5 && Items[3].X == 206 || inventory == 6 && Items[3].X == 253 || inventory == 7 && Items[3].X == 296 || inventory == 8 && Items[3].X == 342 || inventory == 9 && Items[3].X == 387)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    rectangle = blocks[i];
                    rectangle.X = (rectangle.X / 20) * 20;
                    rectangle.Y = (rectangle.Y / 20) * 20;
                    mouse.Y = (mouse.Y / 20) * 20;
                    if (mouse.X >= rectangle.X && mouse.X <= rectangle.X + 20)
                    {
                        rectangle = new Rectangle(blocks[i].X, mouse.Y, 20, 20);
                        dirt.Add(rectangle);
                    }
                }
            }
            if (inventory == 1 && Items[0].X == 25 || inventory == 2 && Items[0].X == 70 || inventory == 3 && Items[0].X == 116 || inventory == 4 && Items[0].X == 161 || inventory == 5 && Items[0].X == 206 || inventory == 6 && Items[0].X == 253 || inventory == 7 && Items[0].X == 296 || inventory == 8 && Items[0].X == 342 || inventory == 9 && Items[0].X == 387)
            {
                dvizhenie_mecha.Enabled = true;
            }
            if (inventory == 1 && Items[2].X == 25 || inventory == 2 && Items[2].X == 70 || inventory == 3 && Items[2].X == 116 || inventory == 4 && Items[2].X == 161 || inventory == 5 && Items[2].X == 206 || inventory == 6 && Items[2].X == 253 || inventory == 7 && Items[2].X == 296 || inventory == 8 && Items[2].X == 342 || inventory == 9 && Items[2].X == 387)
            {
                for (int j = 0; j < tree.Count; j++)
                {
                    rectangle = tree[j];
                    if (mouse.X >= rectangle.X && mouse.X <= rectangle.X + 20 && mouse.Y >= rectangle.Y && mouse.Y <= rectangle.Y + 20)
                    {
                        for (int o = 0; o < tree.Count; o++)
                        {
                            for (int i = 0; i < tree.Count; i++)
                            {
                                if (rectangle.X == tree[i].X && tree[i].Y <= rectangle.Y)
                                {
                                    empty_tree.Add(tree[i]);
                                }
                            }                            
                            for (int i = 0; i < tree.Count; i++)
                            {
                                Rectangles.Add(tree[i]);
                            }
                            tree.Clear();
                            for (int i = 0; i < Rectangles.Count; i++)
                            {
                                for (int u = 0; u < empty_tree.Count; u++)
                                {
                                    if (Rectangles[i] == empty_tree[u])
                                    {
                                        Rectangles.RemoveAt(i);
                                    }
                                }
                            }
                            for (int i = 0; i < Rectangles.Count; i++)
                            {
                                tree.Add(Rectangles[i]);
                            }
                            Rectangles.Clear();
                            rectangle = Items[7];
                            for (int i = 0; i < empty_tree.Count; i++)
                            {
                                rectangle.Location = empty_tree[i].Location;
                            }
                            empty_tree.Clear();
                            rectangle.Width = 10;
                            rectangle.Height = 10;
                            item_fall = rectangle;
                            Items[7] = rectangle;
                            thrown.Add(Items[7]);
                            Item_fall.Enabled = true;
                        }                        
                    }
                }
            }
            if (inventory == 1 && Items[7].X == 25 || inventory == 2 && Items[7].X == 70 || inventory == 3 && Items[7].X == 116 || inventory == 4 && Items[7].X == 161 || inventory == 5 && Items[7].X == 206 || inventory == 6 && Items[7].X == 253 || inventory == 7 && Items[7].X == 296 || inventory == 8 && Items[7].X == 342 || inventory == 9 && Items[7].X == 387)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    rectangle = blocks[i];
                    rectangle.X = (rectangle.X / 20) * 20;
                    rectangle.Y = (rectangle.Y / 20) * 20;
                    mouse.Y = (mouse.Y / 20) * 20;
                    if (mouse.X >= rectangle.X && mouse.X <= rectangle.X + 20)
                    {
                        rectangle = new Rectangle(blocks[i].X, mouse.Y, 20, 20);
                        wood_block.Add(rectangle);
                    }
                }
            }
        }
        private void dvizhenie_kirki_Tick(object sender, EventArgs e)
        {
            if (napravlenie == 1)
            {
                dvizhenie_kirki1 += 1;
                rectangle = Items[4];
                rectangle.X = XP + 12;
                rectangle.Y = YP + 10;
                Items[4] = rectangle;
                if (dvizhenie_kirki1 % 7 == 0)
                {
                    B_kirka = Resource1.анимация_кирки_1;
                    rectangle = Items[4];
                    rectangle.Y += 1;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 1)
                {
                    B_kirka = Resource1.анимация_кирки_2;
                    rectangle = Items[4];
                    rectangle.Y += 2;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 2)
                {
                    B_kirka = Resource1.анимация_кирки_3;
                    rectangle = Items[4];
                    rectangle.Y += 3;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 3)
                {
                    B_kirka = Resource1.анимация_кирки_4;
                    rectangle = Items[4];
                    rectangle.Y += 4;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 4)
                {
                    B_kirka = Resource1.анимация_кирки_5;
                    rectangle = Items[4];
                    rectangle.Y += 5;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 5)
                {
                    B_kirka = Resource1.анимация_кирки_6;
                    rectangle = Items[4];
                    rectangle.Y += 6;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 6)
                {
                    dvizhenie_kirki.Enabled = false;
                    rectangle.X = -100;
                    rectangle.Y = -100;
                    Items[4] = rectangle;
                }
            }
            if (napravlenie == -1)
            {
                dvizhenie_kirki1 += 1;
                rectangle = Items[4];
                rectangle.X = XP - 25;
                rectangle.Y = YP + 15;
                Items[4] = rectangle;
                if (dvizhenie_kirki1 % 7 == 0)
                {
                    B_kirka = Resource1._11;
                    rectangle = Items[4];
                    rectangle.Y -= 1;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 1)
                {
                    B_kirka = Resource1._22;
                    rectangle = Items[4];
                    rectangle.Y -= 2;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 2)
                {
                    B_kirka = Resource1._33;
                    rectangle = Items[4];
                    rectangle.Y -= 3;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 3)
                {
                    B_kirka = Resource1._44;
                    rectangle = Items[4];
                    rectangle.Y -= 4;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 4)
                {
                    B_kirka = Resource1._55;
                    rectangle = Items[4];
                    rectangle.Y -= 5;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 5)
                {
                    B_kirka = Resource1._66;
                    rectangle = Items[4];
                    rectangle.Y -= 6;
                    Items[4] = rectangle;
                }
                if (dvizhenie_kirki1 % 7 == 6)
                {
                    dvizhenie_kirki.Enabled = false;
                    rectangle.X = -100;
                    rectangle.Y = -100;
                    Items[4] = rectangle;
                }
            }
        }

        private void dvizhenie_mecha_Tick(object sender, EventArgs e)
        {
            if (napravlenie == 1)
            {
                dvizhenie_mecha1 += 1;
                rectangle = Items[6];
                rectangle.X = XP + 10;
                rectangle.Y = YP + 30;
                Items[6] = rectangle;
                B_sword = Resource1.анимация_меча;
                if (dvizhenie_mecha1 % 9 == 0)
                {
                    rectangle.X += 3;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 1)
                {
                    rectangle.X += 6;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 2)
                {
                    rectangle.X += 9;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 3)
                {
                    rectangle.X += 12;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 4)
                {
                    rectangle.X += 15;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 5)
                {
                    rectangle.X += 18;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 6)
                {
                    rectangle.X += 21;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 7)
                {
                    rectangle.X += 24;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 8)
                {
                    rectangle.X = -100;
                    rectangle.Y = -100;
                    Items[6] = rectangle;
                    dvizhenie_mecha.Enabled = false;
                }
            }
            if (napravlenie == -1)
            {
                dvizhenie_mecha1 += 1;
                rectangle = Items[6];
                rectangle.X = XP - 25;
                rectangle.Y = YP + 30;
                Items[6] = rectangle;
                B_sword = Resource1.анимация_меча1;
                if (dvizhenie_mecha1 % 9 == 0)
                {
                    rectangle.X -= 3;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 1)
                {
                    rectangle.X -= 6;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 2)
                {
                    rectangle.X -= 9;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 3)
                {
                    rectangle.X -= 12;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 4)
                {
                    rectangle.X -= 15;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 5)
                {
                    rectangle.X -= 18;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 6)
                {
                    rectangle.X -= 21;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 7)
                {
                    rectangle.X -= 24;
                    Items[6] = rectangle;
                }
                if (dvizhenie_mecha1 % 9 == 8)
                {
                    rectangle.X = -100;
                    rectangle.Y = -100;
                    Items[6] = rectangle;
                    dvizhenie_mecha.Enabled = false;
                }
            }
        }
        private void slime_life_Tick(object sender, EventArgs e)
        {
            slime_jump = true;
            if (XS <= XP)
            {
                player_side = 1;
            }
            if (XS > XP)
            {
                player_side = -1;
            }
            slime_life.Enabled = false;
        }
        private void damage_Tick(object sender, EventArgs e)
        {
            int mXP = (XP / 20) * 20;
            int mYP = (YP / 20) * 20;
            int mXS = (XS / 20) * 20;
            int mYS = (YS / 20) * 20;
            if (mXS < mXP + 40 && mXS > mXP && mYS > mYP && mYS + 30 < mXP + 70 || mXS + 40 < mXP + 40 && mXS + 40 > mXP && mYS > mYP && mYS + 30 < mXP + 70)
            {
                life -= 1;
            }
        }
    }
}