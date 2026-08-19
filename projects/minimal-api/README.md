# .Net Minimal API

## This is an example on how to create a very simple minimal API

The minimal API apprach is best suited for very simple REST API that doesn't need all the boilerplate code, it's lightweight and has less dependency layers.

The downside is that if it grows a little it can create a code organization issue inside your Program.cs class (or wherever the endpoints mapping is written).

### What this code actually does

Inside the Program.cs file, there's the WebApplication builder wich turns the app into a webapp host, and the mapping of the endpoints.
In this case I'm creating 5 simple routes to simulate CRUD operations
- GET all
- GET by id
- POST to create a new object
- PUT to update an object 
- DELETE to remove the object

All the operations will be manipulating in-memory data just to exemplify the use case.

Also, this contains an example of a .http file wich can be used to test the API endpoints.