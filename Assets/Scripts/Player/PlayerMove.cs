using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Speed flag
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Form speed vector
        var speedVector = speed * Time.deltaTime * Vector3.forward;

        // Move player
        transform.Translate(speedVector, Space.World);
    }
}
