using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Mastodon.Client;
using Mastodon.Grpc;
using Mastodon.Models;

namespace Mastodon.Services;

public sealed class InstanceService : Mastodon.Grpc.Mastodon.MastodonBase
{
    private readonly MastodonClient _mastodon;
    private readonly ILogger<InstanceService> _logger;
    public InstanceService(ILogger<InstanceService> logger, MastodonClient mastodon)
    {
        _logger = logger;
        _mastodon = mastodon;
    }

    public override async Task<Grpc.InstanceV1> GetInstanceV1(Empty request, ServerCallContext context)
    {
        var instance = (await _mastodon.Instance.GetInstanceV1Async())!;

        instance.Uri = context.GetHttpContext().Request.Host.Value;

        return instance.ToGrpc();
    }

    public override async Task<Grpc.Instance> GetInstance(Empty request, ServerCallContext context)
    {
        var instance = (await _mastodon.Instance.GetInstanceAsync())!;

        instance.Domain = context.GetHttpContext().Request.Host.Value;

        return instance.ToGrpc();
    }

    public override async Task<Activities> GetActivities(Empty request, ServerCallContext context)
    {
        var result = (await _mastodon.Instance.GetActivitiesAsync());
        return result.ToGrpc();
    }

    public override async Task<Rules> GetRules(Empty request, ServerCallContext context)
    {
        var result = (await _mastodon.Instance.GetRulesAsync());
        return result.ToGrpc();
    }

    public override async Task<Grpc.Account> GetAccountById(StringValue request, ServerCallContext context)
    {
        var result = (await _mastodon.Accounts.GetByIdAsync(request.Value))!;
        return result.ToGrpc();
    }
}
