using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private float fireRate = 0.1f;
    private float nextFire = 0.2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var ball = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            ball.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

        }

        // if (Gamepad.current.rightTrigger.wasPressedThisFrame)
        // {
        //     var ball = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        //     ball.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        // }
        
    }


    private void OnLook(InputValue lookValue)
    {
        if(lookValue.Get<Vector2>() != Vector2.zero && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var ball = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            ball.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed; 
            
        }
        
        // if (Fire.isPressed)
        // {
        //     var ball = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        //     ball.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed; 
        // }
        
        
    }
    
    
    //public void Shootball()
    
        // activeplayer currentplayer = manager; 
        
        //manager.ChangeTurn();
    
}
