using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 6f;

    private float horizontalDirection;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalDirection = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalDirection, 0, 0) * speed * Time.deltaTime);
        
    }

}


