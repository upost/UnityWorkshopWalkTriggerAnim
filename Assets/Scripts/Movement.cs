using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{

    private Vector3 moveDirection = Vector3.zero;

    public GameObject animatedCharacter;
    public float speed=5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        moveDirection = new Vector3(-inputVector.x, 0, -inputVector.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().linearVelocity = moveDirection * speed;
        Animator a = animatedCharacter.GetComponent<Animator>();
        if (moveDirection.magnitude != 0)
        {
            a.Play("Walking");
        } else
        {
            a.Play("Standing");
        }
        
    }
}
