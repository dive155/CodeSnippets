//lambda expression: (/*input parameters*/) => { /*method logic*/ };

public delegate int SomeMethod (int i);

class Foo
{
	
	void Start()
	{
		//anonymous lambda
		SomeMethod op = delegate(int num) { return num + 1;};
		int i = op(3); //returns 4
		
		//same, but with lambda:
		op = (int num) => { return num + 1; } ;
		i = op(3); //returns 4
	}
	
}