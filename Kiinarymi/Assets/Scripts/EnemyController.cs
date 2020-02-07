using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthSystem();
    }

    public void HealthSystem()
    {
        if(enemyHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
