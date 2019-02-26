using System;
using System.Windows.Forms;

/** Hi,this is the main class for SUDUKU-Solver,
    Basicly, it will check Horizontal line, Vertical line and 9 squre values.
    after that set up values.
    这个类是9宫格数字解决的主类。
    它主要通过横向，纵向值还有小九宫格值的排除法来计算出合理的数字。
    date:17-02-2019
    Author:Nurahmat Turak
**/
namespace SUDOKU
{
    public partial class Form1 : Form
    {
        /**
         * setup empty array for every cell.
         * */
        private int[] a1 = new int[10];
        private int[] a2 = new int[10];
        private int[] a3 = new int[10];
        private int[] a4 = new int[10];
        private int[] a5 = new int[10];
        private int[] a6 = new int[10];
        private int[] a7 = new int[10];
        private int[] a8 = new int[10];
        private int[] a9 = new int[10];

        private int[] b1 = new int[10];
        private int[] b2 = new int[10];
        private int[] b3 = new int[10];
        private int[] b4 = new int[10];
        private int[] b5 = new int[10];
        private int[] b6 = new int[10];
        private int[] b7 = new int[10];
        private int[] b8 = new int[10];
        private int[] b9 = new int[10];

        private int[] c1 = new int[10];
        private int[] c2 = new int[10];
        private int[] c3 = new int[10];
        private int[] c4 = new int[10];
        private int[] c5 = new int[10];
        private int[] c6 = new int[10];
        private int[] c7 = new int[10];
        private int[] c8 = new int[10];
        private int[] c9 = new int[10];

        private int[] d1 = new int[10];
        private int[] d2 = new int[10];
        private int[] d3 = new int[10];
        private int[] d4 = new int[10];
        private int[] d5 = new int[10];
        private int[] d6 = new int[10];
        private int[] d7 = new int[10];
        private int[] d8 = new int[10];
        private int[] d9 = new int[10];

        private int[] e1 = new int[10];
        private int[] e2 = new int[10];
        private int[] e3 = new int[10];
        private int[] e4 = new int[10];
        private int[] e5 = new int[10];
        private int[] e6 = new int[10];
        private int[] e7 = new int[10];
        private int[] e8 = new int[10];
        private int[] e9 = new int[10];

        private int[] f1 = new int[10];
        private int[] f2 = new int[10];
        private int[] f3 = new int[10];
        private int[] f4 = new int[10];
        private int[] f5 = new int[10];
        private int[] f6 = new int[10];
        private int[] f7 = new int[10];
        private int[] f8 = new int[10];
        private int[] f9 = new int[10];

        private int[] g1 = new int[10];
        private int[] g2 = new int[10];
        private int[] g3 = new int[10];
        private int[] g4 = new int[10];
        private int[] g5 = new int[10];
        private int[] g6 = new int[10];
        private int[] g7 = new int[10];
        private int[] g8 = new int[10];
        private int[] g9 = new int[10];

        private int[] h1 = new int[10];
        private int[] h2 = new int[10];
        private int[] h3 = new int[10];
        private int[] h4 = new int[10];
        private int[] h5 = new int[10];
        private int[] h6 = new int[10];
        private int[] h7 = new int[10];
        private int[] h8 = new int[10];
        private int[] h9 = new int[10];

        private int[] i1 = new int[10];
        private int[] i2 = new int[10];
        private int[] i3 = new int[10];
        private int[] i4 = new int[10];
        private int[] i5 = new int[10];
        private int[] i6 = new int[10];
        private int[] i7 = new int[10];
        private int[] i8 = new int[10];
        private int[] i9 = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        public void init()
            /**
             * in the array, the last value will hold the original value from the table
             * if exists.
             * */
        {
            a1[9] = (A1.Text == "") ? 0 : Convert.ToInt32(A1.Text);
            a2[9] = (A2.Text == "") ? 0 : Convert.ToInt32(A2.Text);
            a3[9] = (A3.Text == "") ? 0 : Convert.ToInt32(A3.Text);
            a4[9] = (A4.Text == "") ? 0 : Convert.ToInt32(A4.Text);
            a5[9] = (A5.Text == "") ? 0 : Convert.ToInt32(A5.Text);
            a6[9] = (A6.Text == "") ? 0 : Convert.ToInt32(A6.Text);
            a7[9] = (A7.Text == "") ? 0 : Convert.ToInt32(A7.Text);
            a8[9] = (A8.Text == "") ? 0 : Convert.ToInt32(A8.Text);
            a9[9] = (A9.Text == "") ? 0 : Convert.ToInt32(A9.Text);

            b1[9] = (B1.Text == "") ? 0 : Convert.ToInt32(B1.Text);
            b2[9] = (B2.Text == "") ? 0 : Convert.ToInt32(B2.Text);
            b3[9] = (B3.Text == "") ? 0 : Convert.ToInt32(B3.Text);
            b4[9] = (B4.Text == "") ? 0 : Convert.ToInt32(B4.Text);
            b5[9] = (B5.Text == "") ? 0 : Convert.ToInt32(B5.Text);
            b6[9] = (B6.Text == "") ? 0 : Convert.ToInt32(B6.Text);
            b7[9] = (B7.Text == "") ? 0 : Convert.ToInt32(B7.Text);
            b8[9] = (B8.Text == "") ? 0 : Convert.ToInt32(B8.Text);
            b9[9] = (B9.Text == "") ? 0 : Convert.ToInt32(B9.Text);

            c1[9] = (C1.Text == "") ? 0 : Convert.ToInt32(C1.Text);
            c2[9] = (C2.Text == "") ? 0 : Convert.ToInt32(C2.Text);
            c3[9] = (C3.Text == "") ? 0 : Convert.ToInt32(C3.Text);
            c4[9] = (C4.Text == "") ? 0 : Convert.ToInt32(C4.Text);
            c5[9] = (C5.Text == "") ? 0 : Convert.ToInt32(C5.Text);
            c6[9] = (C6.Text == "") ? 0 : Convert.ToInt32(C6.Text);
            c7[9] = (C7.Text == "") ? 0 : Convert.ToInt32(C7.Text);
            c8[9] = (C8.Text == "") ? 0 : Convert.ToInt32(C8.Text);
            c9[9] = (C9.Text == "") ? 0 : Convert.ToInt32(C9.Text);

            d1[9] = (D1.Text == "") ? 0 : Convert.ToInt32(D1.Text);
            d2[9] = (D2.Text == "") ? 0 : Convert.ToInt32(D2.Text);
            d3[9] = (D3.Text == "") ? 0 : Convert.ToInt32(D3.Text);
            d4[9] = (D4.Text == "") ? 0 : Convert.ToInt32(D4.Text);
            d5[9] = (D5.Text == "") ? 0 : Convert.ToInt32(D5.Text);
            d6[9] = (D6.Text == "") ? 0 : Convert.ToInt32(D6.Text);
            d7[9] = (D7.Text == "") ? 0 : Convert.ToInt32(D7.Text);
            d8[9] = (D8.Text == "") ? 0 : Convert.ToInt32(D8.Text);
            d9[9] = (D9.Text == "") ? 0 : Convert.ToInt32(D9.Text);

            e1[9] = (E1.Text == "") ? 0 : Convert.ToInt32(E1.Text);
            e2[9] = (E2.Text == "") ? 0 : Convert.ToInt32(E2.Text);
            e3[9] = (E3.Text == "") ? 0 : Convert.ToInt32(E3.Text);
            e4[9] = (E4.Text == "") ? 0 : Convert.ToInt32(E4.Text);
            e5[9] = (E5.Text == "") ? 0 : Convert.ToInt32(E5.Text);
            e6[9] = (E6.Text == "") ? 0 : Convert.ToInt32(E6.Text);
            e7[9] = (E7.Text == "") ? 0 : Convert.ToInt32(E7.Text);
            e8[9] = (E8.Text == "") ? 0 : Convert.ToInt32(E8.Text);
            e9[9] = (E9.Text == "") ? 0 : Convert.ToInt32(E9.Text);

            f1[9] = (F1.Text == "") ? 0 : Convert.ToInt32(F1.Text);
            f2[9] = (F2.Text == "") ? 0 : Convert.ToInt32(F2.Text);
            f3[9] = (F3.Text == "") ? 0 : Convert.ToInt32(F3.Text);
            f4[9] = (F4.Text == "") ? 0 : Convert.ToInt32(F4.Text);
            f5[9] = (F5.Text == "") ? 0 : Convert.ToInt32(F5.Text);
            f6[9] = (F6.Text == "") ? 0 : Convert.ToInt32(F6.Text);
            f7[9] = (F7.Text == "") ? 0 : Convert.ToInt32(F7.Text);
            f8[9] = (F8.Text == "") ? 0 : Convert.ToInt32(F8.Text);
            f9[9] = (F9.Text == "") ? 0 : Convert.ToInt32(F9.Text);

            g1[9] = (G1.Text == "") ? 0 : Convert.ToInt32(G1.Text);
            g2[9] = (G2.Text == "") ? 0 : Convert.ToInt32(G2.Text);
            g3[9] = (G3.Text == "") ? 0 : Convert.ToInt32(G3.Text);
            g4[9] = (G4.Text == "") ? 0 : Convert.ToInt32(G4.Text);
            g5[9] = (G5.Text == "") ? 0 : Convert.ToInt32(G5.Text);
            g6[9] = (G6.Text == "") ? 0 : Convert.ToInt32(G6.Text);
            g7[9] = (G7.Text == "") ? 0 : Convert.ToInt32(G7.Text);
            g8[9] = (G8.Text == "") ? 0 : Convert.ToInt32(G8.Text);
            g9[9] = (G9.Text == "") ? 0 : Convert.ToInt32(G9.Text);

            h1[9] = (H1.Text == "") ? 0 : Convert.ToInt32(H1.Text);
            h2[9] = (H2.Text == "") ? 0 : Convert.ToInt32(H2.Text);
            h3[9] = (H3.Text == "") ? 0 : Convert.ToInt32(H3.Text);
            h4[9] = (H4.Text == "") ? 0 : Convert.ToInt32(H4.Text);
            h5[9] = (H5.Text == "") ? 0 : Convert.ToInt32(H5.Text);
            h6[9] = (H6.Text == "") ? 0 : Convert.ToInt32(H6.Text);
            h7[9] = (H7.Text == "") ? 0 : Convert.ToInt32(H7.Text);
            h8[9] = (H8.Text == "") ? 0 : Convert.ToInt32(H8.Text);
            h9[9] = (H9.Text == "") ? 0 : Convert.ToInt32(H9.Text);

            i1[9] = (I1.Text == "") ? 0 : Convert.ToInt32(I1.Text);
            i2[9] = (I.Text == "") ? 0 : Convert.ToInt32(I.Text);
            /**this place has a freaking bug, I did not create any components
            **which name I2, but when I want to change name to I2.
            * the IDE giving me that eror says already has a component names I2.
            * */
            i3[9] = (I3.Text == "") ? 0 : Convert.ToInt32(I3.Text);
            i4[9] = (I4.Text == "") ? 0 : Convert.ToInt32(I4.Text);
            i5[9] = (I5.Text == "") ? 0 : Convert.ToInt32(I5.Text);
            i6[9] = (I6.Text == "") ? 0 : Convert.ToInt32(I6.Text);
            i7[9] = (I7.Text == "") ? 0 : Convert.ToInt32(I7.Text);
            i8[9] = (I8.Text == "") ? 0 : Convert.ToInt32(I8.Text);
            i9[9] = (I9.Text == "") ? 0 : Convert.ToInt32(I9.Text);
        }

        public void Setter()
        {

            for (int i = 1; i < 10; i++)
            {
                if (a1[9] == 0)
                {
                    a1[i - 1] = i;
                    //  Console.WriteLine("a1["+(i - 1)+"]"+ "="+ i);
                }
                if (a2[9] == 0)
                {
                    a2[i - 1] = i;
                }
                if (a3[9] == 0)
                {
                    a3[i - 1] = i;
                }
                if (a4[9] == 0)
                {
                    a4[i - 1] = i;
                }
                if (a5[9] == 0)
                {
                    a5[i - 1] = i;
                }
                if (a6[9] == 0)
                {
                    a6[i - 1] = i;
                }
                if (a7[9] == 0)
                {
                    a7[i - 1] = i;
                }
                if (a8[9] == 0)
                {
                    a8[i - 1] = i;
                }
                if (a9[9] == 0)
                {
                    a9[i - 1] = i;
                }

                //a end
                if (b1[9] == 0)
                {
                    b1[i - 1] = i;
                }
                if (b2[9] == 0)
                {
                    b2[i - 1] = i;
                }
                if (b3[9] == 0)
                {
                    b3[i - 1] = i;
                }
                if (b4[9] == 0)
                {
                    b4[i - 1] = i;
                }
                if (b5[9] == 0)
                {
                    b5[i - 1] = i;
                }
                if (b6[9] == 0)
                {
                    b6[i - 1] = i;
                }
                if (b7[9] == 0)
                {
                    b7[i - 1] = i;
                }
                if (b8[9] == 0)
                {
                    b8[i - 1] = i;
                }
                if (b9[9] == 0)
                {
                    b9[i - 1] = i;
                }

                if (c1[9] == 0)
                {
                    c1[i - 1] = i;
                }
                if (c2[9] == 0)
                {
                    c2[i - 1] = i;
                }
                if (c3[9] == 0)
                {
                    c3[i - 1] = i;
                }
                if (c4[9] == 0)
                {
                    c4[i - 1] = i;
                }
                if (c5[9] == 0)
                {
                    c5[i - 1] = i;
                }
                if (c6[9] == 0)
                {
                    c6[i - 1] = i;
                }
                if (c7[9] == 0)
                {
                    c7[i - 1] = i;
                }
                if (c8[9] == 0)
                {
                    c8[i - 1] = i;
                }
                if (c9[9] == 0)
                {
                    c9[i - 1] = i;
                }

                //c end

                if (d1[9] == 0)
                {
                    d1[i - 1] = i;
                }
                if (d2[9] == 0)
                {
                    d2[i - 1] = i;
                }
                if (d3[9] == 0)
                {
                    d3[i - 1] = i;
                }
                if (d4[9] == 0)
                {
                    d4[i - 1] = i;
                }
                if (d5[9] == 0)
                {
                    d5[i - 1] = i;
                }
                if (d6[9] == 0)
                {
                    d6[i - 1] = i;
                }
                if (d7[9] == 0)
                {
                    d7[i - 1] = i;
                }
                if (d8[9] == 0)
                {
                    d8[i - 1] = i;
                }
                if (d9[9] == 0)
                {
                    d9[i - 1] = i;
                }
                //d end
                if (e1[9] == 0)
                {
                    e1[i - 1] = i;
                }
                if (e2[9] == 0)
                {
                    e2[i - 1] = i;
                }
                if (e3[9] == 0)
                {
                    e3[i - 1] = i;
                }
                if (e4[9] == 0)
                {
                    e4[i - 1] = i;
                }
                if (e5[9] == 0)
                {
                    e5[i - 1] = i;
                }
                if (e6[9] == 0)
                {
                    e6[i - 1] = i;
                }
                if (e7[9] == 0)
                {
                    e7[i - 1] = i;
                }
                if (e8[9] == 0)
                {
                    e8[i - 1] = i;
                }
                if (e9[9] == 0)
                {
                    e9[i - 1] = i;
                }
                //e end
                if (f1[9] == 0)
                {
                    f1[i - 1] = i;
                }
                if (f2[9] == 0)
                {
                    f2[i - 1] = i;
                }
                if (f3[9] == 0)
                {
                    f3[i - 1] = i;
                }
                if (f4[9] == 0)
                {
                    f4[i - 1] = i;
                }
                if (f5[9] == 0)
                {
                    f5[i - 1] = i;
                }
                if (f6[9] == 0)
                {
                    f6[i - 1] = i;
                }
                if (f7[9] == 0)
                {
                    f7[i - 1] = i;
                }
                if (f8[9] == 0)
                {
                    f8[i - 1] = i;
                }
                if (f9[9] == 0)
                {
                    f9[i - 1] = i;
                }

                //f end

                if (h1[9] == 0)
                {
                    h1[i - 1] = i;
                }
                if (h2[9] == 0)
                {
                    h2[i - 1] = i;
                }
                if (h3[9] == 0)
                {
                    h3[i - 1] = i;
                }
                if (h4[9] == 0)
                {
                    h4[i - 1] = i;
                }
                if (h5[9] == 0)
                {
                    h5[i - 1] = i;
                }
                if (h6[9] == 0)
                {
                    h6[i - 1] = i;
                }
                if (h7[9] == 0)
                {
                    h7[i - 1] = i;
                }
                if (h8[9] == 0)
                {
                    h8[i - 1] = i;
                }
                if (h9[9] == 0)
                {
                    h9[i - 1] = i;
                }
                //h end
                if (g1[9] == 0)
                {
                    g1[i - 1] = i;
                }
                if (g2[9] == 0)
                {
                    g2[i - 1] = i;
                }
                if (g3[9] == 0)
                {
                    g3[i - 1] = i;
                }
                if (g4[9] == 0)
                {
                    g4[i - 1] = i;
                }
                if (g5[9] == 0)
                {
                    g5[i - 1] = i;
                }
                if (g6[9] == 0)
                {
                    g6[i - 1] = i;
                }
                if (g7[9] == 0)
                {
                    g7[i - 1] = i;
                }
                if (g8[9] == 0)
                {
                    g8[i - 1] = i;
                }
                if (g9[9] == 0)
                {
                    g9[i - 1] = i;
                }
                //g end

                if (i1[9] == 0)
                {
                    i1[i - 1] = i;
                }
                if (i2[9] == 0)
                {
                    i2[i - 1] = i;
                }
                if (i3[9] == 0)
                {
                    i3[i - 1] = i;
                }
                if (i4[9] == 0)
                {
                    i4[i - 1] = i;
                }
                if (i5[9] == 0)
                {
                    i5[i - 1] = i;
                }
                if (i6[9] == 0)
                {
                    i6[i - 1] = i;
                }
                if (i7[9] == 0)
                {
                    i7[i - 1] = i;
                }
                if (i8[9] == 0)
                {
                    i8[i - 1] = i;
                }
                if (i9[9] == 0)
                {
                    i9[i - 1] = i;
                }
            }
        }

