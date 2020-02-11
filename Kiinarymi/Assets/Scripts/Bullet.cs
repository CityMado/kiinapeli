using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10;
    public int delay = 2;
    public int damage = 1;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * Speed;
    }

    // Update is called once per frame
    void Update()
    {
        BulletDestroy();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WeakSpot")
        {
            var enemyH = collision.gameObject.GetComponent<EnemyController>();
            enemyH.enemyHealth -= damage;
            Destroy(gameObject);
        }
    }

    void  BulletDestroy()
    {
        Object.Destroy(gameObject, delay);
    }
}
