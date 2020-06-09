using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSquatState : IPlayerState
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
        return this;
    }

    public IPlayerState Neutral(PlayerCompornent player)
    {
        return new PlayerStandState();
    }
}
