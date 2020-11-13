using System;

class Product : IComparable
{
    public string Name { get; set; }    //기본적으로 제공해주는것은 compareto를 내장 되어있다. 만든것은 없다.
    public int Price { get; set; }

    public override string ToString()
    {
        return Name + ":" + Price + "원" + "\n";
    }

    public int CompareTo(object obj)
    {
        return Name.CompareTo((obj as Product).Name);   //as는 왼쪽에 있것을 오른쪽으로 바꾼다. 
    }
}