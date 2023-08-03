# Weather Station

The use of IoT technology, specifically the ESP32, allows for the development of a comprehensive weather parameter management and reporting system. Deploying IoT devices with sensors for temperature, humidity, atmospheric pressure, wind speed, and precipitation across a wide area ensures real-time data collection. This Azure IOT hub transmits the data to provide accurate weather information for individuals. Proactive decision-making becomes possible in response to changing weather conditions, optimizing irrigation and crop management for farmers and improving safety and resource utilization across various sectors. The transformative IoT-based system bridges the gap between accurate weather information and effective decision-making, enhancing resilience and efficiency in day-to-day activities.


## Features

- Live data using Websocket server
- Multiple Weather stations
- Email Alerts based on thresholds
- Easy to onboard new weather station
- Charts to view the variance and other graphical representations

## Tech

- ReactJS - HTML enhanced for web apps!
- Jet Brains Rider - IDE Environment for Development
- markdown-it - Markdown parser done right. Fast and easy to extend.
- Node JS - evented I/O for the backend
- MySQL Workbench - IDE for MySQL
- MySQL Server - Database storage (8.0.32)
- Azure PaaS Services - (Function App, Event Hub, App Service)


## Installation
- [.NET 6 SDK]
- [MySQL Workbench]
- [Visual Studio Code]

## Important
- Replace the connection strings before building the solution. Best runs on Visual Studio/Jet Brains Rider
- Create Function App on Portal (Only for production deployment)
- Execute SQL Script under Database folder.
- Insert the master data for WeatherStation, Role, SensorType, and SensorConfig
- Create Event Hub on Portal
- Watch some tutorial on how to use Gmail App Password via Two Step Auth Factor

## Development
Want to contribute? Great!


Open your favorite IDE and run these commands.

Restore Packages

```sh
dotnet restore
```

Connection Strings
    Change the connection strings under
```sh
appsettings.json
```

Build Solution:

```sh
dotnet build
```
Run Solution:

```sh
dotnet run
```

Contact Us
==========

EmailId - [Click Here]

   [.NET 6 SDK]: https://dotnet.microsoft.com/en-us/download/dotnet/6.0
   [MySQL WorkBench]:https://dev.mysql.com/downloads/workbench/
   [Visual Studio Code]:https://code.visualstudio.com/
   [Click Here]: mailto:srohan1999@gmail.com


