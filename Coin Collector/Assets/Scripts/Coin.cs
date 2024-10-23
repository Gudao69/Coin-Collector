using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Transform coinTransform;

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        coinTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        coinTransform.Rotate(rotationSpeed *Time.deltaTime  , rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
    }
}
