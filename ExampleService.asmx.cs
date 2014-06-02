
/// <summary>
/// An example web service written in C#.
/// System.Web.Script.Services and [ScriptService] tags optionally enable JSON (as well as SOAP/REST).
/// </summary>
namespace WebApp
{
	using System;
	using System.Web;
	using System.Web.Services;
	using System.Web.Script.Services;
	using System.Collections.Generic;

	[WebService(Namespace = "http://www.example.org/", Description = "Example web service in C#")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ScriptService]
	public class ExampleService : System.Web.Services.WebService
	{

		[WebMethod(Description = "Echos back a string")]
		[ScriptMethod(UseHttpGet = false, ResponseFormat = ResponseFormat.Json)]
		public string echoString(String testString)
		{
			// An example of a pragma for throwing an exception for invalid input
			// NB: You will still get basic type error handling even if you don't do this!
			// "InputValidationException" is a commonly used pragma for input handling in .NET
			if (testString.Length < 1)
				throw new InputValidationException("The input string must be at least one character");

			return testString; 
		}

		[WebMethod(Description = "Adds two numbers together and returns an integer")]
		public int addNumbers(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber; 
		}

		[WebMethod(Description = "Returns an object")]
		public ExampleObject getExampleObject()
		{
			ExampleObject exampleObject = new ExampleObject();
			exampleObject.exampleNameValue = "John Smith";
			exampleObject.exampleNumberValue = 123;
			return exampleObject;
		}

		[WebMethod(Description = "Returns an array of objects (aka Complex Types)")]
		public ExampleObjectsResponse getExampleObjects()
		{
			// Using a List and converting it to an array later is not
			// required, it's just useful if you don't know how many
			// items you'll be returning.
			List<ExampleObject> listOfExampleObjects = new List<ExampleObject>();

			ExampleObject exampleObject1 = new ExampleObject();
			exampleObject1.exampleNameValue = "John Smith";
			exampleObject1.exampleNumberValue = 123;
			listOfExampleObjects.Add(exampleObject1);

			ExampleObject exampleObject2 = new ExampleObject();
			exampleObject2.exampleNameValue = "Jane Doe";
			exampleObject2.exampleNumberValue = 456;
			listOfExampleObjects.Add(exampleObject2);

			// You can return a response without a wrapper object,
			// in this case we are using ExampleObjectsResponse,
			// but it means your response XML will be WSI compliant.
			ExampleObjectsResponse response = new ExampleObjectsResponse();
			response.ExampleObjects = listOfExampleObjects.ToArray();

			return response;
		}
	}
}


