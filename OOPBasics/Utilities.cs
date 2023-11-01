namespace OOPBasics
{
	static class Utilities // static class; cannot be instantiated; cannot have constructors
	{
		public static void ColorfulWriteLine(string message, ConsoleColor color) // method
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
