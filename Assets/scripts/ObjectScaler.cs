using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        ScaleObject();
    }

    private void ScaleObject()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
