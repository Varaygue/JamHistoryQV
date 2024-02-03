using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ArcherUnit : MonoBehaviour
{
    public float fireCountdown = 3;
    public GameObject arrowProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireCountdown -= Time.deltaTime;

        if(fireCountdown <= 0)
        {
            FireProjectile();
            fireCountdown=3;
        }
    }

    private void FireProjectile()
    {
        Instantiate(arrowProjectile,transform.position, transform.rotation);
    }
}
