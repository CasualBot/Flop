using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        Screen.sleepTimeout = -1;
    }
}
