using System;
using System.Collections.Generic;
//using SimpleJSON;

public struct PlayerInfo
{
    /*
    public string player;
    public int score;

    public static PlayerInfo[] AllFromJson(JSONNode jsonNode)
    {
        if (false == jsonNode.IsArray)
            throw new Exception("Invalid JSON: expected array for PlayerInfo[]");

        List<PlayerInfo> leaderboard = new List<PlayerInfo>(100);
        foreach (var innerNode in jsonNode.AsArray.Children)
            leaderboard.Add(FromJson(innerNode));

        return leaderboard.ToArray();
    }

    public static PlayerInfo FromJson(JSONNode jsonNode)
    {
        if (false == jsonNode.IsObject)
            throw new Exception("Invalid JSON: expected object for PlayerInfo");
        return new PlayerInfo { player = jsonNode["player"].Value, score = jsonNode["score"].AsInt };
    }
    */
}
