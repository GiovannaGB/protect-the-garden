using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    public GameObject slime;
    public float spawnRange = 20;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            float spawntime = Random.Range(1,5);
            float currentspawntime = 0; 
            while (currentspawntime < spawntime)
            {currentspawntime += Time.deltaTime;
            yield return null;
            }
            Instantiate(slime, transform.position + transform.right * Random.Range(-spawnRange,spawnRange), transform.rotation);
            yield return null;
        }

    }
}
