using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : IPlayerState
{
    public IPlayerState PushA(PlayerCompornent player)
    {
        return this;
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
        return this;
    }

    public IPlayerState Neutral(PlayerCompornent player)
    {
        return new PlayerStandState();
    }
}
