using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleSpawn: MonoBehaviour
{
    public GameObject spawn;

    private void Start()
    {
        //Time when spawn begins, and when next spawn appears
        InvokeRepeating("PowerUp", 20, 40);
    }

    //Location range for pickup to spawn
    Vector3 GetSpawnPoint()
    {
        float x = Random.Range(-15f, 20f);
        float y = (1f);
        float z = Random.Range(4f, 21f);

        return new Vector3(x, y, z);
    }

    void PowerUp()
    {
        Instantiate(spawn, GetSpawnPoint(), Quaternion.identity);
    }

}