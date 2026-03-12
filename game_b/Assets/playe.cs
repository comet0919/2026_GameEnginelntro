using UnityEngine;
using UnityEngine.InputSystem;

public class playe : MonoBehaviour
{
    private Vector2 movelnput;
    public float moveSpssd = 7f;
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
    }
}
