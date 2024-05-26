using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUpTriger 
{

    public void  PowerUpdate(GameObject gameObject);
    public void  PowerUpdate(PUP_Health health);

    public void PowerUpdate( PUP_Gravity gravity );

    public void PowerUpdate( PUP_JumpSpeed jumpSpeed);

    
  
}

