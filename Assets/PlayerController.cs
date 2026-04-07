using UnityEngine;
using UnityEngine.InputSystem;
using URC.Utility;

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
        _moveInput = GetDirection();
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
 

    }


    private void PlayerMovement()
    {
        _rb.MovePosition(_rb.position + _moveInput * _moveSpeed * Time.fixedDeltaTime);
    }

    private Vector3 GetDirection()
    {
        Vector3 worldDir = InputHelper.DesiredDirection().normalized;
        return transform.TransformDirection(worldDir);
    }
}
