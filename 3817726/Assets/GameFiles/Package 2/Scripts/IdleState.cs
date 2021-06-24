using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : TurretState
{

    public override void Enter(TurretScript parent)
    {
        base.Enter(parent);
        parent.Animator.SetBool("Shoot", false);
    }



    public override void Update()
    {
        if(parent.DefaultRotation != parent.Rotator.rotation)
        {
            parent.Rotator.rotation = Quaternion.RotateTowards
                (parent.Rotator.rotation, parent.DefaultRotation, Time.deltaTime * parent.RotationSpeed);
        }

        if (parent.Target != null)
        {
            if(parent.CanSeeTarget(((parent.Target.position+parent.AimOffset)- parent.GunBarrels[0].position),parent.GunBarrels[0].position, "Player"))
            {

            }
        }

    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Is In Range");
            parent.Target = other.transform;
            parent.ChangeState(new FindTargetState());
        }
        //this detects if the player is going to be in range of the turret and if so it will show in console 
    }
}
