using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 3f;
    
    private void Update()
    {
        var yRot = transform.localRotation.eulerAngles + new Vector3(0, speed * Time.deltaTime, 0);
        transform.localRotation = Quaternion.Euler(yRot);
    }
}
