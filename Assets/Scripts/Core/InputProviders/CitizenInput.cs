using UnityEngine;
using Core.InputProviders;

public class CitizenInput : IDirectionInput
{
    public Vector2 Direction { get; private set; }

    public void Read()
    {
        Debug.Log("1");
    }
}