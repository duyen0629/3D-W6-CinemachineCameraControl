using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform targetObject;
    void Update()
    {
        transform.LookAt(targetObject);
    }
}
