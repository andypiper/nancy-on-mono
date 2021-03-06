using System;
using Nancy;
using Nancy.Hosting.Aspnet;

namespace nancyTest
{
	public class HelloModule : NancyModule
	{
		public HelloModule ()
		{
			Get ["/"] = parameters => "Hello World";
		
			Get ["/hello/{name}"] = parameters => {
				return "Hello " + parameters["name"];
			};

		}
	}
}

