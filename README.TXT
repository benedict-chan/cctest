ninetech
========

- Assumption
 - Only checked if booker name is empty or not
 - The earliest advertisement booking day has to be the next day 
 - Checking are only done in Client Side now, but as we have used ORM in WebApi, sql injection should not happen



- DB
  - Database is SQL Server Compact 4.0 Local Database

-WebAPI 

 - project is based on ASP.NET MVC4 WebApi Template
 - Nuget install Ninject.MVC3 for Dependency Injection
 - Added NinjectResolver, NinjectScope to support Web Api
 - http://www.strathweb.com/2012/05/using-ninject-with-the-latest-asp-net-web-api-source/


- Web Client 
 - Use Twitter.Bootstrap for HTML template
 - Use a jquery plugin "bootstrap-datepicker" for the date picker
   https://github.com/eternicode/bootstrap-datepicker
 - Use a jquery plugin "bootstrap-timepicker" for the time picker
   https://github.com/jdewit/bootstrap-timepicker
 - To help parsing datetime objects, moment.js is used
   http://momentjs.com/