using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page11Part1
{

    class SomeProcess
    {                                           
        private int _percentFinished;           
                                                
        public int PercentFinished              
        {                                       
            get { return _percentFinished; }    
            set                                
            {                                   
                if (value < 0)                  
                {                               
                    throw new Exception($"The value you tried to assign to PercentFinished was {value}, which is less than 0");     
                }                               
                if (value > 100)                
                {                               
                    throw new Exception($"The value you tried to assign to PercentFinished was {value}, which is greater than 100");
                }                               
                                                
                _percentFinished = value;        
                                                
            }                                  
        }                                      
    }

    class Program
    {
        public static void Main()
        {
            SomeProcess p = new SomeProcess();              
            Console.WriteLine(p.PercentFinished);          
                                                           
            p.PercentFinished = 20;                              
            Console.WriteLine(p.PercentFinished);

           
            p.PercentFinished = -2;
            
               
            Console.WriteLine(p.PercentFinished);

            
            p.PercentFinished = 101;
            
            Console.WriteLine(p.PercentFinished);           
        }
    }
    
}


namespace Page11Part2
{
    class SomeProcess 
    {                                               
        public SomeProcess()                        
        {                                           
            PercentFinished = 50;                   
        }                                           
        public SomeProcess(int initialPercentage)   
        {                                           
            PercentFinished = initialPercentage;    
        }                                           
        private int _percentFinished;               
                                                    
        public int PercentFinished                  
        {                                           
            get { return _percentFinished; }        
            init                                    
            {                                       
                if (value < 0)                      
                {                                   
                    throw new Exception($"The value you tried to assign to PercentFinished was {value}, which is less than 0");       //0020
                }                                   
                if (value > 100)                    
                {                                   
                    throw new Exception($"The value you tried to assign to PercentFinished was {value}, which is greater than 100");  //0024
                }                                   
                                                    
                _percentFinished = value;           
                                                    
            }                                       
        }                                           
    }

    class Program
    {
        public static void Main()                                              
        {                                                               
            SomeProcess p1 = new SomeProcess(20);                                   
            Console.WriteLine(p1.PercentFinished);                      
                                                                       
            SomeProcess p2 = new SomeProcess() { PercentFinished = 20 };  
                                                                        
           // p1.PercentFinished = 30;                                    
            //p2.PercentFinished = -2;                                    
                                                                        
                                                                        
            SomeProcess p3 = new SomeProcess() { PercentFinished = -2 };
            SomeProcess p4 = new SomeProcess(101);
        }
    }
}

