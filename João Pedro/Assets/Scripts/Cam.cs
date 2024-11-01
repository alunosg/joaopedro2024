using UnityEngine;

public class Cam : MonoBehaviour
{
 public float mouseSensivity = 100f;

 public Transform playerBody;

 float xRotation = 0f;
        


    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        //Debug.Log($"Mouse X { mouseX }, Mouse Y : { mouseY }");
    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    transform.localRotation= Quaternion.Euler(xRotation, 0f, 0f);
    playerBody.Rotate(Vector3.up * mouseX);
    }
    
}