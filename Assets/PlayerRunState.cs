using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : IPlayerState
{
    public IPlayerState PushA(PlayerCompornent player)
    {
        return new PlayerJumpState();
    }

    public IPlayerState PushLeft(PlayerCompornent player)
    {
        return this;
    }

    public IPlayerState PushRight(PlayerCompornent player)
    {
        return this;
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
