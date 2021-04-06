# ASP.NET session state lock

This is a comparisn of session state behaviour between ASP.NET Core and ASP.NET Framework.
`session state` of ASP.NET Core is non-locking and ASP.NET Framework is locking for requests coming
from same client.

There are two projects in this solution. One is ASP.NET Core and another is ASP.NET Framework. In
both the projects there are some usage of `session state` have been made. Multiple requests have been 
made from a single user to the application. There are some logs to check the locking behavior of 
`session state` for both.

Please see the `Output.txt` file found in both the application to understand that `session state` of 
ASP.NET Core is non-locking and ASP.NET Framework is locking for requests coming from same client.