        //setter end
        public void Check_Vertical()
        {

            if (a1[9] != 0)
            {
                a2[a1[9] - 1] = 0;
                a3[a1[9] - 1] = 0;
                a4[a1[9] - 1] = 0;
                a5[a1[9] - 1] = 0;
                a6[a1[9] - 1] = 0;
                a7[a1[9] - 1] = 0;
                a8[a1[9] - 1] = 0;
                a9[a1[9] - 1] = 0;
            }

            if (a2[9] != 0)
            {
                a1[a2[9] - 1] = 0;
                a3[a2[9] - 1] = 0;
                a4[a2[9] - 1] = 0;
                a5[a2[9] - 1] = 0;
                a6[a2[9] - 1] = 0;
                a7[a2[9] - 1] = 0;
                a8[a2[9] - 1] = 0;
                a9[a2[9] - 1] = 0;
            }
            if (a3[9] != 0)
            {
                a1[a3[9] - 1] = 0;
                a2[a3[9] - 1] = 0;
                a4[a3[9] - 1] = 0;
                a5[a3[9] - 1] = 0;
                a6[a3[9] - 1] = 0;
                a7[a3[9] - 1] = 0;
                a8[a3[9] - 1] = 0;
                a9[a3[9] - 1] = 0;
            }
            if (a4[9] != 0)
            {
                a1[a4[9] - 1] = 0;
                a2[a4[9] - 1] = 0;
                a3[a4[9] - 1] = 0;
                a5[a4[9] - 1] = 0;
                a6[a4[9] - 1] = 0;
                a7[a4[9] - 1] = 0;
                a8[a4[9] - 1] = 0;
                a9[a4[9] - 1] = 0;
            }
            if (a5[9] != 0)
            {
                a1[a5[9] - 1] = 0;
                a2[a5[9] - 1] = 0;
                a3[a5[9] - 1] = 0;
                a4[a5[9] - 1] = 0;
                a6[a5[9] - 1] = 0;
                a7[a5[9] - 1] = 0;
                a8[a5[9] - 1] = 0;
                a9[a5[9] - 1] = 0;
            }
            if (a6[9] != 0)
            {
                a1[a6[9] - 1] = 0;
                a2[a6[9] - 1] = 0;
                a3[a6[9] - 1] = 0;
                a4[a6[9] - 1] = 0;
                a5[a6[9] - 1] = 0;
                a7[a6[9] - 1] = 0;
                a8[a6[9] - 1] = 0;
                a9[a6[9] - 1] = 0;
            }
            if (a7[9] != 0)
            {
                a1[a7[9] - 1] = 0;
                a2[a7[9] - 1] = 0;
                a3[a7[9] - 1] = 0;
                a4[a7[9] - 1] = 0;
                a5[a7[9] - 1] = 0;
                a6[a7[9] - 1] = 0;
                a8[a7[9] - 1] = 0;
                a9[a7[9] - 1] = 0;
            }
            if (a8[9] != 0)
            {
                a1[a8[9] - 1] = 0;
                a2[a8[9] - 1] = 0;
                a3[a8[9] - 1] = 0;
                a4[a8[9] - 1] = 0;
                a5[a8[9] - 1] = 0;
                a6[a8[9] - 1] = 0;
                a7[a8[9] - 1] = 0;
                a9[a8[9] - 1] = 0;
            }
            if (a9[9] != 0)
            {
                a1[a9[9] - 1] = 0;
                a2[a9[9] - 1] = 0;
                a3[a9[9] - 1] = 0;
                a4[a9[9] - 1] = 0;
                a5[a9[9] - 1] = 0;
                a6[a9[9] - 1] = 0;
                a7[a9[9] - 1] = 0;
                a8[a9[9] - 1] = 0;
            }

            //a end
            if (b1[9] != 0)
            {
                b2[b1[9] - 1] = 0;
                b3[b1[9] - 1] = 0;
                b4[b1[9] - 1] = 0;
                b5[b1[9] - 1] = 0;
                b6[b1[9] - 1] = 0;
                b7[b1[9] - 1] = 0;
                b8[b1[9] - 1] = 0;
                b9[b1[9] - 1] = 0;
            }
            if (b2[9] != 0)
            {
                b1[b2[9] - 1] = 0;
                b3[b2[9] - 1] = 0;
                b4[b2[9] - 1] = 0;
                b5[b2[9] - 1] = 0;
                b6[b2[9] - 1] = 0;
                b7[b2[9] - 1] = 0;
                b8[b2[9] - 1] = 0;
                b9[b2[9] - 1] = 0;
            }
            if (b3[9] != 0)
            {
                b1[b3[9] - 1] = 0;
                b2[b3[9] - 1] = 0;
                b4[b3[9] - 1] = 0;
                b5[b3[9] - 1] = 0;
                b6[b3[9] - 1] = 0;
                b7[b3[9] - 1] = 0;
                b8[b3[9] - 1] = 0;
                b9[b3[9] - 1] = 0;
            }
            if (b4[9] != 0)
            {
                b1[b4[9] - 1] = 0;
                b2[b4[9] - 1] = 0;
                b3[b4[9] - 1] = 0;
                b5[b4[9] - 1] = 0;
                b6[b4[9] - 1] = 0;
                b7[b4[9] - 1] = 0;
                b8[b4[9] - 1] = 0;
                b9[b4[9] - 1] = 0;
            }
            if (b5[9] != 0)
            {
                b1[b5[9] - 1] = 0;
                b2[b5[9] - 1] = 0;
                b3[b5[9] - 1] = 0;
                b4[b5[9] - 1] = 0;
                b6[b5[9] - 1] = 0;
                b7[b5[9] - 1] = 0;
                b8[b5[9] - 1] = 0;
                b9[b5[9] - 1] = 0;
            }
            if (b6[9] != 0)
            {
                b1[b6[9] - 1] = 0;
                b2[b6[9] - 1] = 0;
                b3[b6[9] - 1] = 0;
                b4[b6[9] - 1] = 0;
                b5[b6[9] - 1] = 0;
                b7[b6[9] - 1] = 0;
                b8[b6[9] - 1] = 0;
                b9[b6[9] - 1] = 0;
            }
            if (b7[9] != 0)
            {
                b1[b7[9] - 1] = 0;
                b2[b7[9] - 1] = 0;
                b3[b7[9] - 1] = 0;
                b4[b7[9] - 1] = 0;
                b5[b7[9] - 1] = 0;
                b6[b7[9] - 1] = 0;
                b8[b7[9] - 1] = 0;
                b9[b7[9] - 1] = 0;
            }
            if (b8[9] != 0)
            {
                b1[b8[9] - 1] = 0;
                b2[b8[9] - 1] = 0;
                b3[b8[9] - 1] = 0;
                b4[b8[9] - 1] = 0;
                b5[b8[9] - 1] = 0;
                b6[b8[9] - 1] = 0;
                b7[b8[9] - 1] = 0;
                b9[b8[9] - 1] = 0;
            }
            if (b9[9] != 0)
            {
                b1[b9[9] - 1] = 0;
                b2[b9[9] - 1] = 0;
                b3[b9[9] - 1] = 0;
                b4[b9[9] - 1] = 0;
                b5[b9[9] - 1] = 0;
                b6[b9[9] - 1] = 0;
                b7[b9[9] - 1] = 0;
                b8[b9[9] - 1] = 0;
            }
            //b END
            if (c1[9] != 0)
            {
                c2[c1[9] - 1] = 0;
                c3[c1[9] - 1] = 0;
                c4[c1[9] - 1] = 0;
                c5[c1[9] - 1] = 0;
                c6[c1[9] - 1] = 0;
                c7[c1[9] - 1] = 0;
                c8[c1[9] - 1] = 0;
                c9[c1[9] - 1] = 0;
            }
            if (c2[9] != 0)
            {
                c1[c2[9] - 1] = 0;
                c3[c2[9] - 1] = 0;
                c4[c2[9] - 1] = 0;
                c5[c2[9] - 1] = 0;
                c6[c2[9] - 1] = 0;
                c7[c2[9] - 1] = 0;
                c8[c2[9] - 1] = 0;
                c9[c2[9] - 1] = 0;
            }
            if (c3[9] != 0)
            {
                c1[c3[9] - 1] = 0;
                c2[c3[9] - 1] = 0;
                c4[c3[9] - 1] = 0;
                c5[c3[9] - 1] = 0;
                c6[c3[9] - 1] = 0;
                c7[c3[9] - 1] = 0;
                c8[c3[9] - 1] = 0;
                c9[c3[9] - 1] = 0;
            }
            if (c4[9] != 0)
            {
                c1[c4[9] - 1] = 0;
                c2[c4[9] - 1] = 0;
                c3[c4[9] - 1] = 0;
                c5[c4[9] - 1] = 0;
                c6[c4[9] - 1] = 0;
                c7[c4[9] - 1] = 0;
                c8[c4[9] - 1] = 0;
                c9[c4[9] - 1] = 0;
            }
            if (c5[9] != 0)
            {
                c1[c5[9] - 1] = 0;
                c2[c5[9] - 1] = 0;
                c3[c5[9] - 1] = 0;
                c4[c5[9] - 1] = 0;
                c6[c5[9] - 1] = 0;
                c7[c5[9] - 1] = 0;
                c8[c5[9] - 1] = 0;
                c9[c5[9] - 1] = 0;
            }
            if (c6[9] != 0)
            {
                c1[c6[9] - 1] = 0;
                c2[c6[9] - 1] = 0;
                c3[c6[9] - 1] = 0;
                c4[c6[9] - 1] = 0;
                c5[c6[9] - 1] = 0;
                c7[c6[9] - 1] = 0;
                c8[c6[9] - 1] = 0;
                c9[c6[9] - 1] = 0;
            }
            if (c7[9] != 0)
            {
                c1[c7[9] - 1] = 0;
                c2[c7[9] - 1] = 0;
                c3[c7[9] - 1] = 0;
                c4[c7[9] - 1] = 0;
                c5[c7[9] - 1] = 0;
                c6[c7[9] - 1] = 0;
                c8[c7[9] - 1] = 0;
                c9[c7[9] - 1] = 0;
            }
            if (c8[9] != 0)
            {
                c1[c8[9] - 1] = 0;
                c2[c8[9] - 1] = 0;
                c3[c8[9] - 1] = 0;
                c4[c8[9] - 1] = 0;
                c5[c8[9] - 1] = 0;
                c6[c8[9] - 1] = 0;
                c7[c8[9] - 1] = 0;
                c9[c8[9] - 1] = 0;
            }
            if (c9[9] != 0)
            {
                c1[c9[9] - 1] = 0;
                c2[c9[9] - 1] = 0;
                c3[c9[9] - 1] = 0;
                c4[c9[9] - 1] = 0;
                c5[c9[9] - 1] = 0;
                c6[c9[9] - 1] = 0;
                c7[c9[9] - 1] = 0;
                c8[c9[9] - 1] = 0;
            }
            //c END
            if (d1[9] != 0)
            {
                d2[d1[9] - 1] = 0;
                d3[d1[9] - 1] = 0;
                d4[d1[9] - 1] = 0;
                d5[d1[9] - 1] = 0;
                d6[d1[9] - 1] = 0;
                d7[d1[9] - 1] = 0;
                d8[d1[9] - 1] = 0;
                d9[d1[9] - 1] = 0;
            }
            if (d2[9] != 0)
            {
                d1[d2[9] - 1] = 0;
                d3[d2[9] - 1] = 0;
                d4[d2[9] - 1] = 0;
                d5[d2[9] - 1] = 0;
                d6[d2[9] - 1] = 0;
                d7[d2[9] - 1] = 0;
                d8[d2[9] - 1] = 0;
                d9[d2[9] - 1] = 0;
            }
            if (d3[9] != 0)
            {
                d1[d3[9] - 1] = 0;
                d2[d3[9] - 1] = 0;
                d4[d3[9] - 1] = 0;
                d5[d3[9] - 1] = 0;
                d6[d3[9] - 1] = 0;
                d7[d3[9] - 1] = 0;
                d8[d3[9] - 1] = 0;
                d9[d3[9] - 1] = 0;
            }
            if (d4[9] != 0)
            {
                d1[d4[9] - 1] = 0;
                d2[d4[9] - 1] = 0;
                d3[d4[9] - 1] = 0;
                d5[d4[9] - 1] = 0;
                d6[d4[9] - 1] = 0;
                d7[d4[9] - 1] = 0;
                d8[d4[9] - 1] = 0;
                d9[d4[9] - 1] = 0;
            }
            if (d5[9] != 0)
            {
                d1[d5[9] - 1] = 0;
                d2[d5[9] - 1] = 0;
                d3[d5[9] - 1] = 0;
                d4[d5[9] - 1] = 0;
                d6[d5[9] - 1] = 0;
                d7[d5[9] - 1] = 0;
                d8[d5[9] - 1] = 0;
                d9[d5[9] - 1] = 0;
            }
            if (d6[9] != 0)
            {
                d1[d6[9] - 1] = 0;
                d2[d6[9] - 1] = 0;
                d3[d6[9] - 1] = 0;
                d4[d6[9] - 1] = 0;
                d5[d6[9] - 1] = 0;
                d7[d6[9] - 1] = 0;
                d8[d6[9] - 1] = 0;
                d9[d6[9] - 1] = 0;
            }
            if (d7[9] != 0)
            {
                d1[d7[9] - 1] = 0;
                d2[d7[9] - 1] = 0;
                d3[d7[9] - 1] = 0;
                d4[d7[9] - 1] = 0;
                d5[d7[9] - 1] = 0;
                d6[d7[9] - 1] = 0;
                d8[d7[9] - 1] = 0;
                d9[d7[9] - 1] = 0;
            }
            if (d8[9] != 0)
            {
                d1[d8[9] - 1] = 0;
                d2[d8[9] - 1] = 0;
                d3[d8[9] - 1] = 0;
                d4[d8[9] - 1] = 0;
                d5[d8[9] - 1] = 0;
                d6[d8[9] - 1] = 0;
                d7[d8[9] - 1] = 0;
                d9[d8[9] - 1] = 0;
            }
            if (d9[9] != 0)
            {
                d1[d9[9] - 1] = 0;
                d2[d9[9] - 1] = 0;
                d3[d9[9] - 1] = 0;
                d4[d9[9] - 1] = 0;
                d5[d9[9] - 1] = 0;
                d6[d9[9] - 1] = 0;
                d7[d9[9] - 1] = 0;
                d8[d9[9] - 1] = 0;
            }
            //D end
            if (e1[9] != 0)
            {
                e2[e1[9] - 1] = 0;
                e3[e1[9] - 1] = 0;
                e4[e1[9] - 1] = 0;
                e5[e1[9] - 1] = 0;
                e6[e1[9] - 1] = 0;
                e7[e1[9] - 1] = 0;
                e8[e1[9] - 1] = 0;
                e9[e1[9] - 1] = 0;
            }
            if (e2[9] != 0)
            {
                e1[e2[9] - 1] = 0;
                e3[e2[9] - 1] = 0;
                e4[e2[9] - 1] = 0;
                e5[e2[9] - 1] = 0;
                e6[e2[9] - 1] = 0;
                e7[e2[9] - 1] = 0;
                e8[e2[9] - 1] = 0;
                e9[e2[9] - 1] = 0;
            }
            if (e3[9] != 0)
            {
                e1[e3[9] - 1] = 0;
                e2[e3[9] - 1] = 0;
                e4[e3[9] - 1] = 0;
                e5[e3[9] - 1] = 0;
                e6[e3[9] - 1] = 0;
                e7[e3[9] - 1] = 0;
                e8[e3[9] - 1] = 0;
                e9[e3[9] - 1] = 0;
            }
            if (e4[9] != 0)
            {
                e1[e4[9] - 1] = 0;
                e2[e4[9] - 1] = 0;
                e3[e4[9] - 1] = 0;
                e5[e4[9] - 1] = 0;
                e6[e4[9] - 1] = 0;
                e7[e4[9] - 1] = 0;
                e8[e4[9] - 1] = 0;
                e9[e4[9] - 1] = 0;
            }
            if (e5[9] != 0)
            {
                e1[e5[9] - 1] = 0;
                e2[e5[9] - 1] = 0;
                e3[e5[9] - 1] = 0;
                e4[e5[9] - 1] = 0;
                e6[e5[9] - 1] = 0;
                e7[e5[9] - 1] = 0;
                e8[e5[9] - 1] = 0;
                e9[e5[9] - 1] = 0;
            }
            if (e6[9] != 0)
            {
                e1[e6[9] - 1] = 0;
                e2[e6[9] - 1] = 0;
                e3[e6[9] - 1] = 0;
                e4[e6[9] - 1] = 0;
                e5[e6[9] - 1] = 0;
                e7[e6[9] - 1] = 0;
                e8[e6[9] - 1] = 0;
                e9[e6[9] - 1] = 0;
            }
            if (e7[9] != 0)
            {
                e1[e7[9] - 1] = 0;
                e2[e7[9] - 1] = 0;
                e3[e7[9] - 1] = 0;
                e4[e7[9] - 1] = 0;
                e5[e7[9] - 1] = 0;
                e6[e7[9] - 1] = 0;
                e8[e7[9] - 1] = 0;
                e9[e7[9] - 1] = 0;
            }
            if (e8[9] != 0)
            {
                e1[e8[9] - 1] = 0;
                e2[e8[9] - 1] = 0;
                e3[e8[9] - 1] = 0;
                e4[e8[9] - 1] = 0;
                e5[e8[9] - 1] = 0;
                e6[e8[9] - 1] = 0;
                e7[e8[9] - 1] = 0;
                e9[e8[9] - 1] = 0;
            }
            if (e9[9] != 0)
            {
                e1[e9[9] - 1] = 0;
                e2[e9[9] - 1] = 0;
                e3[e9[9] - 1] = 0;
                e4[e9[9] - 1] = 0;
                e5[e9[9] - 1] = 0;
                e6[e9[9] - 1] = 0;
                e7[e9[9] - 1] = 0;
                e8[e9[9] - 1] = 0;
            }
            //E end
            if (f1[9] != 0)
            {
                f2[f1[9] - 1] = 0;
                f3[f1[9] - 1] = 0;
                f4[f1[9] - 1] = 0;
                f5[f1[9] - 1] = 0;
                f6[f1[9] - 1] = 0;
                f7[f1[9] - 1] = 0;
                f8[f1[9] - 1] = 0;
                f9[f1[9] - 1] = 0;
            }
            if (f2[9] != 0)
            {
                f1[f2[9] - 1] = 0;
                f3[f2[9] - 1] = 0;
                f4[f2[9] - 1] = 0;
                f5[f2[9] - 1] = 0;
                f6[f2[9] - 1] = 0;
                f7[f2[9] - 1] = 0;
                f8[f2[9] - 1] = 0;
                f9[f2[9] - 1] = 0;
            }
            if (f3[9] != 0)
            {
                f1[f3[9] - 1] = 0;
                f2[f3[9] - 1] = 0;
                f4[f3[9] - 1] = 0;
                f5[f3[9] - 1] = 0;
                f6[f3[9] - 1] = 0;
                f7[f3[9] - 1] = 0;
                f8[f3[9] - 1] = 0;
                f9[f3[9] - 1] = 0;
            }
            if (f4[9] != 0)
            {
                f1[f4[9] - 1] = 0;
                f2[f4[9] - 1] = 0;
                f3[f4[9] - 1] = 0;
                f5[f4[9] - 1] = 0;
                f6[f4[9] - 1] = 0;
                f7[f4[9] - 1] = 0;
                f8[f4[9] - 1] = 0;
                f9[f4[9] - 1] = 0;
            }
            if (f5[9] != 0)
            {
                f1[f5[9] - 1] = 0;
                f2[f5[9] - 1] = 0;
                f3[f5[9] - 1] = 0;
                f4[f5[9] - 1] = 0;
                f6[f5[9] - 1] = 0;
                f7[f5[9] - 1] = 0;
                f8[f5[9] - 1] = 0;
                f9[f5[9] - 1] = 0;
            }
            if (f6[9] != 0)
            {
                f1[f6[9] - 1] = 0;
                f2[f6[9] - 1] = 0;
                f3[f6[9] - 1] = 0;
                f4[f6[9] - 1] = 0;
                f5[f6[9] - 1] = 0;
                f7[f6[9] - 1] = 0;
                f8[f6[9] - 1] = 0;
                f9[f6[9] - 1] = 0;
            }
            if (f7[9] != 0)
            {
                f1[f7[9] - 1] = 0;
                f2[f7[9] - 1] = 0;
                f3[f7[9] - 1] = 0;
                f4[f7[9] - 1] = 0;
                f5[f7[9] - 1] = 0;
                f6[f7[9] - 1] = 0;
                f8[f7[9] - 1] = 0;
                f9[f7[9] - 1] = 0;
            }
            if (f8[9] != 0)
            {
                f1[f8[9] - 1] = 0;
                f2[f8[9] - 1] = 0;
                f3[f8[9] - 1] = 0;
                f4[f8[9] - 1] = 0;
                f5[f8[9] - 1] = 0;
                f6[f8[9] - 1] = 0;
                f7[f8[9] - 1] = 0;
                f9[f8[9] - 1] = 0;
            }
            if (f9[9] != 0)
            {
                f1[f9[9] - 1] = 0;
                f2[f9[9] - 1] = 0;
                f3[f9[9] - 1] = 0;
                f4[f9[9] - 1] = 0;
                f5[f9[9] - 1] = 0;
                f6[f9[9] - 1] = 0;
                f7[f9[9] - 1] = 0;
                f8[f9[9] - 1] = 0;
            }
            //f end
            if (g1[9] != 0)
            {
                g2[g1[9] - 1] = 0;
                g3[g1[9] - 1] = 0;
                g4[g1[9] - 1] = 0;
                g5[g1[9] - 1] = 0;
                g6[g1[9] - 1] = 0;
                g7[g1[9] - 1] = 0;
                g8[g1[9] - 1] = 0;
                g9[g1[9] - 1] = 0;
            }
            if (g2[9] != 0)
            {
                g1[g2[9] - 1] = 0;
                g3[g2[9] - 1] = 0;
                g4[g2[9] - 1] = 0;
                g5[g2[9] - 1] = 0;
                g6[g2[9] - 1] = 0;
                g7[g2[9] - 1] = 0;
                g8[g2[9] - 1] = 0;
                g9[g2[9] - 1] = 0;
            }
            if (g3[9] != 0)
            {
                g1[g3[9] - 1] = 0;
                g2[g3[9] - 1] = 0;
                g4[g3[9] - 1] = 0;
                g5[g3[9] - 1] = 0;
                g6[g3[9] - 1] = 0;
                g7[g3[9] - 1] = 0;
                g8[g3[9] - 1] = 0;
                g9[g3[9] - 1] = 0;
            }
            if (g4[9] != 0)
            {
                g1[g4[9] - 1] = 0;
                g2[g4[9] - 1] = 0;
                g3[g4[9] - 1] = 0;
                g5[g4[9] - 1] = 0;
                g6[g4[9] - 1] = 0;
                g7[g4[9] - 1] = 0;
                g8[g4[9] - 1] = 0;
                g9[g4[9] - 1] = 0;
            }
            if (g5[9] != 0)
            {
                g1[g5[9] - 1] = 0;
                g2[g5[9] - 1] = 0;
                g3[g5[9] - 1] = 0;
                g4[g5[9] - 1] = 0;
                g6[g5[9] - 1] = 0;
                g7[g5[9] - 1] = 0;
                g8[g5[9] - 1] = 0;
                g9[g5[9] - 1] = 0;
            }
            if (g6[9] != 0)
            {
                g1[g6[9] - 1] = 0;
                g2[g6[9] - 1] = 0;
                g3[g6[9] - 1] = 0;
                g4[g6[9] - 1] = 0;
                g5[g6[9] - 1] = 0;
                g7[g6[9] - 1] = 0;
                g8[g6[9] - 1] = 0;
                g9[g6[9] - 1] = 0;
            }
            if (g7[9] != 0)
            {
                g1[g7[9] - 1] = 0;
                g2[g7[9] - 1] = 0;
                g3[g7[9] - 1] = 0;
                g4[g7[9] - 1] = 0;
                g5[g7[9] - 1] = 0;
                g6[g7[9] - 1] = 0;
                g8[g7[9] - 1] = 0;
                g9[g7[9] - 1] = 0;
            }
            if (g8[9] != 0)
            {
                g1[g8[9] - 1] = 0;
                g2[g8[9] - 1] = 0;
                g3[g8[9] - 1] = 0;
                g4[g8[9] - 1] = 0;
                g5[g8[9] - 1] = 0;
                g6[g8[9] - 1] = 0;
                g7[g8[9] - 1] = 0;
                g9[g8[9] - 1] = 0;
            }
            if (g9[9] != 0)
            {
                g1[g9[9] - 1] = 0;
                g2[g9[9] - 1] = 0;
                g3[g9[9] - 1] = 0;
                g4[g9[9] - 1] = 0;
                g5[g9[9] - 1] = 0;
                g6[g9[9] - 1] = 0;
                g7[g9[9] - 1] = 0;
                g8[g9[9] - 1] = 0;
            }
            //g end

            if (h1[9] != 0)
            {
                h2[h1[9] - 1] = 0;
                h3[h1[9] - 1] = 0;
                h4[h1[9] - 1] = 0;
                h5[h1[9] - 1] = 0;
                h6[h1[9] - 1] = 0;
                h7[h1[9] - 1] = 0;
                h8[h1[9] - 1] = 0;
                h9[h1[9] - 1] = 0;
            }
            if (h2[9] != 0)
            {
                h1[h2[9] - 1] = 0;
                h3[h2[9] - 1] = 0;
                h4[h2[9] - 1] = 0;
                h5[h2[9] - 1] = 0;
                h6[h2[9] - 1] = 0;
                h7[h2[9] - 1] = 0;
                h8[h2[9] - 1] = 0;
                h9[h2[9] - 1] = 0;
            }
            if (h3[9] != 0)
            {
                h1[h3[9] - 1] = 0;
                h2[h3[9] - 1] = 0;
                h4[h3[9] - 1] = 0;
                h5[h3[9] - 1] = 0;
                h6[h3[9] - 1] = 0;
                h7[h3[9] - 1] = 0;
                h8[h3[9] - 1] = 0;
                h9[h3[9] - 1] = 0;
            }
            if (h4[9] != 0)
            {
                h1[h4[9] - 1] = 0;
                h2[h4[9] - 1] = 0;
                h3[h4[9] - 1] = 0;
                h5[h4[9] - 1] = 0;
                h6[h4[9] - 1] = 0;
                h7[h4[9] - 1] = 0;
                h8[h4[9] - 1] = 0;
                h9[h4[9] - 1] = 0;
            }
            if (h5[9] != 0)
            {
                h1[h5[9] - 1] = 0;
                h2[h5[9] - 1] = 0;
                h3[h5[9] - 1] = 0;
                h4[h5[9] - 1] = 0;
                h6[h5[9] - 1] = 0;
                h7[h5[9] - 1] = 0;
                h8[h5[9] - 1] = 0;
                h9[h5[9] - 1] = 0;
            }
            if (h6[9] != 0)
            {
                h1[h6[9] - 1] = 0;
                h2[h6[9] - 1] = 0;
                h3[h6[9] - 1] = 0;
                h4[h6[9] - 1] = 0;
                h5[h6[9] - 1] = 0;
                h7[h6[9] - 1] = 0;
                h8[h6[9] - 1] = 0;
                h9[h6[9] - 1] = 0;
            }
            if (h7[9] != 0)
            {
                h1[h7[9] - 1] = 0;
                h2[h7[9] - 1] = 0;
                h3[h7[9] - 1] = 0;
                h4[h7[9] - 1] = 0;
                h5[h7[9] - 1] = 0;
                h6[h7[9] - 1] = 0;
                h8[h7[9] - 1] = 0;
                h9[h7[9] - 1] = 0;
            }
            if (h8[9] != 0)
            {
                h1[h8[9] - 1] = 0;
                h2[h8[9] - 1] = 0;
                h3[h8[9] - 1] = 0;
                h4[h8[9] - 1] = 0;
                h5[h8[9] - 1] = 0;
                h6[h8[9] - 1] = 0;
                h7[h8[9] - 1] = 0;
                h9[h8[9] - 1] = 0;
            }
            if (h9[9] != 0)
            {
                h1[h9[9] - 1] = 0;
                h2[h9[9] - 1] = 0;
                h3[h9[9] - 1] = 0;
                h4[h9[9] - 1] = 0;
                h5[h9[9] - 1] = 0;
                h6[h9[9] - 1] = 0;
                h7[h9[9] - 1] = 0;
                h8[h9[9] - 1] = 0;
            }
            //h end

            if (i1[9] != 0)
            {
                i2[i1[9] - 1] = 0;
                i3[i1[9] - 1] = 0;
                i4[i1[9] - 1] = 0;
                i5[i1[9] - 1] = 0;
                i6[i1[9] - 1] = 0;
                i7[i1[9] - 1] = 0;
                i8[i1[9] - 1] = 0;
                i9[i1[9] - 1] = 0;
            }
            if (i2[9] != 0)
            {
                i1[i2[9] - 1] = 0;
                i3[i2[9] - 1] = 0;
                i4[i2[9] - 1] = 0;
                i5[i2[9] - 1] = 0;
                i6[i2[9] - 1] = 0;
                i7[i2[9] - 1] = 0;
                i8[i2[9] - 1] = 0;
                i9[i2[9] - 1] = 0;
            }
            if (i3[9] != 0)
            {
                i1[i3[9] - 1] = 0;
                i2[i3[9] - 1] = 0;
                i4[i3[9] - 1] = 0;
                i5[i3[9] - 1] = 0;
                i6[i3[9] - 1] = 0;
                i7[i3[9] - 1] = 0;
                i8[i3[9] - 1] = 0;
                i9[i3[9] - 1] = 0;
            }
            if (i4[9] != 0)
            {
                i1[i4[9] - 1] = 0;
                i2[i4[9] - 1] = 0;
                i3[i4[9] - 1] = 0;
                i5[i4[9] - 1] = 0;
                i6[i4[9] - 1] = 0;
                i7[i4[9] - 1] = 0;
                i8[i4[9] - 1] = 0;
                i9[i4[9] - 1] = 0;
            }
            if (i5[9] != 0)
            {
                i1[i5[9] - 1] = 0;
                i2[i5[9] - 1] = 0;
                i3[i5[9] - 1] = 0;
                i4[i5[9] - 1] = 0;
                i6[i5[9] - 1] = 0;
                i7[i5[9] - 1] = 0;
                i8[i5[9] - 1] = 0;
                i9[i5[9] - 1] = 0;
            }
            if (i6[9] != 0)
            {
                i1[i6[9] - 1] = 0;
                i2[i6[9] - 1] = 0;
                i3[i6[9] - 1] = 0;
                i4[i6[9] - 1] = 0;
                i5[i6[9] - 1] = 0;
                i7[i6[9] - 1] = 0;
                i8[i6[9] - 1] = 0;
                i9[i6[9] - 1] = 0;
            }
            if (i7[9] != 0)
            {
                i1[i7[9] - 1] = 0;
                i2[i7[9] - 1] = 0;
                i3[i7[9] - 1] = 0;
                i4[i7[9] - 1] = 0;
                i5[i7[9] - 1] = 0;
                i6[i7[9] - 1] = 0;
                i8[i7[9] - 1] = 0;
                i9[i7[9] - 1] = 0;
            }
            if (i8[9] != 0)
            {
                i1[i8[9] - 1] = 0;
                i2[i8[9] - 1] = 0;
                i3[i8[9] - 1] = 0;
                i4[i8[9] - 1] = 0;
                i5[i8[9] - 1] = 0;
                i6[i8[9] - 1] = 0;
                i7[i8[9] - 1] = 0;
                i9[i8[9] - 1] = 0;
            }
            if (i9[9] != 0)
            {
                i1[i9[9] - 1] = 0;
                i2[i9[9] - 1] = 0;
                i3[i9[9] - 1] = 0;
                i4[i9[9] - 1] = 0;
                i5[i9[9] - 1] = 0;
                i6[i9[9] - 1] = 0;
                i7[i9[9] - 1] = 0;
                i8[i9[9] - 1] = 0;
            }
            //i end
        }

