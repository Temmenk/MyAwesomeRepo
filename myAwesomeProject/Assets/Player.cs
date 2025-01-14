using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.W))
       {
            transform.position += Vector3.forward *.05f;
       } 

       if (Input.GetKey(KeyCode.S))
       {
            transform.position += Vector3.back *.05f;
       }
        
        if (Input.GetKey(KeyCode.A))
       {
            transform.position += Vector3.left *.05f;
       } 

        if (Input.GetKey(KeyCode.D))
       {
            transform.position += Vector3.right *.05f;
       } 
    }
}
