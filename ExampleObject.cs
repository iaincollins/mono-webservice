using System;

namespace WebApp
{
	public class ExampleObject
	{
		// The properties you want to expose in an object called
		// via your webservice should be public.
		//
		// Alternatively you could write a method to handle serilization.
		public string exampleNameValue;
		public int exampleNumberValue;

		// You can return arrays of anything (primative data types and objects)
		// as properties.
		//
		// There are some issues with structs and strict WSI compliance so it's
		// better to stick to primative objects if you need complex types.
		public int[] exampleArrayOfValues;
	}
}

