using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float maxHeight = 1f;
    public float minHeight = -1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);//belirli sure aral�g�nda spawn methodunun cagirilmasi icin.
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }



    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);//halihaz�rda olan prefab� klonlamak icin
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
