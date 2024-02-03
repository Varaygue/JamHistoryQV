using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_EnemyBehaviour : MonoBehaviour
{
    public float movementSpeed = 5;
    public float enemyHP = 3;
    public Animator enemyAnim;
    public float deathTimer = 1;
    public float animationReset =1;
    public ResourcesManager resourcesScript;
    public bool enemyDeath;
    // Start is called before the first frame update
    void Start()
    {
        enemyDeath=false;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(-movementSpeed*Time.deltaTime,0,0);
        
        if(enemyHP==0&&!enemyDeath)
        {
            AddCoin();
            enemyDeath=true;
        }
        if(enemyHP==0)
        {
            EnemyDeath();
        }

        if(deathTimer<=0)
        {
            Destroy(gameObject);
        }
        if(animationReset<=0)
        {
            enemyAnim.ResetTrigger("EnemyHit");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Arrow")&&!enemyDeath)
        {
            enemyAnim.SetTrigger("EnemyHit");
            enemyHP = enemyHP-1;
            animationReset -= Time.deltaTime;
        }
    }

    public void EnemyDeath()
    {
        movementSpeed=0;
        deathTimer -= Time.deltaTime;
    }

    public void AddCoin()
    {
        resourcesScript.goldAmount = resourcesScript.goldAmount+25;
    }
}
