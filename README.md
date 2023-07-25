
Windows Desktop Application

I had some time in the weekend so I decided to take an API which I have encountered in during the semester, and decided to implement a simple Desktop Application that is fetching data from this API and presenting it to the user.
This App was made in C# in Visual Studio 2019 Enviornment.
Enjoy!

The mentioned API - OpenSky REST API
https://openskynetwork.github.io/opensky-api/rest.html



## Screenshots

1. Choose search criteria (Airport/Aircraft)

![App Screenshot]("./Images/choice.jpg")

2. Choose from the airports list or write an aircraft in icao24 format

Airport
-Please note that some airports suggested are not actually available to search,
try looking for known airports worldwide.
![App Screenshot]("./Images/airports list.jpg")

Aircraft
There is a need to enter the icao24 code of an aircraft.
Examples: 3c675a, 4c808e, 73806a

3. Fill in the date range

4. Click on "Fetch Data" and all Flights will be shown (if found)

![App Screenshot]("./Images/flights data.jpg")
