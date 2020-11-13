using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _IComparable_
{
    class Program
    {
        static void Main(string[] args)
        {

            Artists[] famousAritists ={new Artists("레오나르도 다빈치", "이탈리아",1452,1519),
                                       new Artists("빈센트 반 고흐", "네덜란드", 1853, 1890),
                                       new Artists("클로드 모네", "프랑스", 1840, 1926),
                                       new Artists("파블로 피카소", "스페인", 1881, 1973),
                                       new Artists("베르메르", "네덜란드", 1632, 1675),
                                       new Artists("르노아르", "프랑스", 1841, 1919)};

            List<Artisis> artists19c = new List<Artisis>();
            foreach (var artist in famousAritists)
	        {
            if (artist.Birth > 1800 && artist.Birth)
	        }

        }
    }
}
