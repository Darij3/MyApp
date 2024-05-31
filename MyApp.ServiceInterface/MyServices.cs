using System;
using ServiceStack;
using MyApp.ServiceModel;
using MyApp.ServiceModel.Models;
using UserResponse = MyApp.ServiceModel.Models.UserResponse;
using User = MyApp.ServiceModel.Models.User;

namespace MyApp.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };

    }
       public object Any(User request)
        {
            return new UserResponse { Result = $" {request.id}" };
    
            
        }
    public object Any(UpdateUser request)
    {
        return new UserResponse { Result = $" {request.id}" };


    }
}
