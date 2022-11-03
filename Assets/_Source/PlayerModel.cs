using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerModel
{
    private int _maxHp;
    private int _hp;
    public UnityEvent OnHealthChange = new UnityEvent();
    public UnityEvent OnPlayerDeath = new UnityEvent();

    public int MaxHp { get => _maxHp; set => _maxHp = value; }
    public int Hp { get => _hp; set => _hp = value; }

    public PlayerModel(int maxHP)
    {
        _maxHp = maxHP;
        _hp = maxHP;
    }
}
