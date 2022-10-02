using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public int damage;
    public BossHealth bossHealth;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<BossHealth>(out BossHealth playerHealth))
        {
            playerHealth.TakeDamage(damage);

        }
        Destroy(gameObject);
    }
}
