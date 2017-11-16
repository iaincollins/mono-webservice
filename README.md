# Web services in C#/Mono 

An example web service in C# - works in .NET/Xamarin/Mono on Windows, Mac and Linux.

When this document mentions SOAP (Simple Object Access Protocol) it is referring to the self documeting and highly interoperable **SOAP Document/Literal Wrapped** format and not an the deprecated - and maligned - **SOAP RPC** format, which is a different pragma.

## C# Web Service Example

This is an example of a cross platform web service that provides SOAP Document/Literal Wrapped web service.

Web services generated on Mono all have complete automatically documentation with example usage exposed as web pages on the server along with interactive examples (where you can submit structured objects via an HTML form and view the responses) and of course service descriptions (WSDL files) and URL endpoints are generated for you. The code used to create services on Mono runs without modification on .NET (although services built for .NET may not run with out modification on Mono).

This example is in written in C#, using Mono/Xamarin Studio IDE (available for Windows, Mac and Linux). The services are self documenting and interoperate really with well with other languages (Java, C+, PHP, Ruby, JavaScript, etc). In languages like Java and PHP it works great with the built in SOAP client - on platforms that don't have a SOAP client you can use simple HTTP/REST calls.

It's cross platform and runs on Windows, Mac, Linux and other UNIX platforms. The class libraries used can be shared between desktop, server, mobile (iOS and Android) and console platforms.

You can also use JSON or simple XML with REST for these methods, which is great for simple services - although then you don't get the benifits of automatic server-to-client exception propogation (where any exception on the server can bubble the same exception to the client) or the full benifits of type safety. As with most things, it's very dependant on the use case at hand as to if you need that level of robustness in error handling and type checking in your API.

## What's the purpose of this example?

I've used C# and Xamarin/Mono to write and deploy services on Mac, Windows, Linux, BSD and Solaris at several jobs in the past - including while working at the BBC, AOL and Sky, which were all mixed platform environments. I've consumed these services from C#, C++, Java, JavaScript, PHP, Perl, C++ in xojo (formerly RealStudio) and other scripting languages.

Many if not most of the deployed .NET services I've seen in production have been pretty badly managled - even though it's quite straight forward to get it right, especially if you use Visual Studio or Mono Project (from Xamarin) to create them. I thought I'd get round to uploading an example it is to write a good service as a reference point.

I've included some examples of sane ways to handle returning complex objects, how to do input validation, how to create WSI compliant responses and some examples of how best to handle errors.

As I update this for 2017, SOAP Document/Literal Wrapped still remains best supported on C# - largely thanks to Microsoft, the first initial proponents of the format and of course of C#. Using C# with .NET or Mono generates clients that are highly interoperable with other platforms and languages. Remarkably, there still isn't anything that's quite comparible for building services (using XML or JSON) in any other language.

If you're doing cross platform development for web services - especially for robust or enterprise web service services - and you're not using C#/Mono for them you might be missing out. It might not seem an obvious choice if your stack is normally something like Java, Node.js, Ruby, PHP or even Go or Rust, but if your work revolves around building well defined, type safe web services with robust exchange of data - especially passing objects between systems - then it's strongly worth considering as it's a remarkable platform.

## Alternatives

Both [JSON API](http://jsonapi.org) and [JSON Schema](http://json-schema.org) can be combined to similarly define services and APIs that use JSON, although (sadly) they are not quite as complete in scope and there are currently no tools which create generate auto-documenting, robust services from code in the same manner (though there is software that does some of the work). There are several different client libaries which all work great, however soap server libraries require quite a bit more work to create a service.

In Java you can use the [Java API for XML Web Services (JAX-WS)](https://jax-ws.java.net) to create SOAP services. Other alternatives for Java include [Apache CXF](https://cxf.apache.org) and [Apache Axis2](https://axis.apache.org/axis2/java/core/). Currently all of these (and simlar) options for Java have their own quirks and compatiblity isusues that cause interoperability problems when consuming them from different clients.

PHP's built in SoapClient works perfectly with services written in C#, you just pass the URL of the service that gets generated and you can work with the returned object as if it was a local class. The corresponding SoapServer method to create services is, unfortunately, not as sophisticated.

Thanks to the auto-docmentation, simple human-readable and restful nature, any language can consume the services easily, even if there is no native SOAP suport, just by treating it as REST/XML - although if there is a soap client for your platform it's much easier to consume.

## Feedback

Feedback via me@iaincollins.com or via Twitter via [@iaincollins](http://twitter.com/iaincollins) is welcome, as are pull requests.
