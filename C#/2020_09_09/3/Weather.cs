class Weather
{
    public string Hour { get; set; }
    public string Temp { get; set; }
    public string Wfkor { get; set; }
    public string Wdkor { get; set; }

    public override string ToString()
    {
        return Hour + "시\t" + Temp + "℃\t" + Wfkor + "\t" + Wdkor + "풍\t";
    }
}