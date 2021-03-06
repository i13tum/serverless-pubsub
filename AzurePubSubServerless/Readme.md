#Setup Cloud Resources:
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

#Deployment:
1. Install Vscode (https://code.visualstudio.com), nodejs and npm (https://nodejs.org/en/download/)
2. Install Azure Functions Core tools (npm install -g azure-functions-core-tools@core)
3. Install Azure Functions extension (https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions)
4. Login to Azure in Vscode
5. Update StorageConnectionString and ServiceBusConnectionString in Common.cs
6. Compile functions and run it locally (https://code.visualstudio.com/tutorials/functions-extension/run-app)
7. Upload functions to Azure (https://code.visualstudio.com/tutorials/functions-extension/deploy-app)
