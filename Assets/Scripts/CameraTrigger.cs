using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Transform cameraTransform;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Camera.main.transform.position = cameraTransform.transform.position;
            Camera.main.transform.rotation = cameraTransform.transform.rotation;
        }
    }
}
