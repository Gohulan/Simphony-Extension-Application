# Simphony-Extension-Application
Simphony .NET Extension Application is a .NET class library that adds new operations or event handlers to the Simphony POS Client
Demo Simphony extension application which will display message thorugh Simphony POS Client
How To Install a .NET Extension Application
To complete the steps below you will need

A built extension application class library (see How to Create a .NET Extension Application Project)

Access to the Extension Application and Page Designer modules in EMC

A working POS Client

Employee ID to sign-in on the POS Client

All items are configured at the Enterprise level in EMC

Configure Extension Application
Define the Extension Application

In EMC open the Extension Application module from the "Setup | Custom Content" section

Click "+" in the button menu to insert a new extension application

When prompted set name to "MyExAppTest".

Save changes.

Insert Application Content

Toggle to Form View on the Extension Application module in EMC

Click "Insert Application Content" button (to the right)

Set ZonableKey to "Application" (the ZoneableKey value must be unique for each content item added to an Extension Application).

Set Description as desired

Import the extension application class library as Extension Application Content

On the "Designer: " tab change Content Type to "3 - DLL"

Click on the "Import from a file" link, and browse to and select the extension application class library

Switch to the "General" tab and enter the name of your DLL in the "Disk File Name" column of the Extension Application Contents grid

Save changes

Create button to call the "MyExtensionMethod" extension application method

In EMC open the Page Designer module from the "Configuration | User Interface" section

Add a new button to the default transaction screen and use the following values for the button

Type: Function / Run Extension Application

Arguments: Type=DLL;AppName=MyExtAppTest;FileName=MyExtAppTest.dll;Function=MyExtensionMethod

Run Extension Appication Method from the POS Client

Start the POS Client Application by running ServiceHost.exe

Perform a "Reload Workation Database" operation to update the worktation with latest configuration

Restart the POS Client Application so the new extension application can be loaded (this is only done at start up)

Click on button added above to invoke the "MyExtensionMethod" extension method and a pop-up message from the extension application is displayed

After the workstation is restarted, the extension application class library should be written to disk in the WebServer\wwwroot\EGateway\Handlers\ExtensionApplications\MyExtAppTest folder
