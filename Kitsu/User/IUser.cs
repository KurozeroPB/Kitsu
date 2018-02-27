﻿using System.Collections.Generic;
// ReSharper disable UnusedMemberInSuper.Global

namespace Kitsu.User
{
    public interface IUser
    {
        List<UserDataModel> Data { get; }
    }
    
    public interface IUserById
    {
        UserDataModel Data { get; }
        UserError[] Errors { get; }
    }
    
    public interface IUserData
    {
        string Id { get; }
        string Type { get; }
        UserAttributesModel Attributes { get; }
        object Relationships { get; }
    }

    public interface IUserAttributes
    {
        string CreatedAt { get; }
        string UpdatedAt { get; }
        string Name { get; }
        string[] PastNames { get; }
        string Slug { get; }
        string About { get; }
        string Location { get; }
        string WaifuOrHusbando { get; }
        int? Followers { get; }
        int? Following { get; }
        string Birthday { get; }
        string Gender { get; }
        int? Comments { get; }
        int? Favorites { get; }
        int? LikesGiven { get; }
        int? Reviews { get; }
        int? LikesReceived { get; }
        int? Posts { get; }
        int? Ratings { get; }
        int? MediaReactions { get; }
        string ProExpiresAt { get; }
        string Title { get; }
        bool ProfileCompleted { get; }
        bool FeedCompleted { get; }
        UserAvatarModel Avatar { get; }
        UserCoverImageModel CoverImage { get; }
        string RatingSystem { get; }
        string Theme { get; }
        string FacebookId { get; }
    }

    public interface IUserAvatar
    {
        string Tiny { get; }
        string Small { get; }
        string Medium { get; }
        string Large { get; }
        string Original { get; }
    }
    
    public interface IUserCoverImage
    {
        string Tiny { get; }
        string Small { get; }
        string Large { get; }
        string Original { get; }
    }

    public interface IUserError
    {
        string Title { get; }
        string Detail { get; }
        string Code { get; }
        string Status { get; }
    }
}