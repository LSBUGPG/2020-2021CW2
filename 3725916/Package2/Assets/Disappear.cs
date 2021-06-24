using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField] float delay = 1f;

    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(DelayDisappear(delay));
    }

    IEnumerator DelayDisappear(float _delay)
    {
        yield return new WaitForSeconds(_delay);
        this.gameObject.SetActive(false);
    }

}
