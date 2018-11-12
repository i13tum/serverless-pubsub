# serverless-pubsub
A Serverless Approach to Publish/Subscribe Systems

Pre-requisites
1. .NET Core https://code.visualstudio.com/tutorials/functions-extension/run-app
2. VSCode https://code.visualstudio.com
3. Nodejs npm https://nodejs.org/en/download/
4. C# Extension for VSCode https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp

Azure Functions:
1. Create account on Azure and login (http://portal.azure.com)
2. Create Service Bus resource (https://docs.microsoft.com/en-us/azure/service-bus-messaging/)
2.a. Select options (pricing tier, location, etc.)
2.b. Create a new resource group (or use existing one if any)
2.c. Once Service Bus is created, get 'Primary Key' and 'Connection String' from 'Shared Access Policies'
3. Create Function App
3.a. Use existing resource group (2.a)
3.b. Create a new storage group (or use existing one if any)
3.c. Select options (pricing tier, location, etc.)
4. Upload functions code to cloud using vscode/visual studio

AWS Lambdas:
1. Create account on AWS and login (https://aws.amazon.com/)
2. Get 'Access ID Key' and 'Secret Access Id'
3. Upload functions to AWS using Access ID key and Secret Access Id
4. Create API Gateway and assign endpoints to lambdas
