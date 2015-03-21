using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card
{
    public class card
    {
        public string name;
        public string type;
        public int value;
        public card(string n, string t, int v)
        {
            name = n;
            type = t;
            value = v;

        }
    }


    class Program
    {
        public static int o, p;
        public static int count = 0;
        public static List<card> list;
        public static Stack<card> st1;
        public static Stack<card> st2;
        public static Stack<card> st3;
        public static Stack<card> st4;
        public static Random r = new Random();

        public static void print()
        {
            card c1 = st1.Peek();
            card c2 = st2.Peek();
            card c3 = st3.Peek();
            card c4 = st4.Peek();


            //Console.WriteLine();
            Console.WriteLine("Slot 1 :  " + c1.name);
           // Console.WriteLine();
            Console.WriteLine("Slot 2 :  " + c2.name);
           // Console.WriteLine();
            Console.WriteLine("Slot 3 :  " + c3.name);
           // Console.WriteLine();
            Console.WriteLine("Slot 4 :  " + c4.name);
            Console.WriteLine();


            Console.WriteLine("Points : " + count);
            Console.WriteLine();
            Console.WriteLine("Left : " + list.Count);
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine(" Deal Card Press      : 1");
            Console.WriteLine(" Discard Card Press   : 2");
            Console.WriteLine(" Move Card Press      : 3");
            Console.WriteLine(" Play Again Press     : 4");
            Console.WriteLine(" For Exit Press       : 5");
            Console.WriteLine();
            Console.Write("Option : ");




        }


        public static void discard()
        {
            int i;

            i = Convert.ToInt32(Console.ReadLine());


            card c1 = st1.Peek();
            card c2 = st2.Peek();
            card c3 = st3.Peek();
            card c4 = st4.Peek();




            if (i == 1)
            {
                if (((c1.type == c2.type) && (c1.value < c2.value)) || ((c1.type == c3.type) && (c1.value < c3.value)) || ((c1.type == c4.type) && (c1.value < c4.value)))
                {
                    st1.Pop();
                    count++;


                }
                else
                {

                }
            }
            else if (i == 2)
            {
                if (((c2.type == c1.type) && (c2.value < c1.value)) || ((c2.type == c3.type) && (c2.value < c3.value)) || ((c2.type == c4.type) && (c2.value < c4.value)))
                {
                    st2.Pop();
                    count++;

                }
                else
                {

                }


            }
            else if (i == 3)
            {
                if (((c3.type == c1.type) && (c3.value < c1.value)) || ((c3.type == c2.type) && (c3.value < c2.value)) || ((c3.type == c4.type) && (c3.value < c4.value)))
                {
                    st3.Pop();
                    count++;

                }
                else
                {

                }


            }
            else if (i == 4)
            {
                if (((c4.type == c1.type) && (c4.value < c1.value)) || ((c4.type == c3.type) && (c4.value < c3.value)) || ((c4.type == c2.type) && (c4.value < c2.value)))
                {
                    st4.Pop();
                    count++;

                }
                else
                {

                }


            }
            else
            {
            }

        }


        public static void move(int x, int y)
        {




            card c1 = st1.Peek();
            card c2 = st2.Peek();
            card c3 = st3.Peek();
            card c4 = st4.Peek();

            if (y == 1)
            {
                if (c1.type == "n")
                {
                    if (x == 2)
                    {
                        card cs = st2.Pop();
                        st1.Push(cs);
                    }
                    if (x == 3)
                    {
                        card cs = st3.Pop();
                        st1.Push(cs);
                    }
                    if (x == 4)
                    {
                        card cs = st2.Pop();
                        st1.Push(cs);
                    }
                    else
                    {
                    }

                }
            }

            else if (y == 2)
            {
                if (c2.type == "n")
                {
                    if (x == 1)
                    {
                        card cs = st1.Pop();
                        st2.Push(cs);
                    }
                    if (x == 3)
                    {
                        card cs = st3.Pop();
                        st2.Push(cs);
                    }
                    if (x == 4)
                    {
                        card cs = st4.Pop();
                        st2.Push(cs);
                    }
                    else
                    {
                    }

                }
            }

            else if (y == 3)
            {
                if (c3.type == "n")
                {
                    if (x == 2)
                    {
                        card cs = st2.Pop();
                        st3.Push(cs);
                    }
                    if (x == 1)
                    {
                        card cs = st1.Pop();
                        st3.Push(cs);
                    }
                    if (x == 4)
                    {
                        card cs = st4.Pop();
                        st3.Push(cs);
                    }
                    else
                    {
                    }

                }
            }

            else if (y == 4)
            {
                if (c4.type == "n")
                {
                    if (x == 2)
                    {
                        card cs = st2.Pop();
                        st4.Push(cs);
                    }
                    if (x == 1)
                    {
                        card cs = st1.Pop();
                        st4.Push(cs);
                    }
                    if (x == 3)
                    {
                        card cs = st3.Pop();
                        st4.Push(cs);
                    }
                    else
                    {
                    }

                }
            }
            else
            {
            }


        }



        public static void dealcard()
        {
            int x, y, z, m;
            x = r.Next(list.Count);           /*Getting r from Random*/
            //Console.WriteLine(list.Count);
            card c1 = list[x];
            st1.Push(c1);
            list.Remove(c1);
            //Console.WriteLine(list.Count);


            y = r.Next(list.Count);

            card c2 = list[y];
            st2.Push(c2);
            list.Remove(c2);



            z = r.Next(list.Count);

            card c3 = list[z];
            st3.Push(c3);
            list.Remove(c3);


            m = r.Next(list.Count);

            card c4 = list[m];
            st4.Push(c4);
            list.Remove(c4);




        }
        static void Main(string[] args)
        {
        yyy: int x;


            list = new List<card>();
            list.Add(new card("Spade A", "s", 14));
            list.Add(new card("Spade K", "s", 13));
            list.Add(new card("Spade Q", "s", 12));
            list.Add(new card("Spade J", "s", 11));
            list.Add(new card("Spade 10", "s", 10));
            list.Add(new card("Spade 9", "s", 9));
            list.Add(new card("Spade 8", "s", 8));
            list.Add(new card("Spade 7", "s", 7));
            list.Add(new card("Spade 6", "s", 6));
            list.Add(new card("Spade 5", "s", 5));
            list.Add(new card("Spade 4", "s", 4));
            list.Add(new card("Spade 3", "s", 3));
            list.Add(new card("Spade 3", "s", 2));

            list.Add(new card("Herts A", "h", 14));
            list.Add(new card("Herts K", "h", 13));
            list.Add(new card("Herts Q", "h", 12));
            list.Add(new card("Herts J", "h", 11));
            list.Add(new card("Herts 10", "h", 10));
            list.Add(new card("Herts 9", "h", 9));
            list.Add(new card("Herts 8", "h", 8));
            list.Add(new card("Herts 7", "h", 7));
            list.Add(new card("Herts 6", "h", 6));
            list.Add(new card("Herts 5", "h", 5));
            list.Add(new card("Herts 4", "h", 4));
            list.Add(new card("Herts 3", "h", 3));
            list.Add(new card("Herts 2", "h", 2));

            list.Add(new card("Dice A", "d", 14));
            list.Add(new card("Dice K", "d", 13));
            list.Add(new card("Dice Q", "d", 12));
            list.Add(new card("Dice J", "d", 11));
            list.Add(new card("Dice 10", "d", 10));
            list.Add(new card("Dice 9", "d", 9));
            list.Add(new card("Dice 8", "d", 8));
            list.Add(new card("Dice 7", "d", 7));
            list.Add(new card("Dice 6", "d", 6));
            list.Add(new card("Dice 5", "d", 5));
            list.Add(new card("Dice 4", "d", 4));
            list.Add(new card("Dice 3", "d", 3));
            list.Add(new card("Dice 2", "d", 2));

            list.Add(new card("clubb A", "c", 14));
            list.Add(new card("Club K", "c", 13));
            list.Add(new card("Club Q", "c", 12));
            list.Add(new card("Club J", "c", 11));
            list.Add(new card("Club 10", "c", 10));
            list.Add(new card("Club 9", "c", 9));
            list.Add(new card("Club 8", "c", 8));
            list.Add(new card("Club 7", "c", 7));
            list.Add(new card("Club 6", "c", 6));
            list.Add(new card("Club 5", "c", 5));
            list.Add(new card("Club 4", "c", 4));
            list.Add(new card("Club 3", "c", 3));
            list.Add(new card("Club 2", "c", 2));

            st1 = new Stack<card>();
            st2 = new Stack<card>();
            st3 = new Stack<card>();
            st4 = new Stack<card>();

            st1.Push(new card("!", "n", 1));
            st2.Push(new card("!", "n", 1));
            st3.Push(new card("!", "n", 1));
            st4.Push(new card("!", "n", 1));


            dealcard();
            print();



        xxx: x = Convert.ToInt32(Console.ReadLine());



            if (x == 1)
            {
                if (list.Count > 0)
                {
                    dealcard();
                }
                Console.Clear();
                print();

                goto xxx;
            }
            else if (x == 2)
            {
                Console.Write("Slot no :");
                discard();


                Console.Clear();
                print();
                goto xxx;
            }
            else if (x == 3)
            {


                Console.Write("From Slot :");
                o = Convert.ToInt32(Console.ReadLine());


                Console.Write("To Slot :");
                p = Convert.ToInt32(Console.ReadLine());

                move(o, p);
                Console.Clear();
                print();
                goto xxx;



            }
            else if (x == 4)
            {
                Console.Clear();
                Console.Beep(3000, 50);


                goto yyy;

            }
            else if (x == 5)
            {

            }
            else
            {
                Console.Clear();
                print();
                goto xxx;
            }








            Console.ReadKey();





        }
    }
}
