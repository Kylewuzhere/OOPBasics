using OOPBasics;
using OOPBasics.PointsAndLines;
using PointAndLines;

class EntryPoint
{
	static void Main() // main method
	{
		User user = new("Kyle", "20", Race.Human); // creates instance of the Point object with 5 and 3 as required parameters
		Console.WriteLine(user.ID);
		User user2 = new("Emrys", "304", Race.Elf);

		user.SayMyName();

		Utilities.ColorfulWriteLine(user.Username, ConsoleColor.Magenta);


		Console.WriteLine(user.ID);
		Console.WriteLine(user2.ID);
		Console.WriteLine(User.currentID);
		Console.WriteLine(user.HEIGHT);
		Console.WriteLine(user2.HEIGHT);
		Console.WriteLine(user.race);
	}
}