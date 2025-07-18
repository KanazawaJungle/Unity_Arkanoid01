using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -4)
            {
                transform.position += (Vector3.left * speed * Time.deltaTime);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < 4)
            {
                transform.position += (Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}
