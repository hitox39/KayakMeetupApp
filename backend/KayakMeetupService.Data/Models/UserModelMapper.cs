﻿//using KayakMeetupService.Abstractions;



//namespace KayakMeetupService.Data.Models;

//public static class UserModelMapper
//{
//    public static Abstractions.User ToBusiness(User user)

//    {
//        return new Abstractions.User
//        {
//            Address = user.Address,
//            State = user.State,
//            ZipCode = user.ZipCode,
//            DateOfBirth = user.DateOfBirth,
//            Email = user.Email,
//            FamilyName = user.FamilyName,
//            GivenName = user.GivenName,
//            Id = user.Id
//        };
//    }

//    public static Abstractions.User ToBusiness(AddUser user)
//    {
//        return new Abstractions.User
//        {
//            Id = Guid.NewGuid(),
//            Address = user.Address,
//            State = user.State,
//            ZipCode = user.ZipCode,
//            DateOfBirth = user.DateOfBirth,
//            Email = user.Email,
//            FamilyName = user.FamilyName,
//            GivenName = user.GivenName,
//        };
//    }

//    public static User ToDatabase(Abstractions.User user)
//    {
//        return new User
//        {
//            Address = user.Address,
//            State = user.State,
//            ZipCode= user.ZipCode,
//            DateOfBirth = user.DateOfBirth,
//            Email = user.Email,
//            FamilyName = user.FamilyName,
//            GivenName = user.GivenName,
//            Id = user.Id  
//        };
//    }

   
//    public static IList<Abstractions.User> ToBusiness(List<User> users)
//    {
//        var abstractionUsers = new List<Abstractions.User>();

//        foreach (var user in users)
//        {
//            abstractionUsers.Add(ToBusiness(user));
//        }

//        return abstractionUsers;
//    }
//}
