using UnityEngine;
using UnityEngine.InputSystem;

public class playe : MonoBehaviour
{
    private Vector2 movelnput;
    public float moveSpssd = 7f;
    public float JumpForce = 7f;
    private Rigidbody2D rd;
    private Animator myAnimator;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("move", false);
    }

    public void OnMowe(InputValue value)
    {
        movelnput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        rd.linearVelocity = new Vector2(rd.linearVelocity.x, JumpForce);
    }
    public void OnMove(InputValue value)
    {
        movelnput = value.Get<Vector2>();
    }
    void Update()
    {
        if(movelnput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(movelnput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.Translate(Vector3.right * moveSpssd * movelnput.x * Time.deltaTime);

        if(movelnput.magnitude > 0)
        {
            myAnimator.SetBool("move", true);
        }
        else
        {
            myAnimator.SetBool("move", false);
        }
        transform.Translate(Vector3.right * moveSpssd * movelnput.x * Time.deltaTime);
    }
}
