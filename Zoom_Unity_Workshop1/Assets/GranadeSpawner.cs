using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeSpawner : MonoBehaviour
{
    public GameObject granade;
    public Transform SpawnPoint;
    float currenttime;
    float timer;
    public float speed = 10f;
    float waitTime;
    public float destroyTime = 3;
    public ParticleSystem salt;

    void Start()
    {
        timer = 0f;
    } 
    void Update()
    {
        currenttime = Time.time;
        if (currenttime > timer)
        {
            salt.Play();
            GameObject projectile = Instantiate(granade);
            Physics.IgnoreCollision(projectile.GetComponent<Collider>(), SpawnPoint.parent.GetComponent<Collider>());
            projectile.transform.SetParent(null);
            projectile.transform.position = SpawnPoint.position;
           // Vector3 rotation = projectile.transform.rotation.eulerAngles;
           // projectile.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);
            projectile.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward * speed, ForceMode.Impulse);

            Destroy(projectile, destroyTime);
            waitTime = Random.Range(2, 6);
            timer = currenttime + waitTime;
        }
    }
}
