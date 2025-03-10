//Greets user
Console.WriteLine("Hello, User");
//ask for a whole number
Console.WriteLine("Please enter a whole number to begin");
//declares the int faveNumber and assigns the entered number to it
int faveNumber = Convert.ToInt32(Console.ReadLine());
//writes a line using faveNumber
Console.WriteLine($"You entered {faveNumber} processing question...");
//ask if the user likes Monster Hunter
Console.WriteLine("Please enter true or false, Do you like Monster Hunter?");
//declares bool isTrue and assigns the reponse
bool isTrue = Convert.ToBoolean(Console.ReadLine());
//writes a line using isTrue
Console.WriteLine($"It is {isTrue} that you like Monster Hunter... Did you know that Monster Hunter Wilds comes out Feburary 28th? You should try it. :)");