using System;

namespace WebApp
{
	public class InputValidationException : Exception
	{

		public InputValidationException()
		{
		}

		public InputValidationException(string message) : base(message)
		{
		}

		public InputValidationException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}

