using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        MoveObject();
    }

    private void MoveObject()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.World);
    }
}