        public void Check_Horizontal()
        {

            if (a1[9] != 0)
            {
                b1[a1[9] - 1] = 0;
                c1[a1[9] - 1] = 0;
                d1[a1[9] - 1] = 0;
                e1[a1[9] - 1] = 0;
                f1[a1[9] - 1] = 0;
                g1[a1[9] - 1] = 0;
                h1[a1[9] - 1] = 0;
                i1[a1[9] - 1] = 0;
            }
            if (b1[9] != 0)
            {
                a1[b1[9] - 1] = 0;
                c1[b1[9] - 1] = 0;
                d1[b1[9] - 1] = 0;
                e1[b1[9] - 1] = 0;
                f1[b1[9] - 1] = 0;
                g1[b1[9] - 1] = 0;
                h1[b1[9] - 1] = 0;
                i1[b1[9] - 1] = 0;
            }
            if (c1[9] != 0)
            {
                a1[c1[9] - 1] = 0;
                b1[c1[9] - 1] = 0;
                d1[c1[9] - 1] = 0;
                e1[c1[9] - 1] = 0;
                f1[c1[9] - 1] = 0;
                g1[c1[9] - 1] = 0;
                h1[c1[9] - 1] = 0;
                i1[c1[9] - 1] = 0;
            }
            if (d1[9] != 0)
            {
                a1[d1[9] - 1] = 0;
                b1[d1[9] - 1] = 0;
                c1[d1[9] - 1] = 0;
                e1[d1[9] - 1] = 0;
                f1[d1[9] - 1] = 0;
                g1[d1[9] - 1] = 0;
                h1[d1[9] - 1] = 0;
                i1[d1[9] - 1] = 0;
            }
            if (e1[9] != 0)
            {
                a1[e1[9] - 1] = 0;
                b1[e1[9] - 1] = 0;
                c1[e1[9] - 1] = 0;
                d1[e1[9] - 1] = 0;
                f1[e1[9] - 1] = 0;
                g1[e1[9] - 1] = 0;
                h1[e1[9] - 1] = 0;
                i1[e1[9] - 1] = 0;
            }
            if (f1[9] != 0)
            {
                a1[f1[9] - 1] = 0;
                b1[f1[9] - 1] = 0;
                c1[f1[9] - 1] = 0;
                d1[f1[9] - 1] = 0;
                e1[f1[9] - 1] = 0;
                g1[f1[9] - 1] = 0;
                h1[f1[9] - 1] = 0;
                i1[f1[9] - 1] = 0;
            }
            if (g1[9] != 0)
            {
                a1[g1[9] - 1] = 0;
                b1[g1[9] - 1] = 0;
                c1[g1[9] - 1] = 0;
                d1[g1[9] - 1] = 0;
                e1[g1[9] - 1] = 0;
                f1[g1[9] - 1] = 0;
                h1[g1[9] - 1] = 0;
                i1[g1[9] - 1] = 0;
            }
            if (h1[9] != 0)
            {
                a1[h1[9] - 1] = 0;
                b1[h1[9] - 1] = 0;
                c1[h1[9] - 1] = 0;
                d1[h1[9] - 1] = 0;
                e1[h1[9] - 1] = 0;
                f1[h1[9] - 1] = 0;
                g1[h1[9] - 1] = 0;
                i1[h1[9] - 1] = 0;
            }

            if (i1[9] != 0)
            {
                a1[i1[9] - 1] = 0;
                b1[i1[9] - 1] = 0;
                c1[i1[9] - 1] = 0;
                d1[i1[9] - 1] = 0;
                e1[i1[9] - 1] = 0;
                f1[i1[9] - 1] = 0;
                g1[i1[9] - 1] = 0;
                h1[i1[9] - 1] = 0;
            }
            //Line 1 End
            if (a2[9] != 0)
            {
                b2[a2[9] - 1] = 0;
                c2[a2[9] - 1] = 0;
                d2[a2[9] - 1] = 0;
                e2[a2[9] - 1] = 0;
                f2[a2[9] - 1] = 0;
                g2[a2[9] - 1] = 0;
                h2[a2[9] - 1] = 0;
                i2[a2[9] - 1] = 0;
            }
            if (b2[9] != 0)
            {
                a2[b2[9] - 1] = 0;
                c2[b2[9] - 1] = 0;
                d2[b2[9] - 1] = 0;
                e2[b2[9] - 1] = 0;
                f2[b2[9] - 1] = 0;
                g2[b2[9] - 1] = 0;
                h2[b2[9] - 1] = 0;
                i2[b2[9] - 1] = 0;
            }
            if (c2[9] != 0)
            {
                a2[c2[9] - 1] = 0;
                b2[c2[9] - 1] = 0;
                d2[c2[9] - 1] = 0;
                e2[c2[9] - 1] = 0;
                f2[c2[9] - 1] = 0;
                g2[c2[9] - 1] = 0;
                h2[c2[9] - 1] = 0;
                i2[c2[9] - 1] = 0;
            }
            if (d2[9] != 0)
            {
                a2[d2[9] - 1] = 0;
                b2[d2[9] - 1] = 0;
                c2[d2[9] - 1] = 0;
                e2[d2[9] - 1] = 0;
                f2[d2[9] - 1] = 0;
                g2[d2[9] - 1] = 0;
                h2[d2[9] - 1] = 0;
                i2[d2[9] - 1] = 0;
            }
            if (e2[9] != 0)
            {
                a2[e2[9] - 1] = 0;
                b2[e2[9] - 1] = 0;
                c2[e2[9] - 1] = 0;
                d2[e2[9] - 1] = 0;
                f2[e2[9] - 1] = 0;
                g2[e2[9] - 1] = 0;
                h2[e2[9] - 1] = 0;
                i2[e2[9] - 1] = 0;
            }
            if (f2[9] != 0)
            {
                a2[f2[9] - 1] = 0;
                b2[f2[9] - 1] = 0;
                c2[f2[9] - 1] = 0;
                d2[f2[9] - 1] = 0;
                e2[f2[9] - 1] = 0;
                g2[f2[9] - 1] = 0;
                h2[f2[9] - 1] = 0;
                i2[f2[9] - 1] = 0;
            }
            if (g2[9] != 0)
            {
                a2[g2[9] - 1] = 0;
                b2[g2[9] - 1] = 0;
                c2[g2[9] - 1] = 0;
                d2[g2[9] - 1] = 0;
                e2[g2[9] - 1] = 0;
                f2[g2[9] - 1] = 0;
                h2[g2[9] - 1] = 0;
                i2[g2[9] - 1] = 0;
            }
            if (h2[9] != 0)
            {
                a2[h2[9] - 1] = 0;
                b2[h2[9] - 1] = 0;
                c2[h2[9] - 1] = 0;
                d2[h2[9] - 1] = 0;
                e2[h2[9] - 1] = 0;
                f2[h2[9] - 1] = 0;
                g2[h2[9] - 1] = 0;
                i2[h2[9] - 1] = 0;
            }

            if (i2[9] != 0)
            {
                a2[i2[9] - 1] = 0;
                b2[i2[9] - 1] = 0;
                c2[i2[9] - 1] = 0;
                d2[i2[9] - 1] = 0;
                e2[i2[9] - 1] = 0;
                f2[i2[9] - 1] = 0;
                g2[i2[9] - 1] = 0;
                h2[i2[9] - 1] = 0;
            }
            //Line 2 End
            if (a3[9] != 0)
            {
                b3[a3[9] - 1] = 0;
                c3[a3[9] - 1] = 0;
                d3[a3[9] - 1] = 0;
                e3[a3[9] - 1] = 0;
                f3[a3[9] - 1] = 0;
                g3[a3[9] - 1] = 0;
                h3[a3[9] - 1] = 0;
                i3[a3[9] - 1] = 0;
            }
            if (b3[9] != 0)
            {
                a3[b3[9] - 1] = 0;
                c3[b3[9] - 1] = 0;
                d3[b3[9] - 1] = 0;
                e3[b3[9] - 1] = 0;
                f3[b3[9] - 1] = 0;
                g3[b3[9] - 1] = 0;
                h3[b3[9] - 1] = 0;
                i3[b3[9] - 1] = 0;
            }
            if (c3[9] != 0)
            {
                a3[c3[9] - 1] = 0;
                b3[c3[9] - 1] = 0;
                d3[c3[9] - 1] = 0;
                e3[c3[9] - 1] = 0;
                f3[c3[9] - 1] = 0;
                g3[c3[9] - 1] = 0;
                h3[c3[9] - 1] = 0;
                i3[c3[9] - 1] = 0;
            }
            if (d3[9] != 0)
            {
                a3[d3[9] - 1] = 0;
                b3[d3[9] - 1] = 0;
                c3[d3[9] - 1] = 0;
                e3[d3[9] - 1] = 0;
                f3[d3[9] - 1] = 0;
                g3[d3[9] - 1] = 0;
                h3[d3[9] - 1] = 0;
                i3[d3[9] - 1] = 0;
            }
            if (e3[9] != 0)
            {
                a3[e3[9] - 1] = 0;
                b3[e3[9] - 1] = 0;
                c3[e3[9] - 1] = 0;
                d3[e3[9] - 1] = 0;
                f3[e3[9] - 1] = 0;
                g3[e3[9] - 1] = 0;
                h3[e3[9] - 1] = 0;
                i3[e3[9] - 1] = 0;
            }
            if (f3[9] != 0)
            {
                a3[f3[9] - 1] = 0;
                b3[f3[9] - 1] = 0;
                c3[f3[9] - 1] = 0;
                d3[f3[9] - 1] = 0;
                e3[f3[9] - 1] = 0;
                g3[f3[9] - 1] = 0;
                h3[f3[9] - 1] = 0;
                i3[f3[9] - 1] = 0;
            }
            if (g3[9] != 0)
            {
                a3[g3[9] - 1] = 0;
                b3[g3[9] - 1] = 0;
                c3[g3[9] - 1] = 0;
                d3[g3[9] - 1] = 0;
                e3[g3[9] - 1] = 0;
                f3[g3[9] - 1] = 0;
                h3[g3[9] - 1] = 0;
                i3[g3[9] - 1] = 0;
            }
            if (h3[9] != 0)
            {
                a3[h3[9] - 1] = 0;
                b3[h3[9] - 1] = 0;
                c3[h3[9] - 1] = 0;
                d3[h3[9] - 1] = 0;
                e3[h3[9] - 1] = 0;
                f3[h3[9] - 1] = 0;
                g3[h3[9] - 1] = 0;
                i3[h3[9] - 1] = 0;
            }

            if (i3[9] != 0)
            {
                a3[i3[9] - 1] = 0;
                b3[i3[9] - 1] = 0;
                c3[i3[9] - 1] = 0;
                d3[i3[9] - 1] = 0;
                e3[i3[9] - 1] = 0;
                f3[i3[9] - 1] = 0;
                g3[i3[9] - 1] = 0;
                h3[i3[9] - 1] = 0;
            }
            //Line 3 End
            if (a4[9] != 0)
            {
                b4[a4[9] - 1] = 0;
                c4[a4[9] - 1] = 0;
                d4[a4[9] - 1] = 0;
                e4[a4[9] - 1] = 0;
                f4[a4[9] - 1] = 0;
                g4[a4[9] - 1] = 0;
                h4[a4[9] - 1] = 0;
                i4[a4[9] - 1] = 0;
            }
            if (b4[9] != 0)
            {
                a4[b4[9] - 1] = 0;
                c4[b4[9] - 1] = 0;
                d4[b4[9] - 1] = 0;
                e4[b4[9] - 1] = 0;
                f4[b4[9] - 1] = 0;
                g4[b4[9] - 1] = 0;
                h4[b4[9] - 1] = 0;
                i4[b4[9] - 1] = 0;
            }
            if (c4[9] != 0)
            {
                a4[c4[9] - 1] = 0;
                b4[c4[9] - 1] = 0;
                d4[c4[9] - 1] = 0;
                e4[c4[9] - 1] = 0;
                f4[c4[9] - 1] = 0;
                g4[c4[9] - 1] = 0;
                h4[c4[9] - 1] = 0;
                i4[c4[9] - 1] = 0;
            }
            if (d4[9] != 0)
            {
                a4[d4[9] - 1] = 0;
                b4[d4[9] - 1] = 0;
                c4[d4[9] - 1] = 0;
                e4[d4[9] - 1] = 0;
                f4[d4[9] - 1] = 0;
                g4[d4[9] - 1] = 0;
                h4[d4[9] - 1] = 0;
                i4[d4[9] - 1] = 0;
            }
            if (e4[9] != 0)
            {
                a4[e4[9] - 1] = 0;
                b4[e4[9] - 1] = 0;
                c4[e4[9] - 1] = 0;
                d4[e4[9] - 1] = 0;
                f4[e4[9] - 1] = 0;
                g4[e4[9] - 1] = 0;
                h4[e4[9] - 1] = 0;
                i4[e4[9] - 1] = 0;
            }
            if (f4[9] != 0)
            {
                a4[f4[9] - 1] = 0;
                b4[f4[9] - 1] = 0;
                c4[f4[9] - 1] = 0;
                d4[f4[9] - 1] = 0;
                e4[f4[9] - 1] = 0;
                g4[f4[9] - 1] = 0;
                h4[f4[9] - 1] = 0;
                i4[f4[9] - 1] = 0;
            }
            if (g4[9] != 0)
            {
                a4[g4[9] - 1] = 0;
                b4[g4[9] - 1] = 0;
                c4[g4[9] - 1] = 0;
                d4[g4[9] - 1] = 0;
                e4[g4[9] - 1] = 0;
                f4[g4[9] - 1] = 0;
                h4[g4[9] - 1] = 0;
                i4[g4[9] - 1] = 0;
            }
            if (h4[9] != 0)
            {
                a4[h4[9] - 1] = 0;
                b4[h4[9] - 1] = 0;
                c4[h4[9] - 1] = 0;
                d4[h4[9] - 1] = 0;
                e4[h4[9] - 1] = 0;
                f4[h4[9] - 1] = 0;
                g4[h4[9] - 1] = 0;
                i4[h4[9] - 1] = 0;
            }

            if (i4[9] != 0)
            {
                a4[i4[9] - 1] = 0;
                b4[i4[9] - 1] = 0;
                c4[i4[9] - 1] = 0;
                d4[i4[9] - 1] = 0;
                e4[i4[9] - 1] = 0;
                f4[i4[9] - 1] = 0;
                g4[i4[9] - 1] = 0;
                h4[i4[9] - 1] = 0;
            }

            //Line 4 end

            if (a5[9] != 0)
            {
                b5[a5[9] - 1] = 0;
                c5[a5[9] - 1] = 0;
                d5[a5[9] - 1] = 0;
                e5[a5[9] - 1] = 0;
                f5[a5[9] - 1] = 0;
                g5[a5[9] - 1] = 0;
                h5[a5[9] - 1] = 0;
                i5[a5[9] - 1] = 0;
            }
            if (b5[9] != 0)
            {
                a5[b5[9] - 1] = 0;
                c5[b5[9] - 1] = 0;
                d5[b5[9] - 1] = 0;
                e5[b5[9] - 1] = 0;
                f5[b5[9] - 1] = 0;
                g5[b5[9] - 1] = 0;
                h5[b5[9] - 1] = 0;
                i5[b5[9] - 1] = 0;
            }
            if (c5[9] != 0)
            {
                a5[c5[9] - 1] = 0;
                b5[c5[9] - 1] = 0;
                d5[c5[9] - 1] = 0;
                e5[c5[9] - 1] = 0;
                f5[c5[9] - 1] = 0;
                g5[c5[9] - 1] = 0;
                h5[c5[9] - 1] = 0;
                i5[c5[9] - 1] = 0;
            }
            if (d5[9] != 0)
            {
                a5[d5[9] - 1] = 0;
                b5[d5[9] - 1] = 0;
                c5[d5[9] - 1] = 0;
                e5[d5[9] - 1] = 0;
                f5[d5[9] - 1] = 0;
                g5[d5[9] - 1] = 0;
                h5[d5[9] - 1] = 0;
                i5[d5[9] - 1] = 0;
            }
            if (e5[9] != 0)
            {
                a5[e5[9] - 1] = 0;
                b5[e5[9] - 1] = 0;
                c5[e5[9] - 1] = 0;
                d5[e5[9] - 1] = 0;
                f5[e5[9] - 1] = 0;
                g5[e5[9] - 1] = 0;
                h5[e5[9] - 1] = 0;
                i5[e5[9] - 1] = 0;
            }
            if (f5[9] != 0)
            {
                a5[f5[9] - 1] = 0;
                b5[f5[9] - 1] = 0;
                c5[f5[9] - 1] = 0;
                d5[f5[9] - 1] = 0;
                e5[f5[9] - 1] = 0;
                g5[f5[9] - 1] = 0;
                h5[f5[9] - 1] = 0;
                i5[f5[9] - 1] = 0;
            }
            if (g5[9] != 0)
            {
                a5[g5[9] - 1] = 0;
                b5[g5[9] - 1] = 0;
                c5[g5[9] - 1] = 0;
                d5[g5[9] - 1] = 0;
                e5[g5[9] - 1] = 0;
                f5[g5[9] - 1] = 0;
                h5[g5[9] - 1] = 0;
                i5[g5[9] - 1] = 0;
            }
            if (h5[9] != 0)
            {
                a5[h5[9] - 1] = 0;
                b5[h5[9] - 1] = 0;
                c5[h5[9] - 1] = 0;
                d5[h5[9] - 1] = 0;
                e5[h5[9] - 1] = 0;
                f5[h5[9] - 1] = 0;
                g5[h5[9] - 1] = 0;
                i5[h5[9] - 1] = 0;
            }

            if (i5[9] != 0)
            {
                a5[i5[9] - 1] = 0;
                b5[i5[9] - 1] = 0;
                c5[i5[9] - 1] = 0;
                d5[i5[9] - 1] = 0;
                e5[i5[9] - 1] = 0;
                f5[i5[9] - 1] = 0;
                g5[i5[9] - 1] = 0;
                h5[i5[9] - 1] = 0;
            }
            //Line 5 End
            if (a6[9] != 0)
            {
                b6[a6[9] - 1] = 0;
                c6[a6[9] - 1] = 0;
                d6[a6[9] - 1] = 0;
                e6[a6[9] - 1] = 0;
                f6[a6[9] - 1] = 0;
                g6[a6[9] - 1] = 0;
                h6[a6[9] - 1] = 0;
                i6[a6[9] - 1] = 0;
            }
            if (b6[9] != 0)
            {
                a6[b6[9] - 1] = 0;
                c6[b6[9] - 1] = 0;
                d6[b6[9] - 1] = 0;
                e6[b6[9] - 1] = 0;
                f6[b6[9] - 1] = 0;
                g6[b6[9] - 1] = 0;
                h6[b6[9] - 1] = 0;
                i6[b6[9] - 1] = 0;
            }
            if (c6[9] != 0)
            {
                a6[c6[9] - 1] = 0;
                b6[c6[9] - 1] = 0;
                d6[c6[9] - 1] = 0;
                e6[c6[9] - 1] = 0;
                f6[c6[9] - 1] = 0;
                g6[c6[9] - 1] = 0;
                h6[c6[9] - 1] = 0;
                i6[c6[9] - 1] = 0;
            }
            if (d6[9] != 0)
            {
                a6[d6[9] - 1] = 0;
                b6[d6[9] - 1] = 0;
                c6[d6[9] - 1] = 0;
                e6[d6[9] - 1] = 0;
                f6[d6[9] - 1] = 0;
                g6[d6[9] - 1] = 0;
                h6[d6[9] - 1] = 0;
                i6[d6[9] - 1] = 0;
            }
            if (e6[9] != 0)
            {
                a6[e6[9] - 1] = 0;
                b6[e6[9] - 1] = 0;
                c6[e6[9] - 1] = 0;
                d6[e6[9] - 1] = 0;
                f6[e6[9] - 1] = 0;
                g6[e6[9] - 1] = 0;
                h6[e6[9] - 1] = 0;
                i6[e6[9] - 1] = 0;
            }
            if (f6[9] != 0)
            {
                a6[f6[9] - 1] = 0;
                b6[f6[9] - 1] = 0;
                c6[f6[9] - 1] = 0;
                d6[f6[9] - 1] = 0;
                e6[f6[9] - 1] = 0;
                g6[f6[9] - 1] = 0;
                h6[f6[9] - 1] = 0;
                i6[f6[9] - 1] = 0;
            }
            if (g6[9] != 0)
            {
                a6[g6[9] - 1] = 0;
                b6[g6[9] - 1] = 0;
                c6[g6[9] - 1] = 0;
                d6[g6[9] - 1] = 0;
                e6[g6[9] - 1] = 0;
                f6[g6[9] - 1] = 0;
                h6[g6[9] - 1] = 0;
                i6[g6[9] - 1] = 0;
            }
            if (h6[9] != 0)
            {
                a6[h6[9] - 1] = 0;
                b6[h6[9] - 1] = 0;
                c6[h6[9] - 1] = 0;
                d6[h6[9] - 1] = 0;
                e6[h6[9] - 1] = 0;
                f6[h6[9] - 1] = 0;
                g6[h6[9] - 1] = 0;
                i6[h6[9] - 1] = 0;
            }

            if (i6[9] != 0)
            {
                a6[i6[9] - 1] = 0;
                b6[i6[9] - 1] = 0;
                c6[i6[9] - 1] = 0;
                d6[i6[9] - 1] = 0;
                e6[i6[9] - 1] = 0;
                f6[i6[9] - 1] = 0;
                g6[i6[9] - 1] = 0;
                h6[i6[9] - 1] = 0;
            }
            //Line 6 end
            if (a7[9] != 0)
            {
                b7[a7[9] - 1] = 0;
                c7[a7[9] - 1] = 0;
                d7[a7[9] - 1] = 0;
                e7[a7[9] - 1] = 0;
                f7[a7[9] - 1] = 0;
                g7[a7[9] - 1] = 0;
                h7[a7[9] - 1] = 0;
                i7[a7[9] - 1] = 0;
            }
            if (b7[9] != 0)
            {
                a7[b7[9] - 1] = 0;
                c7[b7[9] - 1] = 0;
                d7[b7[9] - 1] = 0;
                e7[b7[9] - 1] = 0;
                f7[b7[9] - 1] = 0;
                g7[b7[9] - 1] = 0;
                h7[b7[9] - 1] = 0;
                i7[b7[9] - 1] = 0;
            }
            if (c7[9] != 0)
            {
                a7[c7[9] - 1] = 0;
                b7[c7[9] - 1] = 0;
                d7[c7[9] - 1] = 0;
                e7[c7[9] - 1] = 0;
                f7[c7[9] - 1] = 0;
                g7[c7[9] - 1] = 0;
                h7[c7[9] - 1] = 0;
                i7[c7[9] - 1] = 0;
            }
            if (d7[9] != 0)
            {
                a7[d7[9] - 1] = 0;
                b7[d7[9] - 1] = 0;
                c7[d7[9] - 1] = 0;
                e7[d7[9] - 1] = 0;
                f7[d7[9] - 1] = 0;
                g7[d7[9] - 1] = 0;
                h7[d7[9] - 1] = 0;
                i7[d7[9] - 1] = 0;
            }
            if (e7[9] != 0)
            {
                a7[e7[9] - 1] = 0;
                b7[e7[9] - 1] = 0;
                c7[e7[9] - 1] = 0;
                d7[e7[9] - 1] = 0;
                f7[e7[9] - 1] = 0;
                g7[e7[9] - 1] = 0;
                h7[e7[9] - 1] = 0;
                i7[e7[9] - 1] = 0;
            }
            if (f7[9] != 0)
            {
                a7[f7[9] - 1] = 0;
                b7[f7[9] - 1] = 0;
                c7[f7[9] - 1] = 0;
                d7[f7[9] - 1] = 0;
                e7[f7[9] - 1] = 0;
                g7[f7[9] - 1] = 0;
                h7[f7[9] - 1] = 0;
                i7[f7[9] - 1] = 0;
            }
            if (g7[9] != 0)
            {
                a7[g7[9] - 1] = 0;
                b7[g7[9] - 1] = 0;
                c7[g7[9] - 1] = 0;
                d7[g7[9] - 1] = 0;
                e7[g7[9] - 1] = 0;
                f7[g7[9] - 1] = 0;
                h7[g7[9] - 1] = 0;
                i7[g7[9] - 1] = 0;
            }
            if (h7[9] != 0)
            {
                a7[h7[9] - 1] = 0;
                b7[h7[9] - 1] = 0;
                c7[h7[9] - 1] = 0;
                d7[h7[9] - 1] = 0;
                e7[h7[9] - 1] = 0;
                f7[h7[9] - 1] = 0;
                g7[h7[9] - 1] = 0;
                i7[h7[9] - 1] = 0;
            }

            if (i7[9] != 0)
            {
                a7[i7[9] - 1] = 0;
                b7[i7[9] - 1] = 0;
                c7[i7[9] - 1] = 0;
                d7[i7[9] - 1] = 0;
                e7[i7[9] - 1] = 0;
                f7[i7[9] - 1] = 0;
                g7[i7[9] - 1] = 0;
                h7[i7[9] - 1] = 0;
            }
            //Line 7 end
            if (a8[9] != 0)
            {
                b8[a8[9] - 1] = 0;
                c8[a8[9] - 1] = 0;
                d8[a8[9] - 1] = 0;
                e8[a8[9] - 1] = 0;
                f8[a8[9] - 1] = 0;
                g8[a8[9] - 1] = 0;
                h8[a8[9] - 1] = 0;
                i8[a8[9] - 1] = 0;
            }
            if (b8[9] != 0)
            {
                a8[b8[9] - 1] = 0;
                c8[b8[9] - 1] = 0;
                d8[b8[9] - 1] = 0;
                e8[b8[9] - 1] = 0;
                f8[b8[9] - 1] = 0;
                g8[b8[9] - 1] = 0;
                h8[b8[9] - 1] = 0;
                i8[b8[9] - 1] = 0;
            }
            if (c8[9] != 0)
            {
                a8[c8[9] - 1] = 0;
                b8[c8[9] - 1] = 0;
                d8[c8[9] - 1] = 0;
                e8[c8[9] - 1] = 0;
                f8[c8[9] - 1] = 0;
                g8[c8[9] - 1] = 0;
                h8[c8[9] - 1] = 0;
                i8[c8[9] - 1] = 0;
            }
            if (d8[9] != 0)
            {
                a8[d8[9] - 1] = 0;
                b8[d8[9] - 1] = 0;
                c8[d8[9] - 1] = 0;
                e8[d8[9] - 1] = 0;
                f8[d8[9] - 1] = 0;
                g8[d8[9] - 1] = 0;
                h8[d8[9] - 1] = 0;
                i8[d8[9] - 1] = 0;
            }
            if (e8[9] != 0)
            {
                a8[e8[9] - 1] = 0;
                b8[e8[9] - 1] = 0;
                c8[e8[9] - 1] = 0;
                d8[e8[9] - 1] = 0;
                f8[e8[9] - 1] = 0;
                g8[e8[9] - 1] = 0;
                h8[e8[9] - 1] = 0;
                i8[e8[9] - 1] = 0;
            }
            if (f8[9] != 0)
            {
                a8[f8[9] - 1] = 0;
                b8[f8[9] - 1] = 0;
                c8[f8[9] - 1] = 0;
                d8[f8[9] - 1] = 0;
                e8[f8[9] - 1] = 0;
                g8[f8[9] - 1] = 0;
                h8[f8[9] - 1] = 0;
                i8[f8[9] - 1] = 0;
            }
            if (g8[9] != 0)
            {
                a8[g8[9] - 1] = 0;
                b8[g8[9] - 1] = 0;
                c8[g8[9] - 1] = 0;
                d8[g8[9] - 1] = 0;
                e8[g8[9] - 1] = 0;
                f8[g8[9] - 1] = 0;
                h8[g8[9] - 1] = 0;
                i8[g8[9] - 1] = 0;
            }
            if (h8[9] != 0)
            {
                a8[h8[9] - 1] = 0;
                b8[h8[9] - 1] = 0;
                c8[h8[9] - 1] = 0;
                d8[h8[9] - 1] = 0;
                e8[h8[9] - 1] = 0;
                f8[h8[9] - 1] = 0;
                g8[h8[9] - 1] = 0;
                i8[h8[9] - 1] = 0;
            }

            if (i8[9] != 0)
            {
                a8[i8[9] - 1] = 0;
                b8[i8[9] - 1] = 0;
                c8[i8[9] - 1] = 0;
                d8[i8[9] - 1] = 0;
                e8[i8[9] - 1] = 0;
                f8[i8[9] - 1] = 0;
                g8[i8[9] - 1] = 0;
                h8[i8[9] - 1] = 0;
            }
            //Line 8 end

            if (a9[9] != 0)
            {
                b9[a9[9] - 1] = 0;
                c9[a9[9] - 1] = 0;
                d9[a9[9] - 1] = 0;
                e9[a9[9] - 1] = 0;
                f9[a9[9] - 1] = 0;
                g9[a9[9] - 1] = 0;
                h9[a9[9] - 1] = 0;
                i9[a9[9] - 1] = 0;
            }
            if (b9[9] != 0)
            {
                a9[b9[9] - 1] = 0;
                c9[b9[9] - 1] = 0;
                d9[b9[9] - 1] = 0;
                e9[b9[9] - 1] = 0;
                f9[b9[9] - 1] = 0;
                g9[b9[9] - 1] = 0;
                h9[b9[9] - 1] = 0;
                i9[b9[9] - 1] = 0;
            }
            if (c9[9] != 0)
            {
                a9[c9[9] - 1] = 0;
                b9[c9[9] - 1] = 0;
                d9[c9[9] - 1] = 0;
                e9[c9[9] - 1] = 0;
                f9[c9[9] - 1] = 0;
                g9[c9[9] - 1] = 0;
                h9[c9[9] - 1] = 0;
                i9[c9[9] - 1] = 0;
            }
            if (d9[9] != 0)
            {
                a9[d9[9] - 1] = 0;
                b9[d9[9] - 1] = 0;
                c9[d9[9] - 1] = 0;
                e9[d9[9] - 1] = 0;
                f9[d9[9] - 1] = 0;
                g9[d9[9] - 1] = 0;
                h9[d9[9] - 1] = 0;
                i9[d9[9] - 1] = 0;
            }
            if (e9[9] != 0)
            {
                a9[e9[9] - 1] = 0;
                b9[e9[9] - 1] = 0;
                c9[e9[9] - 1] = 0;
                d9[e9[9] - 1] = 0;
                f9[e9[9] - 1] = 0;
                g9[e9[9] - 1] = 0;
                h9[e9[9] - 1] = 0;
                i9[e9[9] - 1] = 0;
            }
            if (f9[9] != 0)
            {
                a9[f9[9] - 1] = 0;
                b9[f9[9] - 1] = 0;
                c9[f9[9] - 1] = 0;
                d9[f9[9] - 1] = 0;
                e9[f9[9] - 1] = 0;
                g9[f9[9] - 1] = 0;
                h9[f9[9] - 1] = 0;
                i9[f9[9] - 1] = 0;
            }
            if (g9[9] != 0)
            {
                a9[g9[9] - 1] = 0;
                b9[g9[9] - 1] = 0;
                c9[g9[9] - 1] = 0;
                d9[g9[9] - 1] = 0;
                e9[g9[9] - 1] = 0;
                f9[g9[9] - 1] = 0;
                h9[g9[9] - 1] = 0;
                i9[g9[9] - 1] = 0;
            }
            if (h9[9] != 0)
            {
                a9[h9[9] - 1] = 0;
                b9[h9[9] - 1] = 0;
                c9[h9[9] - 1] = 0;
                d9[h9[9] - 1] = 0;
                e9[h9[9] - 1] = 0;
                f9[h9[9] - 1] = 0;
                g9[h9[9] - 1] = 0;
                i9[h9[9] - 1] = 0;
            }
            if (i9[9] != 0)
            {
                a9[i9[9] - 1] = 0;
                b9[i9[9] - 1] = 0;
                c9[i9[9] - 1] = 0;
                d9[i9[9] - 1] = 0;
                e9[i9[9] - 1] = 0;
                f9[i9[9] - 1] = 0;
                g9[i9[9] - 1] = 0;
                h9[i9[9] - 1] = 0;
            }
            //Line 9 end
            //full Lines end.
        }

