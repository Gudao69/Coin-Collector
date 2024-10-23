using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public int score;
    public int diamond;

    public Text scoreText;
    public Text diamondText;

    public string nextLevel;
    public string currentLevel;
    public int requireScoreForNextLevel;
    public float speed = 5f;
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        myRigidBody.AddForce(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


        /*float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput *= -1;

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;
        transform.Translate(transform.forward * verticalInput * speed * Time.deltaTime);
        transform.Translate(transform.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f); // Rotate to face right
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0f, -90f, 0f); // Rotate to face left
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Rotate to face front
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); // Rotate to face back
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Coin") )
        {
            score += 1;

            GameObject.Destroy(other.gameObject);
            scoreText.text = "Coin : " + score;

            if( score == requireScoreForNextLevel)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }


        if (other.CompareTag("Diamond"))
        {
            diamond += 1;
            GameObject.Destroy(other.gameObject);

            diamondText.text = "Diamond : " + diamond;
        }

        if (other.CompareTag("DeadZone"))
        {
            SceneManager.LoadScene(currentLevel);
        }
    }
}
