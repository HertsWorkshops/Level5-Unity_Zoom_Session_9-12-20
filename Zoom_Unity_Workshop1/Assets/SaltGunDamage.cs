using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltGunDamage : MonoBehaviour
{    
    PlayerHealth playerHealth;
    public int damageAmout;    
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if (Time.time > timer)
        {
            if (other.CompareTag("Player"))
            {               
               playerHealth.TakeDamage(damageAmout);               
               timer = Time.time + 1f;             
            }
        }
    }
    
}
