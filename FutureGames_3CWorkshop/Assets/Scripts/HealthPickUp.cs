using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HealthPickUp : MonoBehaviour
{
    //public GameObject pickupEffect;
    //public int multiplier = 2;
    public float duration = 4f;
    public int heal = 2;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider Player)
    {
        Debug.Log("Power up picked up");

        //Particle Effect
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerMovementController stats = Player.GetComponent<PlayerMovementController>();
        stats.health += heal;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        //stats.maxHealth /= multiplier;

        Destroy(this.gameObject);
    }
}
