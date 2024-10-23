using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ComponentTesting : MonoBehaviour
{
    public Transform myTransform;
    public MeshRenderer myRender;
    public Collider myCollider;

    public int myX;
    public int myY;
    public int myZ;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;

        myTransform = GetComponent<Transform>();
     


        myTransform.position = new Vector3(myX, myY, myZ);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
