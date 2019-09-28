using UnityEngine;

public class DotEyeDirection : MonoBehaviour
{
    [SerializeField]
    Transform targetTransform;
    
    [SerializeField]
    float eyeDirectionRange = 0.9;

    Transform cameraDirection;

    void Start()
    {
        cameraDirection = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 targetToCameraDirection_N = (cameraDirection.position - targetTransform.position).normalized;

        if (Vector3.Dot(targetToCameraDirection_N, cameraDirection.forward.normalized) < -eyeDirectionRange)
        {
            print("Looked!");
        }
    }
}