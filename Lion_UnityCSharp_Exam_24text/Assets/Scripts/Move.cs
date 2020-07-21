
using UnityEngine;

public class Move : MonoBehaviour
{
    float t = 0.05f;
    Vector3 targetPosition = new Vector3(400, 200, -8);
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, t);
    }
}
