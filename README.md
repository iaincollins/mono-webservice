mono-webservice
===============

An example web service in C# - works in .NET/Xamarin/Mono on Windows, Mac & Linux.

# C# Web Service Example

This is an example of a cross platform web service that provides SOAP Document/Literal Wrapped service, as well as simple XML/JSON over REST.

It's written in written in C# (using Mono/Xamarin Studio), the services are self documenting and it interoperates really with well with other languages (PHP, Ruby, Java, JavaScript, etc). In languages like Java and PHP it works great with the built in SOAP client.

It's cross platform and runs on Windows, Mac, Linux and other UNIX platforms. The class libraries used can be shared between desktop, server, mobile (iOS and Android) and console platforms.

Note, when we talk about SOAP here I'm referring to the (excellent, highly interoperable) **SOAP Document/Literal Wrapped** format and not an the long deprecated (and rightly maligned) **SOAP RPC** format which is quite a different format.

Despite the latter being deprecated for over a decade it's still often what people tend to think of when someone mentions SOAP as it was for many their first and only exposure to it. This misunderstanding tends to induce negative responses in people who've previously encountered SOAP RPC, which is a shame as they are missing out - and they probably writing a lot of boiler plate code they wouldn't have to if they were using C#.

You can also enable JSON over REST, although (as with simple XML over REST) you won't get the benifits of automagic server-to-client exception handling and type safety. As with most things, it's very dependant on the use case at hand as to if you need that level of robustness in error handling and type checking in your client to server communications.

##What's the purpose of this example?

I've used C# and Xamarin/Mono to write and deploy services on Mac, Windows, Linux, BSD and Solaris at several jobs in the past - including while working at the BBC, AOL and Sky, which were all mixed platform environments.

I've consumed these services from C#, C++, Java, JavaScript, PHP, Perl, C++ in xojo (formerly RealStudio) and other scripting languages.

Many if not most of the deployed .NET services I've seen in production have been pretty badly managled - even though it's quite straight forward to get it right, especially if you are using something like Visual Studio to create them. I thought I'd get round to uploading an example it is to write a good service as a reference point.

I've included some examples of sane ways to handle returning complex objects, how to do input validation, how to create WSI compliant responses and some examples of how best to handle errors.

As I update this for 2017, SOAP Document/Literal Wrapped still remains best supported on C# - largely thanks to Microsoft, the first initial proponents of the format and of course of C#. Using C# with .NET or Mono generates clients that are highly interoperable with other platforms and languages. Remarkably, there still isn't anything that's quite comparible for building services (using XML or JSON) in any other language.

If you're doing cross platform development for web services - especially for robust or enterprise web service services - and you're not using Xamarin/Mono for them you might be missing out. It might not seem an obvious choice if your stack is normally something like Java, Node.js, Ruby, PHP or even Go or Rust, but if your work revolves around building well defined, type safe web services with robust exchange of data - especially passing objects between systems - then it's strongly worth considering as it's a remarkable platform.

##Alternatives

Both [JSON API](http://jsonapi.org) and [JSON Schema](http://json-schema.org) can be combined to similarly define services and APIs that use JSON, although (sadly) they are not quite as complete in scope and there are currently no tools which create generate auto-documenting, robust services from code in the same manner (though there is software that does some of the work).

In Java you can use the [Java API for XML Web Services (JAX-WS)](https://jax-ws.java.net) to create SOAP services. Other alternatives for Java include [Apache CXF](https://cxf.apache.org) and [Apache Axis2](https://axis.apache.org/axis2/java/core/). Currently all of these (and simlar) options for Java have their own quirks and compatiblity isusues that cause interoperability problems when consuming them from different clients.

As someone who doesn't use C# day to day this is frustrating, but that's where we are.

##Feedback

Feedback via me@iaincollins.com or via Twitter via [@iaincollins](http://twitter.com/iaincollins) is welcome, as are pull requests.