        public void Cubic_Check()
        {

            if (a1[9] != 0)
            {
                a2[a1[9] - 1] = 0;
                a3[a1[9] - 1] = 0;
                b1[a1[9] - 1] = 0;
                b2[a1[9] - 1] = 0;
                b3[a1[9] - 1] = 0;
                c1[a1[9] - 1] = 0;
                c2[a1[9] - 1] = 0;
                c3[a1[9] - 1] = 0;
            }

            if (a2[9] != 0)
            {
                a1[a2[9] - 1] = 0;
                a3[a2[9] - 1] = 0;
                b1[a2[9] - 1] = 0;
                b2[a2[9] - 1] = 0;
                b3[a2[9] - 1] = 0;
                c1[a2[9] - 1] = 0;
                c2[a2[9] - 1] = 0;
                c3[a2[9] - 1] = 0;
            }

            if (a3[9] != 0)
            {
                a1[a3[9] - 1] = 0;
                a2[a3[9] - 1] = 0;
                b1[a3[9] - 1] = 0;
                b2[a3[9] - 1] = 0;
                b3[a3[9] - 1] = 0;
                c1[a3[9] - 1] = 0;
                c2[a3[9] - 1] = 0;
                c3[a3[9] - 1] = 0;
            }
            if (b1[9] != 0)
            {
                a2[b1[9] - 1] = 0;
                a3[b1[9] - 1] = 0;
                a1[b1[9] - 1] = 0;
                b2[b1[9] - 1] = 0;
                b3[b1[9] - 1] = 0;
                c1[b1[9] - 1] = 0;
                c2[b1[9] - 1] = 0;
                c3[b1[9] - 1] = 0;
            }
            if (b2[9] != 0)
            {
                a1[b2[9] - 1] = 0;
                a3[b2[9] - 1] = 0;
                b1[b2[9] - 1] = 0;
                a2[b2[9] - 1] = 0;
                b3[b2[9] - 1] = 0;
                c1[b2[9] - 1] = 0;
                c2[b2[9] - 1] = 0;
                c3[b2[9] - 1] = 0;
            }

            if (b3[9] != 0)
            {
                a1[b3[9] - 1] = 0;
                a2[b3[9] - 1] = 0;
                b1[b3[9] - 1] = 0;
                b2[b3[9] - 1] = 0;
                a3[b3[9] - 1] = 0;
                c1[b3[9] - 1] = 0;
                c2[b3[9] - 1] = 0;
                c3[b3[9] - 1] = 0;
            }
            if (c1[9] != 0)
            {
                a1[c1[9] - 1] = 0;
                a2[c1[9] - 1] = 0;
                a3[c1[9] - 1] = 0;
                b2[c1[9] - 1] = 0;
                b3[c1[9] - 1] = 0;
                b1[c1[9] - 1] = 0;
                c2[c1[9] - 1] = 0;
                c3[c1[9] - 1] = 0;
            }
            if (c2[9] != 0)
            {
                a1[c2[9] - 1] = 0;
                a2[c2[9] - 1] = 0;
                a3[c2[9] - 1] = 0;
                b1[c2[9] - 1] = 0;
                b3[c2[9] - 1] = 0;
                c1[c2[9] - 1] = 0;
                b2[c2[9] - 1] = 0;
                c3[c2[9] - 1] = 0;
            }
            if (c3[9] != 0)
            {
                a1[c3[9] - 1] = 0;
                a2[c3[9] - 1] = 0;
                a3[c3[9] - 1] = 0;
                b1[c3[9] - 1] = 0;
                b2[c3[9] - 1] = 0;
                c1[c3[9] - 1] = 0;
                c2[c3[9] - 1] = 0;
                b3[c3[9] - 1] = 0;
            }
            //Left 1 End.(A1-A3:C1-C3)

            if (a4[9] != 0)
            {
                a5[a4[9] - 1] = 0;
                a6[a4[9] - 1] = 0;
                b4[a4[9] - 1] = 0;
                b5[a4[9] - 1] = 0;
                b6[a4[9] - 1] = 0;
                c4[a4[9] - 1] = 0;
                c5[a4[9] - 1] = 0;
                c6[a4[9] - 1] = 0;
            }
            if (a5[9] != 0)
            {
                a4[a5[9] - 1] = 0;
                a6[a5[9] - 1] = 0;
                b4[a5[9] - 1] = 0;
                b5[a5[9] - 1] = 0;
                b6[a5[9] - 1] = 0;
                c4[a5[9] - 1] = 0;
                c5[a5[9] - 1] = 0;
                c6[a5[9] - 1] = 0;
            }

            if (a6[9] != 0)
            {
                a4[a6[9] - 1] = 0;
                a5[a6[9] - 1] = 0;
                b4[a6[9] - 1] = 0;
                b5[a6[9] - 1] = 0;
                b6[a6[9] - 1] = 0;
                c4[a6[9] - 1] = 0;
                c5[a6[9] - 1] = 0;
                c6[a6[9] - 1] = 0;
            }
            if (b4[9] != 0)
            {
                a4[b4[9] - 1] = 0;
                a5[b4[9] - 1] = 0;
                a6[b4[9] - 1] = 0;
                b5[b4[9] - 1] = 0;
                b6[b4[9] - 1] = 0;
                c4[b4[9] - 1] = 0;
                c5[b4[9] - 1] = 0;
                c6[b4[9] - 1] = 0;
            }
            if (b5[9] != 0)
            {
                a4[b5[9] - 1] = 0;
                a5[b5[9] - 1] = 0;
                a6[b5[9] - 1] = 0;
                b4[b5[9] - 1] = 0;
                b6[b5[9] - 1] = 0;
                c4[b5[9] - 1] = 0;
                c5[b5[9] - 1] = 0;
                c6[b5[9] - 1] = 0;
            }
            if (b6[9] != 0)
            {
                a4[b6[9] - 1] = 0;
                a5[b6[9] - 1] = 0;
                a6[b6[9] - 1] = 0;
                b4[b6[9] - 1] = 0;
                b5[b6[9] - 1] = 0;
                c4[b6[9] - 1] = 0;
                c5[b6[9] - 1] = 0;
                c6[b6[9] - 1] = 0;
            }

            if (c4[9] != 0)
            {
                a4[c4[9] - 1] = 0;
                a5[c4[9] - 1] = 0;
                a6[c4[9] - 1] = 0;
                b5[c4[9] - 1] = 0;
                b6[c4[9] - 1] = 0;
                b4[c4[9] - 1] = 0;
                c5[c4[9] - 1] = 0;
                c6[c4[9] - 1] = 0;
            }
            if (c5[9] != 0)
            {
                a4[c5[9] - 1] = 0;
                a5[c5[9] - 1] = 0;
                a6[c5[9] - 1] = 0;
                b4[c5[9] - 1] = 0;
                b5[c5[9] - 1] = 0;
                b6[c5[9] - 1] = 0;
                c5[c5[9] - 1] = 0;
                c6[c5[9] - 1] = 0;
            }
            if (c6[9] != 0)
            {
                a4[c6[9] - 1] = 0;
                a5[c6[9] - 1] = 0;
                a6[c6[9] - 1] = 0;
                b4[c6[9] - 1] = 0;
                b5[c6[9] - 1] = 0;
                b6[c6[9] - 1] = 0;
                c4[c6[9] - 1] = 0;
                c5[c6[9] - 1] = 0;
            }
            //A4-A6：C4-C6
            if (a7[9] != 0)
            {
                a8[a7[9] - 1] = 0;
                a9[a7[9] - 1] = 0;
                b7[a7[9] - 1] = 0;
                b8[a7[9] - 1] = 0;
                b9[a7[9] - 1] = 0;
                c7[a7[9] - 1] = 0;
                c8[a7[9] - 1] = 0;
                c9[a7[9] - 1] = 0;
            }
            if (a8[9] != 0)
            {
                a7[a8[9] - 1] = 0;
                a9[a8[9] - 1] = 0;
                b7[a8[9] - 1] = 0;
                b8[a8[9] - 1] = 0;
                b9[a8[9] - 1] = 0;
                c7[a8[9] - 1] = 0;
                c8[a8[9] - 1] = 0;
                c9[a8[9] - 1] = 0;
            }

            if (a9[9] != 0)
            {
                a7[a9[9] - 1] = 0;
                a8[a9[9] - 1] = 0;
                b7[a9[9] - 1] = 0;
                b8[a9[9] - 1] = 0;
                b9[a9[9] - 1] = 0;
                c7[a9[9] - 1] = 0;
                c8[a9[9] - 1] = 0;
                c9[a9[9] - 1] = 0;
            }

            if (b7[9] != 0)
            {
                a8[b7[9] - 1] = 0;
                a9[b7[9] - 1] = 0;
                a7[b7[9] - 1] = 0;
                b8[b7[9] - 1] = 0;
                b9[b7[9] - 1] = 0;
                c7[b7[9] - 1] = 0;
                c8[b7[9] - 1] = 0;
                c9[b7[9] - 1] = 0;
            }
            if (b8[9] != 0)
            {
                a7[b8[9] - 1] = 0;
                a8[b8[9] - 1] = 0;
                a9[b8[9] - 1] = 0;
                b7[b8[9] - 1] = 0;
                b9[b8[9] - 1] = 0;
                c7[b8[9] - 1] = 0;
                c8[b8[9] - 1] = 0;
                c9[b8[9] - 1] = 0;
            }

            if (b9[9] != 0)
            {
                a7[b9[9] - 1] = 0;
                a8[b9[9] - 1] = 0;
                b7[b9[9] - 1] = 0;
                b8[b9[9] - 1] = 0;
                a9[b9[9] - 1] = 0;
                c7[b9[9] - 1] = 0;
                c8[b9[9] - 1] = 0;
                c9[b9[9] - 1] = 0;
            }

            if (c7[9] != 0)
            {
                a8[c7[9] - 1] = 0;
                a9[c7[9] - 1] = 0;
                a7[c7[9] - 1] = 0;
                b8[c7[9] - 1] = 0;
                b9[c7[9] - 1] = 0;
                b7[c7[9] - 1] = 0;
                c8[c7[9] - 1] = 0;
                c9[c7[9] - 1] = 0;
            }
            if (c8[9] != 0)
            {
                a7[c8[9] - 1] = 0;
                a8[c8[9] - 1] = 0;
                a9[c8[9] - 1] = 0;
                b7[c8[9] - 1] = 0;
                b8[c8[9] - 1] = 0;
                b9[c8[9] - 1] = 0;
                c7[c8[9] - 1] = 0;
                c9[c8[9] - 1] = 0;
            }

            if (c9[9] != 0)
            {
                a7[c9[9] - 1] = 0;
                a8[c9[9] - 1] = 0;
                a9[c9[9] - 1] = 0;
                b8[c9[9] - 1] = 0;
                b9[c9[9] - 1] = 0;
                b7[c9[9] - 1] = 0;
                c8[c9[9] - 1] = 0;
                c7[c9[9] - 1] = 0;
            }
            //A7-A9:C7-C9 end

            //the below auto-generated by other IDE

            if (d1[9] != 0)
            {
                d2[d1[9] - 1] = 0;
                d3[d1[9] - 1] = 0;
                e1[d1[9] - 1] = 0;
                e2[d1[9] - 1] = 0;
                e3[d1[9] - 1] = 0;
                f1[d1[9] - 1] = 0;
                f2[d1[9] - 1] = 0;
                f3[d1[9] - 1] = 0;
            }
            if (d2[9] != 0)
            {
                d1[d2[9] - 1] = 0;
                d3[d2[9] - 1] = 0;
                e1[d2[9] - 1] = 0;
                e2[d2[9] - 1] = 0;
                e3[d2[9] - 1] = 0;
                f1[d2[9] - 1] = 0;
                f2[d2[9] - 1] = 0;
                f3[d2[9] - 1] = 0;
            }

            if (d3[9] != 0)
            {
                d1[d3[9] - 1] = 0;
                d2[d3[9] - 1] = 0;
                e1[d3[9] - 1] = 0;
                e2[d3[9] - 1] = 0;
                e3[d3[9] - 1] = 0;
                f1[d3[9] - 1] = 0;
                f2[d3[9] - 1] = 0;
                f3[d3[9] - 1] = 0;
            }
            if (e1[9] != 0)
            {
                d2[e1[9] - 1] = 0;
                d3[e1[9] - 1] = 0;
                d1[e1[9] - 1] = 0;
                e2[e1[9] - 1] = 0;
                e3[e1[9] - 1] = 0;
                f1[e1[9] - 1] = 0;
                f2[e1[9] - 1] = 0;
                f3[e1[9] - 1] = 0;
            }
            if (e2[9] != 0)
            {
                d1[e2[9] - 1] = 0;
                d3[e2[9] - 1] = 0;
                e1[e2[9] - 1] = 0;
                d2[e2[9] - 1] = 0;
                e3[e2[9] - 1] = 0;
                f1[e2[9] - 1] = 0;
                f2[e2[9] - 1] = 0;
                f3[e2[9] - 1] = 0;
            }

            if (e3[9] != 0)
            {
                d1[e3[9] - 1] = 0;
                d2[e3[9] - 1] = 0;
                e1[e3[9] - 1] = 0;
                e2[e3[9] - 1] = 0;
                d3[e3[9] - 1] = 0;
                f1[e3[9] - 1] = 0;
                f2[e3[9] - 1] = 0;
                f3[e3[9] - 1] = 0;
            }
            if (f1[9] != 0)
            {
                d1[f1[9] - 1] = 0;
                d2[f1[9] - 1] = 0;
                d3[f1[9] - 1] = 0;
                e2[f1[9] - 1] = 0;
                e3[f1[9] - 1] = 0;
                e1[f1[9] - 1] = 0;
                f2[f1[9] - 1] = 0;
                f3[f1[9] - 1] = 0;
            }
            if (f2[9] != 0)
            {
                d1[f2[9] - 1] = 0;
                d2[f2[9] - 1] = 0;
                d3[f2[9] - 1] = 0;
                e1[f2[9] - 1] = 0;
                e3[f2[9] - 1] = 0;
                f1[f2[9] - 1] = 0;
                e2[f2[9] - 1] = 0;
                f3[f2[9] - 1] = 0;
            }
            if (f3[9] != 0)
            {
                d1[f3[9] - 1] = 0;
                d2[f3[9] - 1] = 0;
                d3[f3[9] - 1] = 0;
                e1[f3[9] - 1] = 0;
                e2[f3[9] - 1] = 0;
                f1[f3[9] - 1] = 0;
                f2[f3[9] - 1] = 0;
                e3[f3[9] - 1] = 0;
            }
            //Left 1 End.(A1-A3:C1-C3)

            if (d4[9] != 0)
            {
                d5[d4[9] - 1] = 0;
                d6[d4[9] - 1] = 0;
                e4[d4[9] - 1] = 0;
                e5[d4[9] - 1] = 0;
                e6[d4[9] - 1] = 0;
                f4[d4[9] - 1] = 0;
                f5[d4[9] - 1] = 0;
                f6[d4[9] - 1] = 0;
            }
            if (d5[9] != 0)
            {
                d4[d5[9] - 1] = 0;
                d6[d5[9] - 1] = 0;
                e4[d5[9] - 1] = 0;
                e5[d5[9] - 1] = 0;
                e6[d5[9] - 1] = 0;
                f4[d5[9] - 1] = 0;
                f5[d5[9] - 1] = 0;
                f6[d5[9] - 1] = 0;
            }

            if (d6[9] != 0)
            {
                d4[d6[9] - 1] = 0;
                d5[d6[9] - 1] = 0;
                e4[d6[9] - 1] = 0;
                e5[d6[9] - 1] = 0;
                e6[d6[9] - 1] = 0;
                f4[d6[9] - 1] = 0;
                f5[d6[9] - 1] = 0;
                f6[d6[9] - 1] = 0;
            }
            if (e4[9] != 0)
            {
                d4[e4[9] - 1] = 0;
                d5[e4[9] - 1] = 0;
                d6[e4[9] - 1] = 0;
                e5[e4[9] - 1] = 0;
                e6[e4[9] - 1] = 0;
                f4[e4[9] - 1] = 0;
                f5[e4[9] - 1] = 0;
                f6[e4[9] - 1] = 0;
            }
            if (e5[9] != 0)
            {
                d4[e5[9] - 1] = 0;
                d5[e5[9] - 1] = 0;
                d6[e5[9] - 1] = 0;
                e4[e5[9] - 1] = 0;
                e6[e5[9] - 1] = 0;
                f4[e5[9] - 1] = 0;
                f5[e5[9] - 1] = 0;
                f6[e5[9] - 1] = 0;
            }
            if (e6[9] != 0)
            {
                d4[e6[9] - 1] = 0;
                d5[e6[9] - 1] = 0;
                d6[e6[9] - 1] = 0;
                e4[e6[9] - 1] = 0;
                e5[e6[9] - 1] = 0;
                f4[e6[9] - 1] = 0;
                f5[e6[9] - 1] = 0;
                f6[e6[9] - 1] = 0;
            }

            if (f4[9] != 0)
            {
                d4[f4[9] - 1] = 0;
                d5[f4[9] - 1] = 0;
                d6[f4[9] - 1] = 0;
                e5[f4[9] - 1] = 0;
                e6[f4[9] - 1] = 0;
                e4[f4[9] - 1] = 0;
                f5[f4[9] - 1] = 0;
                f6[f4[9] - 1] = 0;
            }
            if (f5[9] != 0)
            {
                d4[f5[9] - 1] = 0;
                d5[f5[9] - 1] = 0;
                d6[f5[9] - 1] = 0;
                e4[f5[9] - 1] = 0;
                e5[f5[9] - 1] = 0;
                e6[f5[9] - 1] = 0;
                f5[f5[9] - 1] = 0;
                f6[f5[9] - 1] = 0;
            }
            if (f6[9] != 0)
            {
                d4[f6[9] - 1] = 0;
                d5[f6[9] - 1] = 0;
                d6[f6[9] - 1] = 0;
                e4[f6[9] - 1] = 0;
                e5[f6[9] - 1] = 0;
                e6[f6[9] - 1] = 0;
                f4[f6[9] - 1] = 0;
                f5[f6[9] - 1] = 0;
            }
            //A4-A6：C4-C6
            if (d7[9] != 0)
            {
                d8[d7[9] - 1] = 0;
                d9[d7[9] - 1] = 0;
                e7[d7[9] - 1] = 0;
                e8[d7[9] - 1] = 0;
                e9[d7[9] - 1] = 0;
                f7[d7[9] - 1] = 0;
                f8[d7[9] - 1] = 0;
                f9[d7[9] - 1] = 0;
            }
            if (d8[9] != 0)
            {
                d7[d8[9] - 1] = 0;
                d9[d8[9] - 1] = 0;
                e7[d8[9] - 1] = 0;
                e8[d8[9] - 1] = 0;
                e9[d8[9] - 1] = 0;
                f7[d8[9] - 1] = 0;
                f8[d8[9] - 1] = 0;
                f9[d8[9] - 1] = 0;
            }

            if (d9[9] != 0)
            {
                d7[d9[9] - 1] = 0;
                d8[d9[9] - 1] = 0;
                e7[d9[9] - 1] = 0;
                e8[d9[9] - 1] = 0;
                e9[d9[9] - 1] = 0;
                f7[d9[9] - 1] = 0;
                f8[d9[9] - 1] = 0;
                f9[d9[9] - 1] = 0;
            }

            if (e7[9] != 0)
            {
                d8[e7[9] - 1] = 0;
                d9[e7[9] - 1] = 0;
                d7[e7[9] - 1] = 0;
                e8[e7[9] - 1] = 0;
                e9[e7[9] - 1] = 0;
                f7[e7[9] - 1] = 0;
                f8[e7[9] - 1] = 0;
                f9[e7[9] - 1] = 0;
            }
            if (e8[9] != 0)
            {
                d7[e8[9] - 1] = 0;
                d8[e8[9] - 1] = 0;
                d9[e8[9] - 1] = 0;
                e7[e8[9] - 1] = 0;
                e9[e8[9] - 1] = 0;
                f7[e8[9] - 1] = 0;
                f8[e8[9] - 1] = 0;
                f9[e8[9] - 1] = 0;
            }

            if (e9[9] != 0)
            {
                d7[e9[9] - 1] = 0;
                d8[e9[9] - 1] = 0;
                e7[e9[9] - 1] = 0;
                e8[e9[9] - 1] = 0;
                d9[e9[9] - 1] = 0;
                f7[e9[9] - 1] = 0;
                f8[e9[9] - 1] = 0;
                f9[e9[9] - 1] = 0;
            }

            if (f7[9] != 0)
            {
                d8[f7[9] - 1] = 0;
                d9[f7[9] - 1] = 0;
                d7[f7[9] - 1] = 0;
                e8[f7[9] - 1] = 0;
                e9[f7[9] - 1] = 0;
                e7[f7[9] - 1] = 0;
                f8[f7[9] - 1] = 0;
                f9[f7[9] - 1] = 0;
            }
            if (f8[9] != 0)
            {
                d7[f8[9] - 1] = 0;
                d8[f8[9] - 1] = 0;
                d9[f8[9] - 1] = 0;
                e7[f8[9] - 1] = 0;
                e8[f8[9] - 1] = 0;
                e9[f8[9] - 1] = 0;
                f7[f8[9] - 1] = 0;
                f9[f8[9] - 1] = 0;
            }

            if (f9[9] != 0)
            {
                d7[f9[9] - 1] = 0;
                d8[f9[9] - 1] = 0;
                d9[f9[9] - 1] = 0;
                e8[f9[9] - 1] = 0;
                e9[f9[9] - 1] = 0;
                e7[f9[9] - 1] = 0;
                f8[f9[9] - 1] = 0;
                f7[f9[9] - 1] = 0;
            }
            //Second Line finished

            if (g1[9] != 0)
            {
                g2[g1[9] - 1] = 0;
                g3[g1[9] - 1] = 0;
                h1[g1[9] - 1] = 0;
                h2[g1[9] - 1] = 0;
                h3[g1[9] - 1] = 0;
                i1[g1[9] - 1] = 0;
                i2[g1[9] - 1] = 0;
                i3[g1[9] - 1] = 0;
            }
            if (g2[9] != 0)
            {
                g1[g2[9] - 1] = 0;
                g3[g2[9] - 1] = 0;
                h1[g2[9] - 1] = 0;
                h2[g2[9] - 1] = 0;
                h3[g2[9] - 1] = 0;
                i1[g2[9] - 1] = 0;
                i2[g2[9] - 1] = 0;
                i3[g2[9] - 1] = 0;
            }

            if (g3[9] != 0)
            {
                g1[g3[9] - 1] = 0;
                g2[g3[9] - 1] = 0;
                h1[g3[9] - 1] = 0;
                h2[g3[9] - 1] = 0;
                h3[g3[9] - 1] = 0;
                i1[g3[9] - 1] = 0;
                i2[g3[9] - 1] = 0;
                i3[g3[9] - 1] = 0;
            }
            if (h1[9] != 0)
            {
                g2[h1[9] - 1] = 0;
                g3[h1[9] - 1] = 0;
                g1[h1[9] - 1] = 0;
                h2[h1[9] - 1] = 0;
                h3[h1[9] - 1] = 0;
                i1[h1[9] - 1] = 0;
                i2[h1[9] - 1] = 0;
                i3[h1[9] - 1] = 0;
            }
            if (h2[9] != 0)
            {
                g1[h2[9] - 1] = 0;
                g3[h2[9] - 1] = 0;
                h1[h2[9] - 1] = 0;
                g2[h2[9] - 1] = 0;
                h3[h2[9] - 1] = 0;
                i1[h2[9] - 1] = 0;
                i2[h2[9] - 1] = 0;
                i3[h2[9] - 1] = 0;
            }

            if (h3[9] != 0)
            {
                g1[h3[9] - 1] = 0;
                g2[h3[9] - 1] = 0;
                h1[h3[9] - 1] = 0;
                h2[h3[9] - 1] = 0;
                g3[h3[9] - 1] = 0;
                i1[h3[9] - 1] = 0;
                i2[h3[9] - 1] = 0;
                i3[h3[9] - 1] = 0;
            }
            if (i1[9] != 0)
            {
                g1[i1[9] - 1] = 0;
                g2[i1[9] - 1] = 0;
                g3[i1[9] - 1] = 0;
                h2[i1[9] - 1] = 0;
                h3[i1[9] - 1] = 0;
                h1[i1[9] - 1] = 0;
                i2[i1[9] - 1] = 0;
                i3[i1[9] - 1] = 0;
            }
            if (i2[9] != 0)
            {
                g1[i2[9] - 1] = 0;
                g2[i2[9] - 1] = 0;
                g3[i2[9] - 1] = 0;
                h1[i2[9] - 1] = 0;
                h3[i2[9] - 1] = 0;
                i1[i2[9] - 1] = 0;
                h2[i2[9] - 1] = 0;
                i3[i2[9] - 1] = 0;
            }
            if (i3[9] != 0)
            {
                g1[i3[9] - 1] = 0;
                g2[i3[9] - 1] = 0;
                g3[i3[9] - 1] = 0;
                h1[i3[9] - 1] = 0;
                h2[i3[9] - 1] = 0;
                i1[i3[9] - 1] = 0;
                i2[i3[9] - 1] = 0;
                h3[i3[9] - 1] = 0;
            }
            //Lhit 1 Eng.(A1-A3:C1-C3)

            if (g4[9] != 0)
            {
                g5[g4[9] - 1] = 0;
                g6[g4[9] - 1] = 0;
                h4[g4[9] - 1] = 0;
                h5[g4[9] - 1] = 0;
                h6[g4[9] - 1] = 0;
                i4[g4[9] - 1] = 0;
                i5[g4[9] - 1] = 0;
                i6[g4[9] - 1] = 0;
            }
            if (g5[9] != 0)
            {
                g4[g5[9] - 1] = 0;
                g6[g5[9] - 1] = 0;
                h4[g5[9] - 1] = 0;
                h5[g5[9] - 1] = 0;
                h6[g5[9] - 1] = 0;
                i4[g5[9] - 1] = 0;
                i5[g5[9] - 1] = 0;
                i6[g5[9] - 1] = 0;
            }

            if (g6[9] != 0)
            {
                g4[g6[9] - 1] = 0;
                g5[g6[9] - 1] = 0;
                h4[g6[9] - 1] = 0;
                h5[g6[9] - 1] = 0;
                h6[g6[9] - 1] = 0;
                i4[g6[9] - 1] = 0;
                i5[g6[9] - 1] = 0;
                i6[g6[9] - 1] = 0;
            }
            if (h4[9] != 0)
            {
                g4[h4[9] - 1] = 0;
                g5[h4[9] - 1] = 0;
                g6[h4[9] - 1] = 0;
                h5[h4[9] - 1] = 0;
                h6[h4[9] - 1] = 0;
                i4[h4[9] - 1] = 0;
                i5[h4[9] - 1] = 0;
                i6[h4[9] - 1] = 0;
            }
            if (h5[9] != 0)
            {
                g4[h5[9] - 1] = 0;
                g5[h5[9] - 1] = 0;
                g6[h5[9] - 1] = 0;
                h4[h5[9] - 1] = 0;
                h6[h5[9] - 1] = 0;
                i4[h5[9] - 1] = 0;
                i5[h5[9] - 1] = 0;
                i6[h5[9] - 1] = 0;
            }
            if (h6[9] != 0)
            {
                g4[h6[9] - 1] = 0;
                g5[h6[9] - 1] = 0;
                g6[h6[9] - 1] = 0;
                h4[h6[9] - 1] = 0;
                h5[h6[9] - 1] = 0;
                i4[h6[9] - 1] = 0;
                i5[h6[9] - 1] = 0;
                i6[h6[9] - 1] = 0;
            }

            if (i4[9] != 0)
            {
                g4[i4[9] - 1] = 0;
                g5[i4[9] - 1] = 0;
                g6[i4[9] - 1] = 0;
                h5[i4[9] - 1] = 0;
                h6[i4[9] - 1] = 0;
                h4[i4[9] - 1] = 0;
                i5[i4[9] - 1] = 0;
                i6[i4[9] - 1] = 0;
            }
            if (i5[9] != 0)
            {
                g4[i5[9] - 1] = 0;
                g5[i5[9] - 1] = 0;
                g6[i5[9] - 1] = 0;
                h4[i5[9] - 1] = 0;
                h5[i5[9] - 1] = 0;
                h6[i5[9] - 1] = 0;
                i5[i5[9] - 1] = 0;
                i6[i5[9] - 1] = 0;
            }
            if (i6[9] != 0)
            {
                g4[i6[9] - 1] = 0;
                g5[i6[9] - 1] = 0;
                g6[i6[9] - 1] = 0;
                h4[i6[9] - 1] = 0;
                h5[i6[9] - 1] = 0;
                h6[i6[9] - 1] = 0;
                i4[i6[9] - 1] = 0;
                i5[i6[9] - 1] = 0;
            }
            //A4-A6：C4-C6
            if (g7[9] != 0)
            {
                g8[g7[9] - 1] = 0;
                g9[g7[9] - 1] = 0;
                h7[g7[9] - 1] = 0;
                h8[g7[9] - 1] = 0;
                h9[g7[9] - 1] = 0;
                i7[g7[9] - 1] = 0;
                i8[g7[9] - 1] = 0;
                i9[g7[9] - 1] = 0;
            }
            if (g8[9] != 0)
            {
                g7[g8[9] - 1] = 0;
                g9[g8[9] - 1] = 0;
                h7[g8[9] - 1] = 0;
                h8[g8[9] - 1] = 0;
                h9[g8[9] - 1] = 0;
                i7[g8[9] - 1] = 0;
                i8[g8[9] - 1] = 0;
                i9[g8[9] - 1] = 0;
            }

            if (g9[9] != 0)
            {
                g7[g9[9] - 1] = 0;
                g8[g9[9] - 1] = 0;
                h7[g9[9] - 1] = 0;
                h8[g9[9] - 1] = 0;
                h9[g9[9] - 1] = 0;
                i7[g9[9] - 1] = 0;
                i8[g9[9] - 1] = 0;
                i9[g9[9] - 1] = 0;
            }

            if (h7[9] != 0)
            {
                g8[h7[9] - 1] = 0;
                g9[h7[9] - 1] = 0;
                g7[h7[9] - 1] = 0;
                h8[h7[9] - 1] = 0;
                h9[h7[9] - 1] = 0;
                i7[h7[9] - 1] = 0;
                i8[h7[9] - 1] = 0;
                i9[h7[9] - 1] = 0;
            }
            if (h8[9] != 0)
            {
                g7[h8[9] - 1] = 0;
                g8[h8[9] - 1] = 0;
                g9[h8[9] - 1] = 0;
                h7[h8[9] - 1] = 0;
                h9[h8[9] - 1] = 0;
                i7[h8[9] - 1] = 0;
                i8[h8[9] - 1] = 0;
                i9[h8[9] - 1] = 0;
            }

            if (h9[9] != 0)
            {
                g7[h9[9] - 1] = 0;
                g8[h9[9] - 1] = 0;
                h7[h9[9] - 1] = 0;
                h8[h9[9] - 1] = 0;
                g9[h9[9] - 1] = 0;
                i7[h9[9] - 1] = 0;
                i8[h9[9] - 1] = 0;
                i9[h9[9] - 1] = 0;
            }

            if (i7[9] != 0)
            {
                g8[i7[9] - 1] = 0;
                g9[i7[9] - 1] = 0;
                g7[i7[9] - 1] = 0;
                h8[i7[9] - 1] = 0;
                h9[i7[9] - 1] = 0;
                h7[i7[9] - 1] = 0;
                i8[i7[9] - 1] = 0;
                i9[i7[9] - 1] = 0;
            }
            if (i8[9] != 0)
            {
                g7[i8[9] - 1] = 0;
                g8[i8[9] - 1] = 0;
                g9[i8[9] - 1] = 0;
                h7[i8[9] - 1] = 0;
                h8[i8[9] - 1] = 0;
                h9[i8[9] - 1] = 0;
                i7[i8[9] - 1] = 0;
                i9[i8[9] - 1] = 0;
            }

            if (i9[9] != 0)
            {
                g7[i9[9] - 1] = 0;
                g8[i9[9] - 1] = 0;
                g9[i9[9] - 1] = 0;
                h8[i9[9] - 1] = 0;
                h9[i9[9] - 1] = 0;
                h7[i9[9] - 1] = 0;
                i8[i9[9] - 1] = 0;
                i7[i9[9] - 1] = 0;
            }

        }

