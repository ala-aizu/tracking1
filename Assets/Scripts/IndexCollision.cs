using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IndexCollision : MonoBehaviour
{
    private bool isTouching = false;
    public UnityEvent onTouch;
    public GameObject prefabToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "index" && !isTouching)
        {
            isTouching = true;
            Debug.Log("index collision");
            onTouch?.Invoke();
            if (prefabToSpawn != null)
            {
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "index")
        {
            isTouching = false;
        }
    }
}
