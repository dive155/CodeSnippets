public delegate void EventHandler();

class Foo
{
	public event EventHandler Event;
	
	void TriggerEvent()
	{
		if (Event != null)
		{
			Event();
		}
	}
}

class Bar
{
	private Foo foo;
	
	public void Subscribe
	{
		foo.Event += new EventHandler(EventDetected);
	}
	
	public void EventDetected()
	{
		Debug.Log("What");
	}
}