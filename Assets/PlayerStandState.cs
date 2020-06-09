using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStandState : IPlayerState
{
    public IPlayerState PushA(PlayerCompornent player)
    {
        return new PlayerJumpState();
    }

    public IPlayerState PushLeft(PlayerCompornent player)
    {
        return new PlayerRunState();
    }

    public IPlayerState PushRight(PlayerCompornent player)
    {
        return new PlayerRunState();
    }

    public IPlayerState PushUnder(PlayerCompornent player)
    {
        return new PlayerSquatState();
    }

    public IPlayerState Neutral(PlayerCompornent player)
    {
        return new PlayerStandState();
    }
}
