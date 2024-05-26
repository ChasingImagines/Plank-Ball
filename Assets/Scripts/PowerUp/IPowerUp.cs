using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp 
{
    
   
}
public struct PUP_Health : IPowerUp
{
    public int health;
}

public struct PUP_Gravity : IPowerUp
{
    public float time;
    public float gravity;
}

public struct PUP_JumpSpeed : IPowerUp
{
    public float time;
    public float jumpSpeed;


}
