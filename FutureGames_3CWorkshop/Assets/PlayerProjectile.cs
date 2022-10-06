using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public int damage;
    public Enemy bossHealth;

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.TryGetComponent<BossHealth>(out BossHealth playerHealth))
    //     {
    //         Debug.Log("collision with bosshealth");
    //         bossHealth.TakeDamage(damage);
    //         Destroy(gameObject);
    //
    //     }
    //     Destroy(gameObject);
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            Debug.Log("collision");
            enemyComponent.TakeDamage(1);
            Destroy(gameObject);
        }

        else if (collision.gameObject.TryGetComponent<MinionAI>(out MinionAI minionComponent))
        {
            Debug.Log("collision");
            minionComponent.MinionTakeDamage(1);
            Destroy(gameObject);
        }
        

        Destroy(gameObject);
    }

    
    
}
