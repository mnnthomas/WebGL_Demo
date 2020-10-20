using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObRotate : MonoBehaviour
{
    [SerializeField] private Vector3 m_RotationVector;

    void Update()
    {
        transform.Rotate(new Vector3(m_RotationVector.x * Time.deltaTime, m_RotationVector.y * Time.deltaTime, m_RotationVector.z * Time.deltaTime));
    }
}
