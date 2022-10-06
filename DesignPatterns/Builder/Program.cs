using System.Text;

var builder = new CarBuilder();
builder.AddEngine()
    .AddColor("White")
    .AddDoor()
    .Build();

//StringBuilder follows Builder Pattern
var stringBuilder = new StringBuilder();
var message = stringBuilder.Append("Hello ")
    .Append("Nayeem").ToString();
Console.WriteLine(message);