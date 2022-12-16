using UnityEngine;

public class SimpleEmitterMover : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        ProcessReset();
        ProcessMove();
    }

    private void ProcessReset()
    {
        if (Input.GetKeyDown(KeyCode.R))
            transform.position = Vector3.zero;
    }

    private void ProcessMove()
    {
        var dir = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            dir += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            dir += Vector3.down;
        }

        dir.Normalize();

        transform.position += dir * Speed;
    }
}