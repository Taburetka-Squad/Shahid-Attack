using UnityEngine;
using Core.InputProviders;
using System;

public class CitizenInput : MonoBehaviour, IInput
{
    public event Action NeedAnAttack;

    public Vector2 Direction => _direction;
    private Vector2 _direction;

    public void Move()
    {
        
    }
    public void ReadInput()
    {
        Debug.Log("");
    }
}
