This is a library intended to simplify making REST API calls. There are two possible ways of using it.

The first is the original, more simple manner. Create a new class that inherits from one of the "Endpoint" classes. These are named per the Http VERB they are used for, and have variants depending on the request and response types:

- GetEndpoint
- PostEndpoint
- PutEndpoint
- PatchEndpoint
- DeleteEndpoint
