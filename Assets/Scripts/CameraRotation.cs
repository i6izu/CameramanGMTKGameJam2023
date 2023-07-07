using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private int _speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * _speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * _speed);
        }
    }
}
