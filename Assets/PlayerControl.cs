using UnityEngine;
using UnityEngine.UI;

public class PlayerCOntrol : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public Slider moveSlider;
    public Slider jumpSlider;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveSpeed = moveSlider.value * 10;
        jumpForce = jumpSlider.value * 10;

        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);

        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().linearVelocity = Vector2.up * jumpForce;
        }

    }
}
