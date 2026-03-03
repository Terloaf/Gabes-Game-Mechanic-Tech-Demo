using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    public int _moveSpeed;

    Vector3 _moveInput;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector3>();
    }


    private void PlayerMovement()
    {
        _rb.MovePosition(_rb.position + _moveInput * _moveSpeed * Time.fixedDeltaTime);
    }
}
