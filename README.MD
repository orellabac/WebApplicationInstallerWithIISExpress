# WebApplication Installer with IISExpress Bundle

There are several scenarios when it would be helpful to have a simple installer that you can use so you can reinstall a WebApplication on another machine.
But running an ASP MVC .NET WebApplication on any machine is not that simple.
An ASP MVC.NET WebApplication requires a WebServer and the target machine might not have one. 
A solution might be to install IISExpress on that machine. An to have a Runner program that will make sure that IISExpress is started, and launch the WebSite.

This solution provides an example for that.

It is structured as follow:

* WebApplication1.csproj      (This is just a simple ASP .NET MVC App)
* WebApplication1.Runner.csproj (This is a simple console app that will start the IISExpress process and launch a browser to open the WebApplication)
* WebApplication1.Setup.csproj (This is the Wix Setup Project)
* WebApplication1.Bundle.csproj (This will an installer that will include the IISExpress installer and will launch IISExpress instalation if needed)
* 
Most of the code is based on a [post about create an installer for a WebSite using Wix](http://blog.bartdemeyer.be/2013/10/create-an-installer-for-website-with-wix-part-1/)

## Build Instructions
1. Open a command prompt
2. Navigate to the solution folder\WebApplication1.SetUp
3. From the command prompt execute:
```
      msbuild /t:Build;PublishWebsite;Harvest;WIX setup.build
```
4. In VS Build the WebApplication1.Bundle

That's it. The installer will be in `WebApplication1.Bundle\bin\Release\WebApplication1.Bundle.exe`

This is an interesting approach and can really help to package a web site for redistribution as an standalone application.
