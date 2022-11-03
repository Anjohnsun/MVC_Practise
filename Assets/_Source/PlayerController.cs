using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;
    private InputManager _inputManger;
    private Game _game;

    private bool _isAlive = true;
    private float _speed;

    public PlayerController(PlayerView playerView, PlayerModel playerModel, InputManager inputManager, Game game, float speed)
    {
        _playerView = playerView;
        _playerModel = playerModel;
        _inputManger = inputManager;
        _game = game;
        _speed = speed;

        _inputManger.OnHorizontalArrow.AddListener(MoveHorizontally);
        _inputManger.OnVerticalArrow.AddListener(MoveVertically);
        _playerView.onCollision.AddListener(DamagePlayer);
    }

    private void MoveHorizontally(float value)
    {
        if (_isAlive)
            _playerView.MoveHorizontally(value * _speed);
    }

    private void MoveVertically(float value)
    {
        if (_isAlive)
            _playerView.MoveVertically(value * _speed);
    }

    private void DamagePlayer()
    {
        _playerView.DrawPlayerDamaged();
        _playerModel.Hp--;
        _playerView.RefreshHpText(_playerModel.Hp);
        if (_playerModel.Hp == 0)
            _game.ReloadScene();
    }
}
