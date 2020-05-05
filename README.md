# UVSproject
Setupping a project locally
Find a location for project
git clone https://github.com/karolisrutkauskas/ICSS-Devbridge-Calendar-Server
Open project in Visual Studio. Make sure your Visual studio has all required tools and features installed such as "ASP.NET and web development", "Data storage and processing", 4.7.2 .NET Framework.
Solution 'DevBridgeAPI' -> Restore NuGet packages.
Open Package Manager Console, paste and run this command:
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
Solution 'DevBridgeAPI' -> Build
Now you need to create your local database and publish *.sql files located at database project. DevBridgeDB project -> Publish. Click 'Edit' as shown in image. If "Data storage and processing" is installed you should have active database server something like "(localdb)\MSSQLLocalDB" - select it from the list. Set Database Name to your own liking and click 'Ok'. Then clisk button "Load values". Than near variable "UseTestData" will show up value "false". If you want to load test data into database tables change to "true", otherwise keep "false". Then click button 'Publish'. You can optionally create a profile for easy click-to-publish script. Publishing database
Finally, link DevBridgeAPI project with your newly created database by modifying Web.Config file. Locate this snippet (insert if its not there):
<connectionStrings>
    <add name="DevBridgeDB" connectionString="Server=<server name>;Database=<database name>;Trusted_Connection=True;" />
</connectionStrings>
and modify 'connectionString' attribute by copying your own server and database names similarly how its displayed in this image:

Server with database names

Run the project and test the API with ./help and ./api/users (should return an empty list)
