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
    private void fire(){
    if(Input.GetAxisRaw("Fire1")>0.0f)
        //delays firing
            if(Time.frameCount%fireRate==0)
                //
                {
                    //Debug.Log("Fire");
                     var tempBullet = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
                tempBullet.GetComponent<BulletBehaviour>().direction = bulletSpawn.forward;

                tempBullet.transform.SetParent(bulletManager.gameObject.transform);
                }
    }
}
