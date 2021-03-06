using System;
using GTANetworkAPI;

public class MinesTest : Script
{
    public MinesTest()
    {
    }

    [ServerEvent(Event.ResourceStart)]
    public void myResourceStart()
    {
        NAPI.Util.ConsoleOutput("Starting mines!");
    }

    [Command("mine")]
    public void PlaceMine(Player sender, float MineRange = 10f)
    {
        var pos = NAPI.Entity.GetEntityPosition(sender);
        var playerDimension = NAPI.Entity.GetEntityDimension(sender);
        NAPI.Chat.SendChatMessageToPlayer(sender, "Bomba nuclearaaaaa");
        var prop = NAPI.Object.CreateObject(NAPI.Util.GetHashKey("prop_bomb_01"), pos - new Vector3(0, 0, 1f), new Vector3(), 255, playerDimension);
        var shape = NAPI.ColShape.CreateSphereColShape(pos, 10);
        shape.Dimension = playerDimension;
    }
}