using System;

namespace WebApp
{
	// The class name follows the pragma objectName+"Response"
	// NB: The class name will appear in the response.
	public class ExampleObjectsResponse
	{
		// Note the intentional use of Pascal Case in the variable name here.
		// This is because it's also reflected in the response.
		public ExampleObject[] ExampleObjects;
	}
}

