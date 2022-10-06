using Prototype;

var zoombie1 = new Zoombie()
{
    Look = "Red",
    Strength = 200,
    Speed = 100,
    Health = 500
};

var zoombie2 = zoombie1.Copy();

var zoombie3 = new Zoombie()
{
    Look = "Black",
    Strength = 1000,
    Speed = 800,
    Health = 900
};

var zoombie4 = zoombie3.Clone();
Console.WriteLine(zoombie3.Look);