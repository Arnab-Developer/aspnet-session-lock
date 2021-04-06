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

ASP.NET Framework output

```
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user1
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user2
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
v5o3ccaiw4yiacjw12npugz4 user3
```

ASP.NET Core output

```
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user2
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user1
info: SessionLock.AspnetCore.Controllers.HomeController[0]
      9abb3c1d-38ca-72f3-dd3d-80bc07a7aaf4 user11
```
