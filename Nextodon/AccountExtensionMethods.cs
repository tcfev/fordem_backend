﻿namespace Nextodon;

public static class AccountExtensionMethods
{
    //public static Grpc.Accounts ToGrpc(this IEnumerable<Nextodon.Data.Account>? i, string domain)
    //{
    //    var accounts = new Grpc.Accounts();
    //    if (i != null)
    //    {
    //        foreach (var r in i)
    //        {
    //            accounts.Data.Add(r.ToGrpc(domain));
    //        }
    //    }

    //    return accounts;
    //}

    //public static Grpc.Account ToGrpc(this Nextodon.Data.Account i, string domain)
    //{
    //    var v = new Grpc.Account
    //    {
    //        Id = i.Id,
    //        Url = $"https://{domain}/account/{i.Id}",
    //        Acct = $"{i.Id}",
    //        Avatar = $"https://{domain}/asset/avatar/man-03.png",
    //        AvatarStatic = $"https://{domain}/asset/avatar/man-03.png",
    //        Header = $"https://{domain}/asset/header/scene-024.png",
    //        HeaderStatic = $"https://{domain}/asset/header/scene-024.png",
    //        Locked = i.Locked,
    //        DisplayName = i.DisplayName ?? i.Id,
    //        Username = i.Username ?? i.Id,
    //        Note = i.Note ?? "My Note",
    //        Bot = i.Locked,
    //        Group = false,
    //        Limited = false,
    //        Suspended = false,
    //        //Role = i.Role?.ToGrpc(),
    //        Role = new Role { Position = 0, },
    //        //Source = i.Source?.ToGrpc(),
    //        //Moved = i.Moved?.ToGrpc(),
    //        CreatedAt = i.CreatedAt.ToGrpc(),
    //        LastStatusAt = i.CreatedAt.ToGrpc(),//TODO
    //        FollowersCount = 1100,
    //        FollowingCount = 20,
    //        StatusesCount = 20,
    //        Source = new Grpc.Account.Types.Source { },
    //        Discoverable = i.Discoverable ?? false,
    //    };

    //    if (i.Discoverable != null)
    //    {
    //        v.Discoverable = i.Discoverable.Value;
    //    }

    //    //if (i.FollowersCount != null)
    //    //{
    //    //    v.FollowersCount = i.FollowersCount.Value;
    //    //}

    //    //if (i.FollowingCount != null)
    //    //{
    //    //    v.FollowingCount = i.FollowingCount.Value;
    //    //}

    //    //if (i.StatusesCount != null)
    //    //{
    //    //    v.StatusesCount = i.StatusesCount.Value;
    //    //}


    //    v.Fields.AddRange(i.Fields.Select(x => x.ToGrpc()));
    //    //v.Emojis.AddRange(i.Emojis.Select(x => x.ToGrpc()));

    //    return v;
    //}

    //public static Grpc.Account.Types.Field ToGrpc(this Nextodon.Data.Account.Field i)
    //{
    //    var v = new Grpc.Account.Types.Field
    //    {
    //        Name = i.Name,
    //        Value = i.Value,
    //    };

    //    if (i.VerifiedAt != null)
    //    {
    //        v.VerifiedAt = Timestamp.FromDateTime(i.VerifiedAt.Value.ToUniversalTime());
    //    }

    //    return v;
    //}
}
