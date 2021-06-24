using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{   
    public GameObject Enemy;
	public GameObject Bullet;
	public float bulletForce = 1000f;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        ShootFunctionRepeat(); 
    }

    // Update is called once per frame
    void Update()
    {
        direction = Enemy.transform.position - this.transform.position;
    }

    void ShootFunctionRepeat()
	{
		InvokeRepeating("ShootFunction", 0.0f, 1.0f);
	}

    void ShootFunction()
	{
		GameObject temp = Instantiate(Bullet, this.transform.position + direction.normalized, Quaternion.identity);
		temp.GetComponent<Rigidbody>().AddForce(direction.normalized * bulletForce);
	}


}
