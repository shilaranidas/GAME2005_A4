using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletBehaviour : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float range;
    public bool isOutbound;
    // Start is calld before the first frame update
    void Start()
    {
        //speed=4;
        //direction=Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
         _Move();
        _CheckBounds();
    }
      private void _Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    public void _CheckBounds()
    {
        if (gameObject != null)
        {
            if (Vector3.Distance(transform.position, Vector3.zero) > range)
            {
                gameObject.SetActive(false);
            }
            
        }
    }
}
