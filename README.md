This is a library intended to simplify making REST API calls. There are two possible ways of using it.

##Simplified
The first is the original, more simple manner. Create a new class that inherits from one of the "Endpoint" classes. These are named per the Http VERB they are used for, and have variants depending on the request and response types:

- GetEndpoint
- PostEndpoint
- PutEndpoint
- PatchEndpoint
- DeleteEndpoint

Each endpoint type has sub-variants that may be used, dependant on the number of request and / or response types. An example endpoint for a POST with a user defined request type of "TestRequest" & a response type of "TestResponse" would be:

```
public class TestPostEndpoint : PostEndpoint<TestRequest, TestResponse>
{
    public TestPostEndpoint(string hostName, string endpoint)
    : base(hostName, endpoint) { }
}
```

##Enhanced
An enhanced functionality version switches the base classes to the following:
- AuditableGetEndpoint
- AuditablePostEndpoint
- AuditablePutEndpoint
- AuditablePatchEndpoint
- AuditableDeleteEndpoint


Again, each endpoint type has sub-variants that may be used, dependant on the number of request and / or response types. An example endpoint for a POST with a user defined request type of "TestRequest" & a response type of "TestResponse" would be:

```
public class TestPostEndpoint : AuditablePostEndpoint<TestRequest, TestResponse>
{
    public TestPostEndpoint(string hostName, string endpoint)
    : base(hostName, endpoint) { }
}
```

##Difference
The simplified system attempts to return an object of type "TestResponse": if the response form the server cannot be deserialised to the target type, an "ApiCallException" is throw that contains the details of the problem.
The enhanced system will always return an ""
