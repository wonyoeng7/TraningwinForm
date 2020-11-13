using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public class PropertyTest
    {
        private string _name;       //RW
        private int _ReadOnly;      //R
        private int _WriteOnly;     //W
        private static int _Static;     //static
        //public string GetName();   일반적인 방법
        //public string SetName();

        ////public string GetName()
        ////{
        ////    return _name;
        ////}
        ////public string SetName(string value) 
        ////{
        ////    _name = value;
        ////}

        //public string Name  프로퍼티방법(C#에만 있다)
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}  


        public static int Static    //public static int Static 도 되고 static public int Static도 됨
        {
            get { return _Static; }
            set { _Static = value; }
        }


        public int WriteOnly
        {
            set { _WriteOnly = value; }
        }


        public int ReadOnly
        {
            get { return _ReadOnly; }
           
        }

        public string Name
        {
            get { return _name; }
            set {  _name = value; }
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            PropertyTest pt = new PropertyTest();
            pt.Name = "헬로 키티";          // Property의 set 기능 테스트 : write
            Console.WriteLine(pt.Name);    // Property의 get 기능 테스트 : read
            Console.WriteLine(pt.ReadOnly);            
            //pt.ReadOnly = 100;
            pt.WriteOnly = 100;
            //Console.WriteLine(pt.WriteOnly);    //WriteOnly은 쓰기 전용인데 읽기는 안되기에 오류가 뜸
            PropertyTest.Static = 200;
            Console.WriteLine(PropertyTest.Static);

        }
    }
}
