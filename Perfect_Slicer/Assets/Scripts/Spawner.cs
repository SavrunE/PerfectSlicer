using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnTemplate;
    [SerializeField] private GameObject parant;
    [SerializeField] private float spawnDelay;


    private IEnumerator Start()
    {
        if (spawnDelay == 0)
        {
            spawnDelay = 0.1f;
            Debug.Log("spawnDelay == 0.1");
        }
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Instantiate(spawnTemplate, transform.position, Quaternion.identity, parant.transform);
        }
    }
}
