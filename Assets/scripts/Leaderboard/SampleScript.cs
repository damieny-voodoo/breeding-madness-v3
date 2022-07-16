using System;
using System.Collections;
using System.Text;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    /*
    IEnumerator Start()
    {
        var leaderboard = new LeaderboardAPI(new Uri("http://api.andrea.abidon.io:7080/"));
        
        leaderboard.FlushLeaderboard(null, null);

        yield return new WaitForSeconds(2);
        
        leaderboard.CheckPlayerNameAvailability("Aurelio",
            (available) => Debug.Log($"Player name Aurelio is {(available ? "available" : "already used")}"),
            OnError);

        yield return new WaitForSeconds(2);
        
        leaderboard.GetLeaderboard(ShowLeaderboard, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.SubmitScore("Aurelio", 142, null, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.GetLeaderboard(ShowLeaderboard, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.SubmitScore("Damien", 84, null, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.GetLeaderboard(ShowLeaderboard, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.SubmitScore("Damien", 147, null, OnError);

        yield return new WaitForSeconds(2);
        
        leaderboard.GetLeaderboard(ShowLeaderboard, OnError);
        
        yield return new WaitForSeconds(2);
        
        leaderboard.SubmitScore("Damien", 12, null, OnError);

        yield return new WaitForSeconds(2);
        
        leaderboard.GetLeaderboard(ShowLeaderboard, OnError);
    }

    private void OnError(Exception exc)
    {
        Debug.LogException(exc);
    }

    private void ShowLeaderboard(PlayerInfo[] leaderboard)
    {
        StringBuilder sb = new StringBuilder("Leaderboard:\n");
        for (var i = 0; i < leaderboard.Length; ++i)
            sb.AppendLine($"{i + 1}. {leaderboard[i].player} → {leaderboard[i].score} pts");
        Debug.Log(sb.ToString());
    }
    */
}
