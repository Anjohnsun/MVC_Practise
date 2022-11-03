using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private PlayerView _playerView;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private int _maxHp;
    [SerializeField] private float _speed;
    private PlayerModel _playerModel;
    private PlayerController _playerController;
    private Game _game;

    private void Start()
    {
        _playerModel = new PlayerModel(_maxHp);
        _game = new Game();
        _playerController = new PlayerController(_playerView, _playerModel, _inputManager, _game, _speed);
    }
}
