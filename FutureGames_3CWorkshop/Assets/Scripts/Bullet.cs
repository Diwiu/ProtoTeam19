using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Damages the player
        
        if (collision.gameObject.TryGetComponent<PlayerMovementController>(out PlayerMovementController playerComponent))
        {
            playerComponent.PlayerDamage(1);
        }
            
        //Destroy(gameObject);
        
        

        // This makes enemies take damage by the projectile. Maybe make a separate script ?
        // this currently makes the enemy kill itself because the spawnpoint of the bullet it instantiates is inside the collision.
        
        
        // if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        // {
        //     enemyComponent.TakeDamage(1);
        // }
        //
        // Destroy(gameObject);
    }
    
}
