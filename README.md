mono-webservice
===============

An example web service in C# - works in .NET/Xamarin/Mono on Windows, Mac & Linux.

# C# Web Service Example

This is an example of a cross platform web service that provides SOAP Document/Literal Wrapped service (as well as simple XML/JSON over REST).

It's written in written in C# (using Mono/Xamarin Studio), the services are self documenting and it interoperates really with well with other languages (PHP, Ruby, Java, JavaScript, etc). In languages like Java and PHP it works great with the built in SOAP client.

It's cross platform and runs on Windows, Mac, Linux and other UNIX platforms. The class libraries used can be shared between desktop, server, mobile (including iOS and Android) and console platforms.

**Note:** The format for the SOAP responses is the (excellent) **SOAP Document/Literal Wrapped** format and not an (evil) **SOAP RPC** variant.

Despite the latter being deprecated for a decade it's still what people tend to think of when someone mentions SOAP. This misunderstanding tends to induce OMGWATNOES responses in people who've previously encountered SOAP RPC, which is a shame as they are missing out (and probably writing a lot of boiler plate code they wouldn't have to if they were using C#).

You can also enable JSON over REST, although (as with XML over REST) you won't get the benifits of automagic server-to-client exception handling and type safety. As with most things, it's very dependant on the use case at hand. Sometimes these things matter, sometimes they don't.

##What's the purpose of this example?

I've used C# and Xamarin/Mono to write and deploy services on Mac, Windows, Linux, BSD and Solaris while at TalkTalk, AOL and UK Online.

I've consumed these services from PHP, Perl, browser based JavaScript, desktop apps in C# and C++, xojo (formerly RealStudio) and other scripting languages.

Being a fan of the platform - and as someone sad to see it maligned through misunderstanding and by people who've only ever encountered badly mangled .NET services - I thought I'd get round to uploading an example of how simple it is, so I have something to point people at.

I've included some examples of sane ways to handle returning objects and input validation to create WSI compliant responses and to show how to handle errors. I've no idea why people manage to return objects incorrectly via SOAP given how easy it is to get right, but it's a common problem.

If you're doing cross platform development and you're not using Xamarin/Mono you might be missing out.

The Xamarin Studio IDE is pretty awesome these days and well worth checking out.

-- feedback via me@iaincollins.com, http://twitter.com/iaincollins welcome, as are pull requests!
