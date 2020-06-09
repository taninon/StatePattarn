using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompornent : MonoBehaviour
{
    private IPlayerState state;

    // Start is called before the first frame update
    void Start()
    {
        state = new PlayerJumpState();
    }

    public void PushA()
    {
        state = state.PushA(this);
    }

    public void PushLeft()
    {
        state = state.PushLeft(this);
    }

    public void PushRight()
    {
        state = state.PushRight(this);
    }

    public void PushUnder()
    {
        state = state.PushUnder(this);
    }

}
