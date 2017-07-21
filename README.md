# Getting started

TODO: Add a description

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (AazarKhanTelstraSMSAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the AazarKhanTelstraSMSAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

### 3. Add reference of the library project

In order to use the AazarKhanTelstraSMSAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` AazarKhanTelstraSMSAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```AazarKhanTelstraSMSAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Aazar%20Khan%20Telstra%20SMS%20API-CSharp&workspaceName=AazarKhanTelstraSMSAPI&projectName=AazarKhanTelstraSMSAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

AazarKhanTelstraSMSAPIClient client = new AazarKhanTelstraSMSAPIClient(oAuthAccessToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

## <a name="api_controller"></a>![Class: ](https://apidocs.io/img/class.png "AazarKhanTelstraSMSAPI.Tests.Controllers.APIController") APIController

### Get singleton instance

The singleton instance of the ``` APIController ``` class can be accessed from the API Client.

```csharp
APIController client = client.Client;
```

### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "AazarKhanTelstraSMSAPI.Tests.Controllers.APIController.CreateSendSMS") CreateSendSMS

> The Send SMS method sends an SMS message to a single Australian mobile phone number. A unique identifier (messageId) returned in the response, which may be used to query for the delivery status of the message.


```csharp
Task<PCL.Models.SendSMSResponse> CreateSendSMS(PCL.Models.SendSMSToBodyObject body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string bodyValue = "{  \"to\": \"\",  \"body\": \"\"}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<PCL.Models.SendSMSToBodyObject>(bodyValue);

PCL.Models.SendSMSResponse result = await client.CreateSendSMS(body);

```


### <a name="get_message_status"></a>![Method: ](https://apidocs.io/img/method.png "AazarKhanTelstraSMSAPI.Tests.Controllers.APIController.GetMessageStatus") GetMessageStatus

> Use the unique identifier (messageId) returned as returned in the response from the Send SMS method to get the status.


```csharp
Task<PCL.Models.GetMessageStatusResponse> GetMessageStatus()
```

#### Example Usage

```csharp

PCL.Models.GetMessageStatusResponse result = await client.GetMessageStatus();

```


### <a name="get_authentication"></a>![Method: ](https://apidocs.io/img/method.png "AazarKhanTelstraSMSAPI.Tests.Controllers.APIController.GetAuthentication") GetAuthentication

> To get an OAuth 2.0 Authentication token, pass through your Consumer Key and Consumer Secret that you received when you registered for the SMS API key. The grant_type should be left as ?client_credentials? and the scope as ?SMS?. The token will expire in one hour.


```csharp
Task<PCL.Models.AuthenticationResponse> GetAuthentication(
        string clientId,
        string clientSecret,
        string grantType = null,
        string scope = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| clientId |  ``` Required ```  | client's id |
| clientSecret |  ``` Required ```  | client's secret |
| grantType |  ``` Optional ```  | value set by default |
| scope |  ``` Optional ```  | value set by default |


#### Example Usage

```csharp
string clientId = "client_id";
string clientSecret = "client_secret";
string grantType = "grant_type";
string scope = "scope";

PCL.Models.AuthenticationResponse result = await client.GetAuthentication(clientId, clientSecret, grantType, scope);

```


### <a name="get_message_response"></a>![Method: ](https://apidocs.io/img/method.png "AazarKhanTelstraSMSAPI.Tests.Controllers.APIController.GetMessageResponse") GetMessageResponse

> The recipients of your SMS messages can send a reply which you can retrieve using the Get Message Response method. Pass through the unique identifier (messageId) returned as returned in the response from the Send SMS method and you will receive the reply and the timestamp.


```csharp
Task<PCL.Models.GetMessageResponse> GetMessageResponse(string mESSAGEID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mESSAGEID |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string mESSAGEID = "MESSAGE_ID";

PCL.Models.GetMessageResponse result = await client.GetMessageResponse(mESSAGEID);

```


[Back to List of Controllers](#list_of_controllers)