        void result()
        {
            A1.Text = (Check(a1)) ? Value(a1).ToString() : A1.Text;
            A2.Text = (Check(a2)) ? Value(a2).ToString() : A2.Text;
            A3.Text = (Check(a3)) ? Value(a3).ToString() : A3.Text;
            A4.Text = (Check(a4)) ? Value(a4).ToString() : A4.Text;
            A5.Text = (Check(a5)) ? Value(a5).ToString() : A5.Text;
            A6.Text = (Check(a6)) ? Value(a6).ToString() : A6.Text;
            A7.Text = (Check(a7)) ? Value(a7).ToString() : A7.Text;
            A8.Text = (Check(a8)) ? Value(a8).ToString() : A8.Text;
            A9.Text = (Check(a9)) ? Value(a9).ToString() : A9.Text;

            B1.Text = (Check(b1)) ? Value(b1).ToString() : B1.Text;
            B2.Text = (Check(b2)) ? Value(b2).ToString() : B2.Text;
            B3.Text = (Check(b3)) ? Value(b3).ToString() : B3.Text;
            B4.Text = (Check(b4)) ? Value(b4).ToString() : B4.Text;
            B5.Text = (Check(b5)) ? Value(b5).ToString() : B5.Text;
            B6.Text = (Check(b6)) ? Value(b6).ToString() : B6.Text;
            B7.Text = (Check(b7)) ? Value(b7).ToString() : B7.Text;
            B8.Text = (Check(b8)) ? Value(b8).ToString() : B8.Text;
            B9.Text = (Check(b9)) ? Value(b9).ToString() : B9.Text;

            C1.Text = (Check(c1)) ? Value(c1).ToString() : C1.Text;
            C2.Text = (Check(c2)) ? Value(c2).ToString() : C2.Text;
            C3.Text = (Check(c3)) ? Value(c3).ToString() : C3.Text;
            C4.Text = (Check(c4)) ? Value(c4).ToString() : C4.Text;
            C5.Text = (Check(c5)) ? Value(c5).ToString() : C5.Text;
            C6.Text = (Check(c6)) ? Value(c6).ToString() : C6.Text;
            C7.Text = (Check(c7)) ? Value(c7).ToString() : C7.Text;
            C8.Text = (Check(c8)) ? Value(c8).ToString() : C8.Text;
            C9.Text = (Check(c9)) ? Value(c9).ToString() : C9.Text;

            D1.Text = (Check(d1)) ? Value(d1).ToString() : D1.Text;
            D2.Text = (Check(d2)) ? Value(d2).ToString() : D2.Text;
            D3.Text = (Check(d3)) ? Value(d3).ToString() : D3.Text;
            D4.Text = (Check(d4)) ? Value(d4).ToString() : D4.Text;
            D5.Text = (Check(d5)) ? Value(d5).ToString() : D5.Text;
            D6.Text = (Check(d6)) ? Value(d6).ToString() : D6.Text;
            D7.Text = (Check(d7)) ? Value(d7).ToString() : D7.Text;
            D8.Text = (Check(d8)) ? Value(d8).ToString() : D8.Text;
            D9.Text = (Check(d9)) ? Value(d9).ToString() : D9.Text;

            E1.Text = (Check(e1)) ? Value(e1).ToString() : E1.Text;
            E2.Text = (Check(e2)) ? Value(e2).ToString() : E2.Text;
            E3.Text = (Check(e3)) ? Value(e3).ToString() : E3.Text;
            E4.Text = (Check(e4)) ? Value(e4).ToString() : E4.Text;
            E5.Text = (Check(e5)) ? Value(e5).ToString() : E5.Text;
            E6.Text = (Check(e6)) ? Value(e6).ToString() : E6.Text;
            E7.Text = (Check(e7)) ? Value(e7).ToString() : E7.Text;
            E8.Text = (Check(e8)) ? Value(e8).ToString() : E8.Text;
            E9.Text = (Check(e9)) ? Value(e9).ToString() : E9.Text;

            F1.Text = (Check(f1)) ? Value(f1).ToString() : F1.Text;
            F2.Text = (Check(f2)) ? Value(f2).ToString() : F2.Text;
            F3.Text = (Check(f3)) ? Value(f3).ToString() : F3.Text;
            F4.Text = (Check(f4)) ? Value(f4).ToString() : F4.Text;
            F5.Text = (Check(f5)) ? Value(f5).ToString() : F5.Text;
            F6.Text = (Check(f6)) ? Value(f6).ToString() : F6.Text;
            F7.Text = (Check(f7)) ? Value(f7).ToString() : F7.Text;
            F8.Text = (Check(f8)) ? Value(f8).ToString() : F8.Text;
            F9.Text = (Check(f9)) ? Value(f9).ToString() : F9.Text;

            G1.Text = (Check(g1)) ? Value(g1).ToString() : G1.Text;
            G2.Text = (Check(g2)) ? Value(g2).ToString() : G2.Text;
            G3.Text = (Check(g3)) ? Value(g3).ToString() : G3.Text;
            G4.Text = (Check(g4)) ? Value(g4).ToString() : G4.Text;
            G5.Text = (Check(g5)) ? Value(g5).ToString() : G5.Text;
            G6.Text = (Check(g6)) ? Value(g6).ToString() : G6.Text;
            G7.Text = (Check(g7)) ? Value(g7).ToString() : G7.Text;
            G8.Text = (Check(g8)) ? Value(g8).ToString() : G8.Text;
            G9.Text = (Check(g9)) ? Value(g9).ToString() : G9.Text;

            H1.Text = (Check(h1)) ? Value(h1).ToString() : H1.Text;
            H2.Text = (Check(h2)) ? Value(h2).ToString() : H2.Text;
            H3.Text = (Check(h3)) ? Value(h3).ToString() : H3.Text;
            H4.Text = (Check(h4)) ? Value(h4).ToString() : H4.Text;
            H5.Text = (Check(h5)) ? Value(h5).ToString() : H5.Text;
            H6.Text = (Check(h6)) ? Value(h6).ToString() : H6.Text;
            H7.Text = (Check(h7)) ? Value(h7).ToString() : H7.Text;
            H8.Text = (Check(h8)) ? Value(h8).ToString() : H8.Text;
            H9.Text = (Check(h9)) ? Value(h9).ToString() : H9.Text;

            I1.Text = (Check(i1)) ? Value(i1).ToString() : I1.Text;
            I.Text = (Check(i2)) ? Value(i2).ToString() : I.Text;
            I3.Text = (Check(i3)) ? Value(i3).ToString() : I3.Text;
            I4.Text = (Check(i4)) ? Value(i4).ToString() : I4.Text;
            I5.Text = (Check(i5)) ? Value(i5).ToString() : I5.Text;
            I6.Text = (Check(i6)) ? Value(i6).ToString() : I6.Text;
            I7.Text = (Check(i7)) ? Value(i7).ToString() : I7.Text;
            I8.Text = (Check(i8)) ? Value(i8).ToString() : I8.Text;
            I9.Text = (Check(i9)) ? Value(i9).ToString() : I9.Text;
        }

