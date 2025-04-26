using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    //private bool isVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.z < 4.25)
        {
            GetComponent <MeshRenderer>().enabled = true;
        }
        transform.position += new Vector3(0, 0, -.03f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (!collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
        
    }
    
}
