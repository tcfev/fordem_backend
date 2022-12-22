﻿using Mastodon.Grpc;

namespace Mastodon;

public static class InstanceExtensionMethods
{
    public static Grpc.Rules ToGrpc(this IEnumerable<Mastodon.Models.Rule>? i)
    {
        var rules = new Grpc.Rules();

        if (i != null)
        {
            foreach (var r in i)
            {
                rules.Data.Add(r.ToGrpc());
            }
        }

        return rules;
    }

    public static Grpc.Activities ToGrpc(this IEnumerable<Mastodon.Models.Activity>? i)
    {
        var rules = new Grpc.Activities();

        if (i != null)
        {
            foreach (var r in i)
            {
                rules.Data.Add(r.ToGrpc());
            }
        }

        return rules;
    }

    public static Grpc.Instance ToGrpc(this Mastodon.Models.Instance i)
    {
        var v = new Grpc.Instance
        {
            Domain = i.Domain,
            Title = i.Title,
            Version = i.Version,
            SourceUrl = i.SourceUrl,
            Description = i.Description,
            Usage = i.Usage.ToGrpc(),
            Thumbnail = i.Thumbnail.ToGrpc(),
            Configuration = i.Configuration.ToGrpc(),
            Registrations = i.Registrations.ToGrpc(),
            Contact = i.Contact.ToGrpc(),
        };

        v.Languages.AddRange(i.Languages);
        v.Rules.AddRange(i.Rules.Select(x => x.ToGrpc()));

        return v;
    }

    public static Grpc.InstanceV1 ToGrpc(this Mastodon.Models.InstanceV1 i)
    {
        var v = new Grpc.InstanceV1
        {
            Uri = i.Uri,
            Title = i.Title,
            Version = i.Version,
            ApprovalRequired = i.ApprovalRequired,
            Email = i.Email,
            InvitesEnabled = i.InvitesEnabled,
            ShortDescription = i.ShortDescription,
            Stats = new InstanceV1.Types.Stats
            {
                DomainCount = i.Stats.DomainCount,
                StatusCount = i.Stats.StatusCount,
                UserCount = i.Stats.UserCount,
            },
            Description = i.Description,
            Thumbnail = i.Thumbnail,
            Configuration = new InstanceV1.Types.Configuration
            {
                Accounts = i.Configuration.Accounts.ToGrpc(),
                MediaAttachments = i.Configuration.MediaAttachments?.ToGrpc(),
                Polls = i.Configuration.Polls?.ToGrpc(),
                Statuses = i.Configuration.Statuses?.ToGrpc(),
            },
            Registrations = i.Registrations,
            ContactAccount = i.ContactAccount.ToGrpc(),
            Urls = new InstanceV1.Types.Urls
            {
                StreamingApi = i.Urls.StreamingApi
            },
        };

        v.Languages.AddRange(i.Languages);
        v.Rules.AddRange(i.Rules.Select(x => x.ToGrpc()));

        return v;
    }

    public static Grpc.Activity ToGrpc(this Mastodon.Models.Activity i)
    {
        return new Activity
        {
            Logins = i.Logins,
            Registrations = i.Registrations,
            Statuses = i.Statuses,
            Week = i.Week,
        };
    }

    public static Grpc.Instance.Types.Contact ToGrpc(this Mastodon.Models.Instance.ContactHash i)
    {
        return new Instance.Types.Contact
        {
            Email = i.Email,
            Account = i.Account.ToGrpc(),
        };
    }

    public static Grpc.Instance.Types.Registrations ToGrpc(this Mastodon.Models.Instance.RegistrationsHash i)
    {
        return new Instance.Types.Registrations
        {
            Enabled = i.Enabled,
            ApprovalRequired = i.ApprovalRequired ?? false,
            Message = i.Message ?? string.Empty,
        };
    }

    public static Grpc.Instance.Types.Configuration ToGrpc(this Mastodon.Models.Instance.ConfigurationHash i)
    {
        return new Instance.Types.Configuration
        {
            Accounts = i.Accounts.ToGrpc(),
            MediaAttachments = i.MediaAttachments?.ToGrpc(),
            Polls = i.Polls.ToGrpc(),
            Statuses = i.Statuses.ToGrpc(),
            Translation = i.Translation.ToGrpc(),
            Urls = i.Urls.ToGrpc(),
        };
    }

    public static Grpc.Instance.Types.Configuration.Types.Accounts ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.AccountsHash i)
    {
        return new Instance.Types.Configuration.Types.Accounts
        {
            MaxFeaturedTags = i.MaxFeaturedTags ?? 0,
        };
    }

    public static Grpc.Instance.Types.Configuration.Types.MediaAttachments ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.MediaAttachmentsHash i)
    {
        var v = new Instance.Types.Configuration.Types.MediaAttachments
        {
            ImageMatrixLimit = i.ImageMatrixLimit,
            ImageSizeLimit = i.ImageSizeLimit,
            VideoFrameRateLimit = i.VideoFrameRateLimit,
            VideoMatrixLimit = i.VideoMatrixLimit,
            VideoSizeLimit = i.VideoSizeLimit,
        };

        v.SupportedMimeTypes.AddRange(i.SupportedMimeTypes);

        return v;
    }

    public static Grpc.Instance.Types.Configuration.Types.Polls ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.PollsHash i)
    {
        return new Instance.Types.Configuration.Types.Polls
        {
            MaxCharactersPerOption = i.MaxCharactersPerOption ?? 0,
            MaxOptions = i.MaxOptions ?? 0,
            MinExpiration = i.MinExpiration ?? 0,
            MaxExpiration = i.MaxExpiration ?? 0,
        };
    }

    public static Grpc.Instance.Types.Configuration.Types.Statuses ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.StatusesHash i)
    {
        return new Instance.Types.Configuration.Types.Statuses
        {
            CharactersReservedPerUrl = i.CharactersReservedPerUrl ?? 0,
            MaxCharacters = i.MaxCharacters ?? 0,
            MaxMediaAttachments = i.MaxMediaAttachments ?? 0,
        };
    }

    public static Grpc.Instance.Types.Configuration.Types.Translation ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.TranslationHash i)
    {
        return new Instance.Types.Configuration.Types.Translation
        {
            Enabled = i.Enabled,
        };
    }

    public static Grpc.Instance.Types.Configuration.Types.Urls ToGrpc(this Mastodon.Models.Instance.ConfigurationHash.UrlsHash i)
    {
        return new Instance.Types.Configuration.Types.Urls
        {
            Streaming = i.Streaming,
        };
    }

    public static Grpc.Instance.Types.Usage ToGrpc(this Mastodon.Models.Instance.UsageHash i)
    {
        return new Instance.Types.Usage
        {
            Users = new Instance.Types.Usage.Types.Users
            {
                ActiveMonth = i.Users.ActiveMonth,
            }
        };
    }

    public static Grpc.Instance.Types.Thumbnail ToGrpc(this Mastodon.Models.Instance.ThumbnailHash i)
    {
        return new Instance.Types.Thumbnail
        {
            Url = i.Url,
            Blurhash = i.Blurhash,
            Versions = i.Versions?.ToGrpc(),
        };
    }

    public static Grpc.Instance.Types.Thumbnail.Types.Versions ToGrpc(this Mastodon.Models.Instance.ThumbnailHash.VersionsHash i)
    {
        return new Instance.Types.Thumbnail.Types.Versions
        {
            OneX = i._1x,
            TwoX = i._2x,
        };
    }
}
