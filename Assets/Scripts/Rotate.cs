using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeedValue = 10;
    float rotSpeed;

    public void RotateClockwise()
    {
        rotSpeed = rotSpeedValue;
    }

    public void RotateCounterClockwise()
    {
        rotSpeed = -rotSpeedValue;
    }

    public void StopRotation()
    {
        rotSpeed = 0;
    }

    void Update()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
    }
}
