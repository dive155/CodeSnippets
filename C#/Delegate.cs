public delegate float SomeMethod (int i);

class Foo
{
	
	void Start()
	{
		DoStuff(AddOne, 1337); //prints 1338
		DoStuff(SubOne, 1337); //prints 1336
		
		SomeMethod del = AddOne;
		DoStuff(del, 1337); //prints 1338
		float f = del(10); //returns 11;
	}
	
	public void DoStuff (SomeMethod method, int val)
	{
		float f = method(val);
		Debug.Log(f);
	}
	
	public float AddOne(int i)
	{
		return (float) (i + 1.0f);
	}
	
	public float SubOne(int i)
	{
		return (float) (i - 1.0f)
	}
	
}