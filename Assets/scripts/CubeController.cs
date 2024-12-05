using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        MoveForward();

        RotateObject();

        ScaleObject();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime, Space.World);
    }

    private void RotateObject()
    {
        transform.Rotate(0, _speedRotation, 0);
    }

    private void ScaleObject()
    {
        transform.localScale += Vector3.one * _speedScale * Time.deltaTime;
    }
}
