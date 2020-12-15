using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform bulletSpawn;
    public GameObject bullet;
    public int fireRate;
    public BulletManager bulletManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fire();
    }
    public void fire()
    {
        if (Time.frameCount % fireRate == 0)
        {
            if (Input.GetAxisRaw("Fire1") > 0.0f)
            //delays firing
            {
                GameObject tempbullet = ObjectPool.SharedInstances.GetPooledObjects();


                if (tempbullet != null)
                {
                    tempbullet.GetComponent<BulletBehaviour>().direction = bulletSpawn.forward;
                    tempbullet.GetComponent<BulletBehaviour>().transform.position = bulletSpawn.transform.position;
                    tempbullet.SetActive(true);
                }
            }
        }

    }

}
