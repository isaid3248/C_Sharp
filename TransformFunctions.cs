using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float turnSpeed = 100f;
    public float playerJumpHeight = 20f;
    public float slowSpeed = 30f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //  transform.Translate(new Vector3(0,0,1) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        //  transform.Translate(new Vector3(0,0,-1) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        //  transform.Translate(new Vector3(0,1,0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        //  transform.Translate(new Vector3(0,-1,0) * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(Vector3.up * playerJumpHeight * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
            transform.Translate(-Vector3.up * playerJumpHeight * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightShift))
            transform.Translate(Vector3.forward * slowSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }

}
