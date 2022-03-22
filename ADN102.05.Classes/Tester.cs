using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ADN102._05.Classes
{
    class Tester
    {

        public static void T_P04()
        {
            string success = "Succeeded.";
            Page4.Color c;
            c = new Page4.Color();
            var r = c.GetType().GetField("Red"); 
            var g = c.GetType().GetField("Green"); 
            var b = c.GetType().GetField("Blue"); 
            var o = c.GetType().GetField("Opacity");
            if (r == null)
            {
                Console.WriteLine("I could not find a public field called Red");
                 success = "Failed.";
            }
            if (g == null)
            {
                Console.WriteLine("I could not find a public field called Green");
                success = "Failed.";
            }
            if (b == null)
            {
                Console.WriteLine("I could not find a public field called Blue");
                success = "Failed.";
            }
            if (o == null)
            {
                Console.WriteLine("I could not find a public field called Opacity");
                success = "Failed.";
            }
            r?.SetValue(c,20);
            g?.SetValue(c, 30);
            b?.SetValue(c, 255);
            o?.SetValue(c,128);
            
          
            Console.WriteLine($"I created a color with Red = 20 Blue = 255 Green=30 and Opacity=128");
            Console.WriteLine($"I see a color with Red = {r?.GetValue(c)} Blue = {b?.GetValue(c)} Green={g?.GetValue(c)} and Opacity={o?.GetValue(c)}");
            Console.WriteLine(success);

        }

        public static void T_P08()
        {
            string success = "Succeeded.";
            Page8.Color c;
            c = new Page8.Color();

            var c1 = c.GetType().GetConstructor(new Type[] { typeof(int) });
            var c3 = c.GetType().GetConstructor(new Type[] { typeof(int), typeof(int) , typeof(int) });
            var c4 = c.GetType().GetConstructor(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) });
            if  (c1==null) 
                    {
                Console.WriteLine("I do not see the ctor with one integer parameter...");
                success = "Failed";
            }
            if (c3 == null)
            {
                Console.WriteLine("I do not see the ctor with three integer paramaters...");
                success = "Failed";
            }
            if (c3 == null)
            {
                Console.WriteLine("I do not see the ctor with four integer paramaters...");
                success = "Failed";
            }
            if (c.Opacity != 255)
            {
                Console.WriteLine(" the default ctor did not set opacity to 255...");
                success = "Failed";
            }
            Console.WriteLine("Creating a default color");
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}");
            c = c1?.Invoke(new object[] { 100 }) as Page8.Color;
            Console.WriteLine("Creating a Color(100) color");
            Console.WriteLine($"I created a color with Red = {c?.Red} Blue = {c?.Blue} Green={c?.Green} and Opacity={c?.Opacity}");
            c = c3?.Invoke(new object[] { 50, 100, 150 }) as Page8.Color;
            Console.WriteLine("Creating a Color(50,100,150) color");
            Console.WriteLine($"I created a color with Red = {c?.Red} Blue = {c?.Blue} Green={c?.Green} and Opacity={c?.Opacity}");
            c = c4?.Invoke(new object[] { 50, 100, 150, 200 }) as Page8.Color;
            Console.WriteLine("Creating a Color(50,100,150,200) color");
            Console.WriteLine($"I created a color with Red = {c?.Red} Blue = {c?.Blue} Green={c?.Green} and Opacity={c?.Opacity}");
            Console.WriteLine(success);
               
        }

        public static void T_P10()
        {
            string success = "Succeeded.";
            Page10.Color c;
            c = new Page10.Color();
            Console.WriteLine("Creating a default color");
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}");
            c = new Page10.Color(100);
            Console.WriteLine("Creating a Color(100) color");
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}");
            c = new Page10.Color(50, 100, 150);
            Console.WriteLine("Creating a Color(50,100,150) color");
            if (c.Red == 0)
            {
                Console.WriteLine("Red is 0 instead of 50");
                success = "Failed.";
            }
            if (c.Green == 0)
            {
                Console.WriteLine("Green is 0 instead of 100");
                success = "Failed.";
            }
            if (c.Blue == 0)
            {
                Console.WriteLine("Blue is 0 instead of 150");
                success = "Failed.";
            }
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}");
            c = new Page10.Color(50, 100, 150, 200);
            Console.WriteLine("Creating a Color(50,100,150,200) color");
            if (c.Red == 0)
            {
                Console.WriteLine("Red is 0 instead of 50");
                success = "Failed.";
            }
            if (c.Green == 0)
            {
                Console.WriteLine("Green is 0 instead of 100");
                success = "Failed.";
            }
            if (c.Blue == 0)
            {
                Console.WriteLine("Blue is 0 instead of 150");
                success = "Failed.";
            }
            if (c.Opacity == 0)
            {
                Console.WriteLine("Opacity is 0 instead of 200");
                success = "Failed.";
            }
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}");
            Console.WriteLine(success);
        }

        public static void T_P16()
        {
            string success = "Succeeded.";
            Page16.Color c;
            c = new Page16.Color();
            var r = c.GetType().GetProperty("Red");
            var g = c.GetType().GetProperty("Green");
            var b = c.GetType().GetProperty("Blue");
            var o = c.GetType().GetProperty("Opacity");
            if (r == null)
            {
                Console.WriteLine("I could not find a public Property called Red");
                success = "Failed.";
            }
            if (g == null)
            {
                Console.WriteLine("I could not find a public Property called Green");
                success = "Failed.";
            }
            if (b == null)
            {
                Console.WriteLine("I could not find a public Property called Blue");
                success = "Failed.";
            }
            if (o == null)
            {
                Console.WriteLine("I could not find a public Property called Opacity");
                success = "Failed.";
            }

            Console.WriteLine("Creating a default color<br>");
            Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}<br>");
            Console.WriteLine($"Try to set Red to 1000<br>");
            try
            {
                c.Red = 1000;
                success = "Failed.";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"The color is Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}<br>");
            Console.WriteLine("Creating a Color(-100) color<br>");
            try
            {
                c = new Page16.Color(-100);
                success = "Failed.";
                Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}<br>");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Creating a Color(50,100,1500) color<br>");
            try
            {
                c = new Page16.Color(50, 100, 1500);
                success = "Failed.";
                Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}<br>");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Creating a Color(50,100,150,2000) color<br>");
            try
            {
                c = new Page16.Color(50, 100, 150, 2000);
                if (c.Opacity > 255)
                {
                    Console.WriteLine("The Opacity was allowed to go over 255.  Failed.");
                    success = "failed.";
                }
                Console.WriteLine($"I created a color with Red = {c.Red} Blue = {c.Blue} Green={c.Green} and Opacity={c.Opacity}<br>");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(success);
        }

        public static void T_P23()
        {
            try
            {
                Console.WriteLine("Creating a deck of cards<br>");
                for (int i = 0; i < 52; i++)
                {
                    if (0 == i % 13)
                    {
                        Console.WriteLine("<br>");
                    }
                    Page23.Card c = new Page23.Card(i);
                    c.Flip();
                    Console.Write(c);
                    Console.Write(' ');
                }



                Page23.Card[] cards = new Page23.Card[]
                {
                    new  Page23.Card(12,2,false),
                    new  Page23.Card(4,1,false),
                    new  Page23.Card(4,3,false),
                    new  Page23.Card(0,0,true),
                    new  Page23.Card(4,0,true)

                };
                Console.WriteLine();
                Console.WriteLine("<br>Testing an array of cards: (12,2,false), (4,1,false), (4,3,false) , (0,0,true) and (4,0,true)<br>");

                foreach (Page23.Card c in cards)
                {
                    Console.Write(c);
                    Console.Write(' ');
                    c.Flip();
                }
                Console.WriteLine("<br>Flipping them.<br>");
                foreach (Page23.Card c in cards)
                {
                    Console.Write(c);
                    Console.Write(' ');
                    c.Reveal();
                }
                Console.WriteLine("<br>Revealing them.<br>");
                foreach (Page23.Card c in cards)
                {
                    Console.Write(c);
                    Console.Write(' ');
                    c.Flip();
                }
                Console.WriteLine("<br>Flipping them again.<br>");
                foreach (Page23.Card c in cards)
                {
                    Console.Write(c);
                    Console.Write(' ');

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"<br>{ex}<br>");
            }
        }

        public static void T_P24()
        {
            string success = "Success...";
            string full = "";
            Page24.Person person = new Page24.Person();
            Type t = person.GetType();
            var fn = t.GetProperty("FirstName");
            if (fn == null)
            {
                Console.WriteLine("I am not seeing the property FirstName");
            }
            var ln = t.GetProperty("LastName");
            if (ln == null)
            {
                Console.WriteLine("I am not seeing the property LastName");
            }
            var fulln = t.GetProperty("FullName");
            if (fulln == null)
            {
                Console.WriteLine("I am not seeing the property FullName");
            }
          
            try
            {
                fn?.SetValue(person, "Sally");
                ln?.SetValue(person, "Sue");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                success = "Failure...";
            }
            try
            {
                fulln?.SetValue(person, "failure");
                if (fulln != null)
                {
                    Console.WriteLine("failure: FullName is supposed to be read only");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                success = "Failure...";
            }
            try
            {
                full = fulln?.GetValue(person) as string;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                success = "Failure...";
            }
            if (full == "failure: FullName is supposed to be read only")
            {
                Console.WriteLine("Failure: Not Read Only");
            }
            else if (full == "Sally Sue")
            {
                Console.WriteLine("Success. You did it!");
            }
            else if (full == "SallySue")
            {
                Console.WriteLine("Almost! It seems you forgot a space.");
            }
            else
            {
                Console.WriteLine("I'm not seeing the correct results for 'FullName'. Are you concatenating the first and last names with a space in between?");
            }
        }

      




        
        

    }
}
    

