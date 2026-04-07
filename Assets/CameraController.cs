using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float _sensitivityX;
    public float _sensitivityY;

    public Transform _orientation;

    private float _mouseX;
    private float _mouseY;

    private float _xRotation;
    private float _yRotation;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MouseController();
    }


    void MouseController()
    {
        _mouseX = Input.GetAxisRaw("Mouse X") * Time.fixedDeltaTime * _sensitivityX;
        _mouseY = Input.GetAxisRaw("Mouse Y") * Time.fixedDeltaTime * _sensitivityY;


        _yRotation += _mouseX;
        _xRotation -= _mouseY;

        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
        _orientation.rotation = Quaternion.Euler(0, _yRotation, 0);
    }
}
