using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        transform.Rotate(0, _speed, 0);
    }
}
