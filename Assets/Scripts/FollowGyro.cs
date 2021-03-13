using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    private Quaternion baseRotation = new Quaternion(0, 1, 1, 0);

    private void Start()
    {
        GyroManager.Instance.EnableGyro();
    }

    private void Update()
    {
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
    }
}
