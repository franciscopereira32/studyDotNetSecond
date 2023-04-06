//(from https://zetcode.com/csharp/operator/)
//create a new custom object and a array of integers utilizing the new operator 
var b = new Teste(); //new operator
Console.WriteLine(b);

//array of intergers
var vals = new int[] { 1, 2, 3, 4, 5, 6}; 
Console.WriteLine(string.Join(" ", vals));

//get last caracter in dictionary
Console.WriteLine(vals[^1]);

//get last 3 characters in dictionary
var slice1 = vals[2..5];
Console.WriteLine("[{0}]", string.Join(", ", slice1));

//create a new string dictionary
var domains = new Dictionary<string, string>() 
{
    { "br", "Brazil" },
    { "sk", "Slovakia" },
    { "mx", "Mexico" }
};

Console.WriteLine(domains["br"]); 

class Teste
{
    public Teste()
    {
        Console.WriteLine("Being created");
    }
}

