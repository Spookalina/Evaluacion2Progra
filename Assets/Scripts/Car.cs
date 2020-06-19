using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int speed = 5;
    public Vector3 direction;
    public float timeForDestroy = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,timeForDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
}
