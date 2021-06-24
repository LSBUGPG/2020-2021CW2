using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScope : MonoBehaviour
{
    //public Animator scopeAnimator;

    public float scopeOverlayDelay = .15f;

    public GameObject scopeOverlay;
    public GameObject weaponCamera;
    public Camera mainCamera;

    public float scopedFOV = 15f;
    private float normalFOV;

    public bool isScoped = false;

    AnimationController animator;

    void Awake()
    {
        animator = GetComponent<AnimationController>();
    }

    // Update is called once per frame
    void Update()
    {
        Scoping();
    }


    void Scoping()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            isScoped = !isScoped;
            //scopeAnimator.SetBool("Scoped", isScoped);

            animator.PlayAnimation();

            if (isScoped)
            {
                StartCoroutine(OnScope());
            }
            else
            {
                UnScope();
            }
        }
    }

    void UnScope()
    {
        scopeOverlay.SetActive(false);
        weaponCamera.SetActive(true);

        mainCamera.fieldOfView = normalFOV;
    }

    IEnumerator OnScope()
    {
        yield return new WaitForSeconds(scopeOverlayDelay);

        scopeOverlay.SetActive(true);
        weaponCamera.SetActive(false);

        normalFOV = mainCamera.fieldOfView;
        mainCamera.fieldOfView = scopedFOV;
    }
}
