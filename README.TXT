cctest
========

## Readme ##
- To run: http://localhost:3949/


## Assumption ##
- Booker name cannot be empty
- The earliest advertisement booking day has to be the next day 
- Checking are only done in Client Side now, but as we have used ORM in WebApi, sql injection should not happen
- Now Both WebClient and WebApi uses the same instance, for production, we should separte them into two instances.


## DB ##
- Database is SQL Server Compact 4.0 Local Database
- Located in \BenedictWebApi\App_Data\BenedictWebApi.Models.BookingDb.sdf


## Entity Framework ##
- CodeFirst
- Source located in \BenedictWebApi\Models\BookingDb.cs
- Source located in \BenedictWebApi\Models\BookingInitializer.cs
- Source located in \BenedictWebApi\Models\Booking.cs


## WebAPI is used ## 
- To create a booking, post to http://localhost:3949/api/advertisementbooking
- The following is commented as request we only allow posting. Please uncomment and rebuild it. 
- (commented) To get list of bookings, get to http://localhost:3949/api/advertisementbooking/
- (commented) To get single booking detail, http://localhost:3949/api/advertisementbooking/{id as integer}
- project is based on ASP.NET MVC4 WebApi Template
- Source located in \BenedictWebApi\Controllers\AdvertisementBookingController.cs


## Web Client ##
- A simple ASP.Net MVC 4 page
- Using Twitter Bootstrap for template
- Use jquery Ajax to make the post to web api responsive
- Source located in \BenedictWebApi\Views\Advertisement\New.cshtml


### external javascript libaries ###
- "bootstrap-datepicker"                          https://github.com/eternicode/bootstrap-datepicker
- "bootstrap-timepicker"                          https://github.com/jdewit/bootstrap-timepicker
- "moment.js" for javascript date object parsing. http://momentjs.com/


## Repository ##
- Source located in \BenedictWebApi\Models\IBookingRepository.cs
- Source located in \BenedictWebApi\Models\BookingRepository.cs


## Dependency Injection ##
- Applied Dependency Injection using NInject for an IBookingRepository to AdvertisementBookingController
- Source located in \BenedictWebApi\App_Start\NinjectWebCommon.cs
- Source located in \BenedictWebApi\App_Start\NinjectResolver.cs
- Source located in \BenedictWebApi\App_Start\NinjectScope.cs
- To support Web Api:
- Please check http://www.strathweb.com/2012/05/using-ninject-with-the-latest-asp-net-web-api-source/


## Unit Test ##
- Unit Test project in BenedictWebApi.Tests
- Source located in \BenedictWebApi.Tests\Controllers\AdvertisementBookingTest.cs
- Moq is applied for mocking the IBookingRepository in order to test AdvertisementBookingController

