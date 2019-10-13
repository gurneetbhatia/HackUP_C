using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float countdown = scrollScript.CoinRate;

    public GameObject go;

    public Transform[] CoinSpawns;
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Spawn();
            countdown = 3f;

        }
    }

     public void Spawn()
    {
        Quaternion rotation = CoinSpawns[Random.Range(0,CoinSpawns.Length)].transform.rotation;
        GameObject coin = Instantiate(go, CoinSpawns[Random.Range(0,CoinSpawns.Length)].position, rotation);
        Destroy(coin, 10f);

    }
}
