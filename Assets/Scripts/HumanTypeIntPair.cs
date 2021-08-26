using System;
using Core.Humans.Factories;

[Serializable]
public struct HumanTypeIntPair
{
    public HumanType Key;
    public int Value;

    public HumanTypeIntPair(HumanType type,int value)
    {
        Key = type;
        Value = value;
    }
}