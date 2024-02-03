using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Arrow : MonoBehaviour
{
    public float arrowSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(arrowSpeed*Time.deltaTime,0,0);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
