# Fellowship One API Csharp Wrapper #
Communicating with a REST api that implements oauth can be a tedious process to set up. This pattern hopes to make that process easier. You do not have to have knowledge on how to create a signed oauth request. Just follow the simple instructions.

## Authorization ##
First we will authorize and gain an access token. This assumes the consumer application is 1st or 2nd party. Create an oauthticket that will hold the consumer information and access token information.


	var ticket = new FellowshipOne.API.Model.OAuthTicket {
        	ConsumerKey = "<ConsumerKey>",
        	ConsumerSecret = "<ConsumerSecret>",
        	ChurchCode = "<ChurchCode>"
    	}

	ticket = FellowshipOne.API.RestClient.Authorize(ticket, "<username>", "<password>", <FellowshipOne.Api.LoginType>);

Lets go through each parameter in the Authorize method.

+ **username**: This will be the username given by infellowship or Fellowship One.
+ **password**: This will be the password for the above username.
+ **LoginType**: The Fellowship One API allows for two different login types, PortalUser and WeblinkUser. An enum is provided to assist with the decision.

Returning an OauthTicket object will allow you to save the data in any temporary location you like for future API calls. The client does not assume cookies or session or any other temporary storage. This allows the consumer to use the wrapper in any type of .NET application.

## Rest Client ##
A Restclient object is needed in order to communicate with the Fellowship One API through this library. Using the OauthTicket object, create a rest client and start communicating. Here is an example on how to get a person by id.

	var _restClient = new FellowshipOne.API.RestClient(ticket, isStaging: false, isDemo: false);
	var person = _restClient.PeopleRealm.People.Get(123);

That's it. A person object will be populated on successful communication with the API. An error will be thrown if any issues happened during the request.

## Run Tests ##
In order to run the tests, create a file in FellowshipOne.API.Tests called credentials.config and add the following content, filling in the blanks.

	<appSettings>
  		<add key="Consumer.Key" value="" />
  		<add key="Consumer.Secret" value="" />
  		<add key="Church.Code" value="" />
  		<add key="Username" value="" />
  		<add key="Password" value="" />
	</appSettings>

Once the file exists, open the App.config file that resides in the FellowshipOne.API.Tests folder and change the appSettings file path to the absolute path of where the credentials.config file resides.