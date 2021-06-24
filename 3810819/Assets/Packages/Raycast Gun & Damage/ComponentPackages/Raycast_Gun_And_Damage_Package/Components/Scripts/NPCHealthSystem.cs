using UnityEngine;
using UnityEngine.UI;
public class NPCHealthSystem : MonoBehaviour
{
    public float health = 10f;

    //ScoreManager scoreManager;

    /*void Awake()
    {
        scoreManager = GetComponent<ScoreManager>();
    }*/


    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        //ScoreManager method added for score counting
        ScoreManager.AddPoints();
        Destroy(gameObject);
    }
}
