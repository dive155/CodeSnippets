//Action does not return a value
//Func does return a value

//Action</*input parameters*/>
//Func</*input parameterS*/, /*output parameter*/>

class Foo
{
	
	void Start()
	{
		//anonymous lambda
		Action<int> op = (int num) => { Debug.Log(num); } ;
		op(4); //prints 4
		
		Func<int, int> fun = (int num) => { return num + 1; };
		int i = fun(3); //returns 4
		
		Func<int, int, bool> GreaterThanTwo = (int num1, int num2) => { return ((num1+num2) > 2); };
		bool b = GreaterThanTwo(1,2); //returns true
	}
	
}