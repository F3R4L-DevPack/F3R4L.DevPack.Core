This is a library intended to simplify making REST API calls. There are two possible ways of using it.

## Simplified

The first is the original, more simple manner. Create a new class that inherits from one of the "Endpoint" classes. These are named per the Http VERB they are used for, and have variants depending on the request and response types:

- GetEndpoint
- PostEndpoint
- PutEndpoint
- PatchEndpoint
- DeleteEndpoint

Each endpoint type has sub-variants that may be used, dependant on the number of request and / or response types. An example endpoint for a POST with a user defined request type of "TestRequest" & a response type of "TestResponse" would be:

<details>
<summary>Example</summary>
    
```
public class TestPostEndpoint : PostEndpoint<TestRequest, TestResponse>
{
    public TestPostEndpoint(string hostName, string endpoint)
    : base(hostName, endpoint) { }
}
```

</details>

## Enhanced

An enhanced functionality version switches the base classes to the following:
- AuditableGetEndpoint
- AuditablePostEndpoint
- AuditablePutEndpoint
- AuditablePatchEndpoint
- AuditableDeleteEndpoint


Again, each endpoint type has sub-variants that may be used, dependant on the number of request and / or response types. An example endpoint for a POST with a user defined request type of "TestRequest" & a response type of "TestResponse" would be:

<details>
<summary>Example</summary>
    
```
public class TestPostEndpoint : AuditablePostEndpoint<TestRequest, TestResponse>
{
    public TestPostEndpoint(string hostName, string endpoint)
    : base(hostName, endpoint) { }
}
```

</details>

## Differences

The simplified system attempts to return an object of type "TestResponse": if the response form the server cannot be deserialised to the target type, an "ApiCallException" is throw that contains the details of the problem.
The enhanced system will always return an "AuditContainer":

<details>
    
<summary><bold>AuditContainer</bold></summary>
    
```
    public class AuditContainer
    {
        public string Url { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ResponseMessage { get; set; }
    }
```

- Url: The full URL of the request made
- StatusCode: The HttpStatusCode returned by the server
- ErrorMessage: If the request failed, this will contain the error message returned by the server
- ResponseMessage: If the request failed, this will contain the response message returned by the server
</details>

<details>
    
<summary><bold>AuditContainer&lt;T&gt;</bold></summary>
    
```
    public class AuditContainer<T>
    {
        public string Url { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ResponseMessage { get; set; }
        
        public ObjectContainer<T> Request { get; set; }
        public ObjectContainer<T> Response { get; set; }
    }
```

- Url: The full URL of the request made
- StatusCode: The HttpStatusCode returned by the server
- ErrorMessage: If the request failed, this will contain the error message returned by the server
- ResponseMessage: If the request failed, this will contain the response message returned by the server
- Request: An ObjectContainer containing the request object and the actual JSON string that was sent
- Response: An ObjectContainer containing the response object and the actual JSON string that was received

Only one of the Request or Response properties will be populated, depending on the type of endpoint used.
</details>

<details>
    
<summary><bold>AuditContainer&lt;TIn, TOut&gt;</bold></summary>
    
```
    public class AuditContainer<TIn, TOut>
    {
        public string Url { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public string ResponseMessage { get; set; }
        
        public ObjectContainer<TIn> Request { get; set; }
        public ObjectContainer<TOut> Response { get; set; }
    }
```

- Url: The full URL of the request made
- StatusCode: The HttpStatusCode returned by the server
- ErrorMessage: If the request failed, this will contain the error message returned by the server
- ResponseMessage: If the request failed, this will contain the response message returned by the server
- Request: An ObjectContainer containing the request object and the actual JSON string that was sent
- Response: An ObjectContainer containing the response object and the actual JSON string that was received
</details>

## Dependency Injection

To your project, add a reference to the F3R4L.DevPack.Api package. Then, in your injection container, add the following using line:

```

using F3R4L.DevPack.Api.DependencyInjection;

```

Then, add the following line to the code:

```

services.AddApiBindings();

```

## Usage

To your class, add the following using line:

```

using F3R4L.DevPack.Api.Services;

```

Then, add the following to your class constructor:

```

IApiService apiService

```

Add a private field to your class to contain the injected IApiService, which can be used to make the API calls. For example:

```

            var endpoint = new TestGetEndpoint(_baseUrl, "/get");
            var response = await _objectUnderTest.GetAsync(endpoint);

'''

When "TestGetEndpoint" derives from "GetEndpoint", the variable response will be of type "T" that you defined in the endpoint class. 
If "TestGetEndpoint" derives from "AuditableGetEndpoint", the variable response will be of type "AuditContainer<T>" that you defined in the endpoint class.