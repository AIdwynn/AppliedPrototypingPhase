using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;

    void Update()
    {
        transform.rotation = (_mainCamera.transform.rotation);
    }
}
