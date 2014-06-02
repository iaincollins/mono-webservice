<%@ Page Language="C#" Inherits="WebApp.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>C# Web Service Example</title>
</head>
<body style="font-family: sans-serif;">
	<h1>C# Web Service Example</h1>
	<p>This is an example of a cross platform web service that provides SOAP Document/Literal Wrapped service (as well as simple XML/JSON over REST).</p>
	<p>It's written in written in C# (using Mono/Xamarin Studio), the services are self documenting and it interoperates really with well with other languages (PHP, Ruby, Java, JavaScript, etc). In languages like Java and PHP it works great with the built in SOAP client.</p>
	<p>It's cross platform and runs on Windows, Mac, Linux and other UNIX platforms. The class libraries used can be shared between desktop, server, mobile (including iOS and Android) and console platforms.</p>
	<p><a href="http://127.0.0.1:8080/ExampleService.asmx">View the webservice</a></p>
	<p><strong>Note:</strong> The format for the SOAP responses is the (excellent) <strong>SOAP Document/Literal Wrapped</strong> format and not an (evil) <strong>SOAP RPC</strong> variant.</p>
	<p>
		Despite the latter being deprecated for a decade it's still what people tend to think of when someone mentions SOAP.
		This misunderstanding tends to induce OMGWATNOES responses in people who've previously encountered SOAP RPC, which is a shame as they are missing out
		(and probably writing a lot of boiler plate code they wouldn't have to if they were using C#).
	</p>
	<p>
	  You can also enable JSON over REST, although (as with XML over REST) you won't get the benifits of automagic server-to-client exception handling and type safety. 
	  As with most things, it's very dependant on the use case at hand. Sometimes these things matter, sometimes they don't.
	</p>
	<h2>What's the purpose of this example?</h2>
	<p>I've used C# and Xamarin/Mono to write and deploy services on Mac, Windows, Linux, BSD and Solaris while at TalkTalk, AOL and UK Online.</p>
	<p>I've consumed these services from PHP, Perl, browser based JavaScript, desktop apps in C# and C++, xojo (formerly RealStudio) and other scripting languages.</p>
	<p>Being a fan of the platform - and as someone sad to see it maligned through misunderstanding and by people who've only ever encountered badly mangled .NET services -
	 I thought I'd get round to uploading an example of how simple it is, so I have something to point people at.</p>
	<p>
	I've included some examples of sane ways to handle returning objects and input validation to create WSI compliant responses and to show how to handle errors.
	I've no idea why people manage to return objects incorrectly via SOAP given how easy it is to get right, but it's a common problem.
	</p>
	<p>If you're doing cross platform development and you're not using Xamarin/Mono you might be missing out.</p>
	<p>The <a href="http://www.xamarin.com">Xamarin Studio IDE is pretty awesome</a> these days and well worth checking out.</p>
	<p><em>-- feedback via <a href="mailto:me@iaincollins.com">me@iaincollins.com</a> or <a href="http://twitter.com/iaincollins">@iaincollins</a> welcome, as are <a href="https://github.com/iaincollins">pull requests</a>!</em></p>
</body>
</html>