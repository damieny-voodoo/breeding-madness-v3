using System;
/*
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using SimpleJSON;
using UnityEngine;

public class LeaderboardAPI : IDisposable
{
    /*
    private readonly Uri baseUri;
    private readonly HttpClient client = new HttpClient();
    
    public LeaderboardAPI(Uri baseUri)
    {
        this.baseUri = baseUri;
        var dispatcher = MainThreadDispatcher.shared; // ensure created on main thread
    }

    public void Dispose() => client?.Dispose();

    public void CheckPlayerNameAvailability(string player, Action<bool> onSuccess, Action<Exception> onFailure)
        => Safely(onFailure, () =>
        {
            Uri endpoint = new Uri(baseUri, $"leaderboard/{Uri.EscapeDataString(player)}");

            client.GetAsync(endpoint)
                .ContinueWith((requestTask) => Safely(onFailure, () =>
                {
                    if (requestTask.IsFaulted)
                        MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                    requestTask.Result.Content.ReadAsStringAsync()
                        .ContinueWith((contentTask) => Safely(onFailure, () => 
                        {
                            if (contentTask.IsFaulted)
                                MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                            var content = contentTask.Result;
                            bool payload = content == "true";

                            MainThreadDispatcher.shared.Dispatch(() => onSuccess?.Invoke(payload));
                        }));
                }));
        });

    public void FlushLeaderboard(Action onSuccess, Action<Exception> onFailure) => Safely(onFailure, () =>
    {
        Uri endpoint = new Uri(baseUri, $"leaderboard");

        client.DeleteAsync(endpoint)
            .ContinueWith((requestTask) => Safely(onFailure, () =>
            {
                if (requestTask.IsFaulted)
                    MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                MainThreadDispatcher.shared.Dispatch(() => onSuccess?.Invoke());
            }));
    });

    public void GetLeaderboard(Action<PlayerInfo[]> onSuccess, Action<Exception> onFailure)
    {
        Safely(onFailure, () =>
               {
                   Uri endpoint = new Uri(baseUri, $"leaderboard");
                   Stopwatch timer = Stopwatch.StartNew();
       
                   client.GetAsync(endpoint)
                       .ContinueWith((requestTask) => Safely(onFailure, () =>
                       {
                           //UnityEngine.Debug.Log($"Time to response$ {timer.Elapsed.TotalSeconds}");
                           if (requestTask.IsFaulted)
                               MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                           requestTask.Result.Content.ReadAsStringAsync()
                               .ContinueWith((contentTask) => Safely(onFailure, () =>
                               {
                                   if (contentTask.IsFaulted)
                                       MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                                   var content = contentTask.Result;
                                   var jsonNode = JSON.Parse(content);
                                   var payload = PlayerInfo.AllFromJson(jsonNode);

                                   MainThreadDispatcher.shared.Dispatch(() => onSuccess?.Invoke(payload));
                               }));
                       }));
               });
    }

    public void SubmitScore(string player, uint score, Action onSuccess, Action<Exception> onFailure) => Safely(onFailure, () =>
    {
        Uri endpoint = new Uri(baseUri, $"leaderboard/{Uri.EscapeDataString(player)}/{score}");

        client.PostAsync(endpoint, new ByteArrayContent(Array.Empty<byte>()))
            .ContinueWith((requestTask) => Safely(onFailure, () =>
            {
                if (requestTask.IsFaulted)
                    MainThreadDispatcher.shared.Dispatch(() => onFailure?.Invoke(requestTask.Exception));

                MainThreadDispatcher.shared.Dispatch(() => onSuccess?.Invoke());
            }));
    });

    private void Safely(Action<Exception> failureHandler, Action block)
    {
        try
        {
            block();
        }
        catch (Exception e)
        {
            failureHandler?.Invoke(e);
        }
    } 
}

*/
