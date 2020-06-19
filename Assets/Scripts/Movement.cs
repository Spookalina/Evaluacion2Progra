using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {
            Debug.Log("Auch!");
        }
        else if(collision.gameObject.CompareTag("Meta"))
        {
            Debug.Log("Lo Conseguiste!!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(0.5f, 0);
        }
    }
}
