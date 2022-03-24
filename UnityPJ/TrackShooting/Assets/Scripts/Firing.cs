using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    private Transform firingpos;
    public GameObject bullet;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        firingpos = gameObject.GetComponent<Transform>();
        InvokeRepeating("firing", 0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void firing()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 firingposition = new Vector2(firingpos.position.x, firingpos.position.y + 0.4f);
            GameObject projectile = Instantiate(bullet, firingposition, Quaternion.identity) as GameObject;
            projectile.AddComponent<Rigidbody2D>();
            projectile.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
        }
    }
}
