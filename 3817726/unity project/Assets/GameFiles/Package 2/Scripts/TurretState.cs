using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TurretState
{
    protected TurretScript parent;

    public virtual void Enter(TurretScript parent)
    {
        this.parent = parent;
    }

    public virtual void Update()
    {

    }

    public virtual void Exit()
    {

    }

   private Transform target;

    public virtual void OnTriggerEnter(Collider other)
    {

    }

    public virtual void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            parent.Target = null;
            parent.ChangeState(new IdleState());
        }
    }
    
}
