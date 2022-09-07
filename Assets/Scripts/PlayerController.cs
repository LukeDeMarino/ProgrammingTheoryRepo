using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int forceConst = 50;
    private float horizontalInput;
    private float verticalInput;
    public bool collision;
    private Rigidbody selfRigidbody;

    private float m_speed = 7f;
    public float speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_speed = value;
            }
        } 
    }    

    // Start is called before the first frame update
    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        Jump();
    }

    void PlayerMovement()
    {
        // Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
        // Player Movement
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && collision == true)
        {
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
            collision = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        collision = true;
    } 
}

