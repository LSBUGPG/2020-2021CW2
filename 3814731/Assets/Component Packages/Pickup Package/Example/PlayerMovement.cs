using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public int maxValue = 20;
    public int currentValue;

    public int progressMaxValue = 10;
    public int progressCurrentValue;

    public BarSlider hpBarSlider;
    public BarSlider progressSlider;

    public GameManager gameManager;

    void Start()
    {
        currentValue = maxValue;
        hpBarSlider.SetMaxValue(maxValue);

        progressCurrentValue = 0;
        //progressSlider.SetMaxValue(progressMaxValue);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        if (currentValue == 0)
        {
            gameManager.EndGame();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Add")
        {
            AddValue(1);
        }
        else if (other.tag == "Minus")
        {
            MinusValue(2);
        }
    }

    void MinusValue(int minus)
    {
        currentValue -= minus;
        hpBarSlider.SetBarValue(currentValue);
    }

    void AddValue(int add)
    {
        progressCurrentValue += add;
        progressSlider.SetBarValue(progressCurrentValue);
    }

}
