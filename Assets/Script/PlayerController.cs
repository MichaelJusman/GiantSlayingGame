using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idle,
    Moving,
    Jumping,
    Swinging,
    Attacking,
    Damaged,
    Riding,
    Boosting,
    Die
}

public class PlayerController : Singleton<PlayerController>
{

    public PlayerState playerState;

    public void ChangePlayerState(PlayerState _playerState)
    {
        playerState = _playerState;
    }

    void Update()
    {
        switch(playerState)
        {
            case PlayerState.Idle:
                break;
        }
    }
}
