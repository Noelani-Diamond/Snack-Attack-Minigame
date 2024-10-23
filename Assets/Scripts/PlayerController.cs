using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xRange = 9;
    public float zRange = 10;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        
        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        else if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        

        
    }

        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Good")
            {
                score = score + 1;
                Debug.Log(score);

            }
            else if(other.gameObject.tag == "Bad")
            {
                score = score -1;
                if(score < 0)
                {
                    score = 0;
                }
                Debug.Log(score);
            }

            
        }

}
