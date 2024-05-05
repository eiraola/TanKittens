using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ETeam
{
    None,
    Neutral,
    Player,
    Enemy
}
public interface IHitable 
{
    public void Hit(int value);
    public ETeam GetTeam();
}
