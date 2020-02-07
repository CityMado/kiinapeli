using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform Cannon;
    public GameObject BulletPrefab;
    public float fireRate = 0.5f;
    public float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }
    private void Shoot()
    {
        var bullet = Instantiate(BulletPrefab);
        bullet.transform.rotation = transform.rotation;
        bullet.transform.position = transform.position + transform.up;
        Debug.Log("Fired");
    }
}
