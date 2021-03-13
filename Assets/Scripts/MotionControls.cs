using UnityEngine;

public class MotionControls : MonoBehaviour
{
    [SerializeField] private Quaternion baseRotaion = new Quaternion(0, 0, 1, 0);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /** Debugging */
        //rotation = new Vector3(gyroX * Time.deltaTime * speed, 0f, gyroZ * Time.deltaTime * speed).normalized;
        //gameObject.transform.Rotate(rotation);

    }
}
