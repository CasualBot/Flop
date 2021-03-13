using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerGameObject;
    [SerializeField] public float cameraXOffset;
    [SerializeField] public float cameraYOffset;
    [SerializeField] public float cameraZOffset;



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Camera>().fieldOfView = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerGameObject != null)
        {
            float x = playerGameObject.transform.position.x + cameraXOffset;
            float y = playerGameObject.transform.position.y + cameraYOffset;
            float z = playerGameObject.transform.position.z + cameraZOffset;
            gameObject.transform.position = new Vector3(x, y, z);
        }

    }
}
