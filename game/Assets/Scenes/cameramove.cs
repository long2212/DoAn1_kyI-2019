using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public float smooth = 5.0f;
    public float speed = 0.5f;
    public float tiltAngle = 90.0f;
    public int move = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            this.transform.position = new Vector3(0, 3.5f, -20);
        }
        if (Input.GetKey(KeyCode.U))
        {
            this.transform.position = new Vector3(0, 203.5f, -20);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.position += new Vector3(-10, 0, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            transform.position += new Vector3(0, 10, 0) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKey(KeyCode.Keypad5))
            {
                transform.position += new Vector3(0, -20, 0) * Time.deltaTime * speed;
            }            
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.position += new Vector3(0, 0, 10) * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.position += new Vector3(0, 0, -10) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, 10f, 0f) * Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -10f, 0f) * Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(10f, 0f, 0f) * Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-10f, 0f, 0f) * Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0f, 0f, 10f) * Time.deltaTime * smooth);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0f, 0f, -10f) * Time.deltaTime * smooth);
        }

    }
}
