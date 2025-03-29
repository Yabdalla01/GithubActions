namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
    		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", (string?)null));
    		Assert.ThrowsException<ArgumentNullException>(() => Program.Add((string?)null, "1"));
    		Assert.ThrowsException<ArgumentNullException>(() => Program.Add((string?)null, (string?)null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Patino()
	{
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(5, Program.Subtract("10", "5"));
		Assert.AreEqual(-2, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", (string?)null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract((string?)null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract((string?)null, (string?)null));
	}
}

[TestClass]
public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Patino()
	{
		Assert.AreEqual(6, Program.Multiply("2", "3"));
		Assert.AreEqual(0, Program.Multiply("0", "5"));
		Assert.AreEqual(-10, Program.Multiply("-2", "5"));
	}

	[TestMethod]
	public void Multiply_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", (string?)null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply((string?)null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply((string?)null, (string?)null));
	}
}

[TestClass]
public class Division
{
	[TestMethod]
	public void Divide_Valid_Patino()
	{
		Assert.AreEqual(2, Program.Divide("6", "3"));
		Assert.AreEqual(0, Program.Divide("0", "5"));
		Assert.AreEqual(-2, Program.Divide("-10", "5"));
	}

	[TestMethod]
	public void Divide_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", (string?)null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide((string?)null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide((string?)null, (string?)null));
	}

	[TestMethod]
	public void Divide_ByZero_Patino()
	{
		Assert.ThrowsException<DivideByZeroException>(() => Program.Divide("5", "0"));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Patino()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("5", "0"));

		// Intentional failure: 2^-2 should be 0.25, but I'm asserting 0.5 instead
		Assert.AreEqual(0.5, Program.Power("2", "-2")); 
	}

	[TestMethod]
	public void Power_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", (string?)null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power((string?)null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power((string?)null, (string?)null));
	}
}
