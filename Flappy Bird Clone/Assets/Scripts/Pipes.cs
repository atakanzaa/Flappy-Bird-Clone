using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; //arkamizda kalan borularin hangi mesafede 
        //destroy edilecegini belirliyoruz  
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; //pipelarin sola dogru hareketi
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
