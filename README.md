# Introduction to gRPC
## Training 2021/04/02 - Software Engineering

### Tasks
- [ ] Clone Repo
- [ ] Watch Video
- [ ] Run existing code
- [ ] Create Calculator Service
  - [ ] Create Calculator Proto File. This file should have an `PerformAddition` RPC with an AdditionRequest and AdditionReply message.
  - [ ] Generate the server side `stub`
  - [ ] Implement the `PerformAddition` RPC in the Calculator service.
  - [ ] In the client app, add a service reference to the Calculator Proto file.
  - [ ] Update the client program to call the `PerformAddition` method.
  - [ ] Run your code
- [ ] Give this training 5 stars! 
- [ ] Enjoy your weekend!

---


## Links

### Introduction Articles / Documentation
 - **[Introduction to gRPC on .NET](https://docs.microsoft.com/en-us/aspnet/core/grpc/?view=aspnetcore-5.0)**
   - **[gRPC](https://grpc.io/docs/guides/)** is a language agnostic, high-performance Remote Procedure Call (**[RPC](https://docs.microsoft.com/en-us/windows/win32/rpc/rpc-start-page)**) framework.
 - **[Tutorial: Create a gRPC client and server in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-3.1&tabs=visual-studio)**
   - This tutorial shows how to create a .NET Core **[gRPC](https://grpc.io/docs/guides/)** client and an ASP.NET Core gRPC Server.
   - At the end, you'll have a gRPC client that communicates with the gRPC Greeter service.
   - **[View or download sample code](https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/tutorials/grpc/grpc-start/sample)** (**[how to download](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-5.0#how-to-download-a-sample)**).
 - **[gRPC services with C#](https://docs.microsoft.com/en-us/aspnet/core/grpc/basics?view=aspnetcore-5.0&viewFallbackFrom=aspnetcore-3.1%2F%3FWT.mc_id%3Dvstoolbox-c9-niner)**
   - This document outlines the concepts needed to write **[gRPC](https://grpc.io/docs/guides/)** apps in C#. The topics covered here apply to both **[C-core](https://grpc.io/blog/grpc-stacks)**-based and ASP.NET Core-based gRPC apps.

### Other Articles / Documentation 
 - **[How to Design Messages for gRPC Services in .NET Core](https://visualstudiomagazine.com/articles/2020/01/06/defining-grpc-messages.aspx)**
   - Defining your gRPC service using the Protocol Buffers specification is pretty easy. There are just a couple of things to be aware of as you convert from the specification to .NET Core and then manage your service's evolution.
 - **[Core concepts, architecture and lifecycle](https://grpc.io/docs/what-is-grpc/core-concepts/)**
   - An introduction to key gRPC concepts, with an overview of gRPC architecture and RPC life cycle.


---

### Videos 

 - **[Introduction to gRPC - Video](https://stackoverflow.com/questions/31890717/adding-a-readme-md-file-to-a-c-sharp-project-in-visual-studio-2015)**
   - In this episode, Robert is joined by Sourabh Shirhatti, who shows how to build a gRPC service with Visual Studio. Sourabh starts with an introduction to gRPC, a language agnostic, high-performance Remote Procedure Call (RPC) framework, and reviews why it was created and what benefits it has over other ways of building services. Sourabh then creates a service from scratch in Visual Studio and then builds an app to call it.
   
---