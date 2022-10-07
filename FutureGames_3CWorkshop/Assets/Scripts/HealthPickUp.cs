using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthPickUp : MonoBehaviour
{
    //public GameObject pickupEffect;
    //public int multiplier = 2;
    public float duration = 4f;
    public int heal = 2;
    public HealthBar healthBar;
    public int health = 1;


    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && other.gameObject.GetComponent<PlayerMovementController>().health < 6)
        {
            
            StartCoroutine(Pickup(other));
            other.gameObject.GetComponent<PlayerMovementController>().IncreaseHealth(health);
        }
    }

    IEnumerator Pickup(Collider Player)
    {
        Debug.Log("Power up picked up");

        //Particle Effect
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerMovementController stats = Player.GetComponent<PlayerMovementController>();
        stats.health += heal;
        healthBar.SetHealth(health);


        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        //stats.maxHealth /= multiplier;

        Destroy(this.gameObject);
    }
}
