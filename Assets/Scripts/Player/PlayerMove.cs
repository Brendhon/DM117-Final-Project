using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Speed flag
    public float speed = 3;
    public float horizontalSpeed = 4;
    static public bool canMove = false;
    public GameObject charModel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if game object not reached the limit
        var reachedLeftLimit = this.gameObject.transform.position.x > LevelBoundary.leftSideLimit; 
        var reachedRigthLimit = this.gameObject.transform.position.x < LevelBoundary.rightSideLimit;

        // Form speed vector
        var speedVector = speed * Time.deltaTime * Vector3.forward;

        // Move player
        transform.Translate(speedVector, Space.World);

        if(canMove == true)
        {
            // If user press A or Left Arrow AND if game object not reached the limit - Moves to left
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && reachedLeftLimit)
            {

                // Form speed vector
                speedVector = horizontalSpeed * Time.deltaTime * Vector3.left;

                // Move player
                transform.Translate(speedVector, Space.World);
            }


            // If user press D or Right Arrow AND if game object not reached the limit - Moves to rigth 
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && reachedRigthLimit)
            {
                // Form speed vector
                speedVector = horizontalSpeed * Time.deltaTime * Vector3.right;

                // Move player
                transform.Translate(speedVector, Space.World);
            }

            if((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)))
            {
                charModel.GetComponent<Animator>().Play("Jump");
            }
        }
    }
}
