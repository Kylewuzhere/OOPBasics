using OOPBasics;
using OOPBasics.PointsAndLines;

namespace PointAndLines
{
	class User // OBJECT of Point CLASS
	{
		private string username; // FIELDS of Point class; camelCase
		private int password;
		private string age;

		// public and private are accesss modifiers
		// private fields are not accessible outside of class
		// public fields are accessible outside of class

		public static int currentID; // static variable; does not need an instance of User to access

		public readonly int HEIGHT; // constants require a value

		public readonly int ID; // readonly/constants prevents editing of id; capitalizedd

		public Race race;



		public string Username // PROPERTIES; PascalCase
		{
			get // gets the value of x
			{
				return "The username is " + username;
			}

			set // sets the value of x
			{
				if (value.Length >= 4 && value.Length <= 10)
				{
					username = value; // value keyword gives us access to the value; give the value of the X property to the x field
				}
				else
				{
					System.Console.WriteLine("Invalid username. Please use a username 4-10 characters long");
				}
			}
		}

		public int Password
		{
			set
			{
				if (value >= 4 && value <= 10)
				{
					password = value; // value keyword gives us access to the value; give the value of the X property to the x field
				}
				else
				{
					System.Console.WriteLine("Invalid password. Please use a password between 4-10");
				}
			} // Password is a write-only property
		}

		public string Age
		{
			get
			{
				return "The age is " + age;
			} // Age is a read-only property
		}

		public Race Race
		{
			get
			{
				return race;
			}
		}


		public User() // EMPTY CONSTRUCTOR; having both empty constructor and constructor with args lets us create Point in two ways
		{
			currentID++; // ID incremented when a new user is created/initialized 
			ID = currentID;
		}

		public User(string username, string age, Race race) // constructor that takes in ARGS; required; 
		{
			currentID++;
			ID = currentID;
			this.username = username; // this keyword gives you access to the members of the class and lets you distinguish between two variables
			this.age = age;
			this.race = race;

			if (this.race == Race.Human)
			{
				HEIGHT = 180;
			}
			else if (this.race == Race.Elf)
			{
				HEIGHT = 170;
			}
		}

		public void SayMyName()
		{
			Utilities.ColorfulWriteLine("My name is " + username, ConsoleColor.Magenta);
		}
	}
}

