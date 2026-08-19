## Background service

## This is an example on how to implement a background worker service

A background service is a service that keeps running in a separate thread from the host's main thread.
It's commonly used on pub/sub consumers to stay "listening" for an specific event or a condition that will trigger the serices execution.

## What this example will do?

I'll have in the host's main thread writint a '#' character into the output console each second.

The worker service will wait 10 seconds and add a new line the console screen.


## Important
BackgroundService is dependent on Microsoft.Extensions.Hosting
So it's necessary to add the nuget package:
` dotnet add package Microsoft.Extensions.Hosting `

In Program.cs you can see that the hos.RunAsync() method is not awaited, this is what "unblocks" the main thread to continue to the loop that writes the '#' character.
If we add the await to it, then the loop is treated as continuation and only the hosted serice runs.
