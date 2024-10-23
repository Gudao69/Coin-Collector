using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform camTransform;
    public Transform playerTransform;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = GetComponent<Transform>();

        offset = camTransform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        camTransform.position = playerTransform.position + offset ;
    }
}
