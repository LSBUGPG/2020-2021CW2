 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public int MaxHealth = 3;
    public int CurrentHealth;
    public Timer Timer;
    public Ending End;

    public Text HealthText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        Timer.instance.BeginTimer();
    }

    // Update is called once per frame
    void Update()
    {
      //  HealthText.text = "Health: " + CurrentHealth; 
    }
    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        HealthText.text = "Health: " + CurrentHealth;

        if (CurrentHealth <= 0)
        {
            //Your Dead son
            Timer.instance.EndTimer();
            End.EndGame();
            print("Dead");
        }  

    }

    public void Heal(int amount)
    {
        CurrentHealth += amount;
        HealthText.text = "Health: " + CurrentHealth;

        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
                print("Full Health");
        }

    }
    

}