        private Boolean Check(int[] array)
        {
            Boolean result = false;
            int counter = 0;
            for (int i = 9; i >= 0; i--)
            {
                if (i == 9 && array[9] != 0)
                {
                    break;
                }
                else
                {
                    if (array[i] != 0)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 1)
            {
                result = true;

            }
            return result;
        }

        private int Value(int[] arr)
        {
            int value = -1;
            foreach (int i in arr)
            {
                if (i != 0)
                {
                    value = i;
                }
            }
            return value;
        }

        private void GENERATE_Click(object sender, EventArgs e)
        {
            int counter = 0;
            do
            {
                init();
                Setter();
                Check_Horizontal();
                Check_Vertical();
                Cubic_Check();
                result();
                counter++;
                if (counter == 20)
                {
                    MessageBox.Show("Ran 20 times,Not able to fix this puzzle!", "Error Occured!", MessageBoxButtons.OK);
                    return;
                }
            } while (Finished() == false);
            MessageBox.Show("Solved the puzzle,run:" + counter + " times!");
        }
        private void Changed(object sender, EventArgs e)
        {
          //    SendKeys.Send("{TAB}");
        }
        public bool Finished()
        {
            Boolean result = true;
            if (A1.Text == "") { result =  false; }
            if (A2.Text == "") { result =  false; }
            if (A3.Text == "") { result =  false; }
            if (A4.Text == "") { result =  false; }
            if (A5.Text == "") { result =  false; }
            if (A6.Text == "") { result =  false; }
            if (A7.Text == "") { result =  false; }
            if (A8.Text == "") { result =  false; }
            if (A9.Text == "") { result =  false; }

            if (B1.Text == "") { result =  false; }
            if (B2.Text == "") { result =  false; }
            if (B3.Text == "") { result =  false; }
            if (B4.Text == "") { result =  false; }
            if (B5.Text == "") { result =  false; }
            if (B6.Text == "") { result =  false; }
            if (B7.Text == "") { result =  false; }
            if (B8.Text == "") { result =  false; }
            if (B9.Text == "") { result =  false; }

            if (C1.Text == "") { result =  false; }
            if (C2.Text == "") { result =  false; }
            if (C3.Text == "") { result =  false; }
            if (C4.Text == "") { result =  false; }
            if (C5.Text == "") { result =  false; }
            if (C6.Text == "") { result =  false; }
            if (C7.Text == "") { result =  false; }
            if (C8.Text == "") { result =  false; }
            if (C9.Text == "") { result =  false; }

            if (D1.Text == "") { result =  false; }
            if (D2.Text == "") { result =  false; }
            if (D3.Text == "") { result =  false; }
            if (D4.Text == "") { result =  false; }
            if (D5.Text == "") { result =  false; }
            if (D6.Text == "") { result =  false; }
            if (D7.Text == "") { result =  false; }
            if (D8.Text == "") { result =  false; }
            if (D9.Text == "") { result =  false; }

            if (E1.Text == "") { result =  false; }
            if (E2.Text == "") { result =  false; }
            if (E3.Text == "") { result =  false; }
            if (E4.Text == "") { result =  false; }
            if (E5.Text == "") { result =  false; }
            if (E6.Text == "") { result =  false; }
            if (E7.Text == "") { result =  false; }
            if (E8.Text == "") { result =  false; }
            if (E9.Text == "") { result =  false; }

            if (F1.Text == "") { result =  false; }
            if (F2.Text == "") { result =  false; }
            if (F3.Text == "") { result =  false; }
            if (F4.Text == "") { result =  false; }
            if (F5.Text == "") { result =  false; }
            if (F6.Text == "") { result =  false; }
            if (F7.Text == "") { result =  false; }
            if (F8.Text == "") { result =  false; }
            if (F9.Text == "") { result =  false; }

            if (G1.Text == "") { result =  false; }
            if (G2.Text == "") { result =  false; }
            if (G3.Text == "") { result =  false; }
            if (G4.Text == "") { result =  false; }
            if (G5.Text == "") { result =  false; }
            if (G6.Text == "") { result =  false; }
            if (G7.Text == "") { result =  false; }
            if (G8.Text == "") { result =  false; }
            if (G9.Text == "") { result =  false; }

            if (H1.Text == "") { result =  false; }
            if (H2.Text == "") { result =  false; }
            if (H3.Text == "") { result =  false; }
            if (H4.Text == "") { result =  false; }
            if (H5.Text == "") { result =  false; }
            if (H6.Text == "") { result =  false; }
            if (H7.Text == "") { result =  false; }
            if (H8.Text == "") { result =  false; }
            if (H9.Text == "") { result =  false; }

            if (I1.Text == "") { result =  false; }
            if (I.Text == "") { result =  false; }
            if (I3.Text == "") { result =  false; }
            if (I4.Text == "") { result =  false; }
            if (I5.Text == "") { result =  false; }
            if (I6.Text == "") { result =  false; }
            if (I7.Text == "") { result =  false; }
            if (I8.Text == "") { result =  false; }
            if (I9.Text == "") { result =  false; }
            return result;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            A4.Text = "";
            A5.Text = "";
            A6.Text = "";
            A7.Text = "";
            A8.Text = "";
            A9.Text = "";

            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            B4.Text = "";
            B5.Text = "";
            B6.Text = "";
            B7.Text = "";
            B8.Text = "";
            B9.Text = "";

            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            C4.Text = "";
            C5.Text = "";
            C6.Text = "";
            C7.Text = "";
            C8.Text = "";
            C9.Text = "";

            D1.Text = "";
            D2.Text = "";
            D3.Text = "";
            D4.Text = "";
            D5.Text = "";
            D6.Text = "";
            D7.Text = "";
            D8.Text = "";
            D9.Text = "";

            E1.Text = "";
            E2.Text = "";
            E3.Text = "";
            E4.Text = "";
            E5.Text = "";
            E6.Text = "";
            E7.Text = "";
            E8.Text = "";
            E9.Text = "";

            F1.Text = "";
            F2.Text = "";
            F3.Text = "";
            F4.Text = "";
            F5.Text = "";
            F6.Text = "";
            F7.Text = "";
            F8.Text = "";
            F9.Text = "";

            G1.Text = "";
            G2.Text = "";
            G3.Text = "";
            G4.Text = "";
            G5.Text = "";
            G6.Text = "";
            G7.Text = "";
            G8.Text = "";
            G9.Text = "";

            H1.Text = "";
            H2.Text = "";
            H3.Text = "";
            H4.Text = "";
            H5.Text = "";
            H6.Text = "";
            H7.Text = "";
            H8.Text = "";
            H9.Text = "";

            I1.Text = "";
            I.Text = "";
            I3.Text = "";
            I4.Text = "";
            I5.Text = "";
            I6.Text = "";
            I7.Text = "";
            I8.Text = "";
            I9.Text = "";
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //clear the table
            button2_Click(sender, e);
            Random rnd = new Random();
            Int32 rnd_num = rnd.Next(10);
            switch (rnd_num)
            {
                case 0:
                    this.A1.Text = "";
                    break;
            }
        }
    }
}