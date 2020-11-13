using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_15
{
    class Box
    {
        //변수
        private int width;
        private int height;

        //생성자
        public Box(int width,int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("넓이와 높이는 자연수로 초기화 해주세요");
            }

        }
        //인스턴스 메서드
        public int Area()
        {
            return this.width * this.height;
        }

        //겟터(Getter)
        public int GetWidth()
        {
            return width;
        }
        public int GetWight()
        {
            return height;
        }
        //셋터(Setter)
        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("너비는 자연수를 입력");
            }
        }

        public void SetHeight(int height)
        {
            if (width > 0)
            {
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비는 자연수를 입력");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
