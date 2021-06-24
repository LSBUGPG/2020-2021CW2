using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator scopeAnimator;

    WeaponScope scope;

    void Awake()
    {
        scope = GetComponent<WeaponScope>();
    }

    public void PlayAnimation()
    {
        scopeAnimator.SetBool("Scoped", scope.isScoped);
    }
        
}
