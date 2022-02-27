using System;
namespace Heritage
{
    class hello
    {
        public string name;
            public void Getdata(string name)
        {
            this.name = name;
            Console.WriteLine("hello "+this.name);
        }
    }
    class hello2 : hello
    {
        public void data() { 
        
        }
    }
     class program
    {
        static void Main(string[] arg)
        {
            hello2 obj1 = new hello2();
            obj1.Getdata("aaa");
           
        }
    }

}