using System;

public class myDate
{
	public myDate()
	{
		public string Name { get; set; }

	public int Age { get; set; }

	public string Birthdate { get; set; } }

    public myDate( string name, int age, string birthdate)
    {
        Name = name;
		Age = age;
		Birthdate = birthdate;

    }

	public string Show()
	{
		return ""; 
	}

    public override bool Equals(object? obj)
    {
        return obj is myDate @class &&
               Name == @class.Name;
    }
}
}
