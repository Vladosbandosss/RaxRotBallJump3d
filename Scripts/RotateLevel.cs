using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    //уровень крутитться
    public float sensitivity = 0.2f;

    private Vector3 mouseReferense;
    private Vector3 mouseOffset;
    private Vector3 rotation;

    private bool isRotating;

    private void Update()
    {
        if (isRotating)
        {
            mouseOffset = Input.mousePosition - mouseReferense;
            rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;

            transform.Rotate(rotation);

            mouseReferense = Input.mousePosition;
        }
    }

    private void OnMouseDown()
    {
        isRotating = true;
        mouseReferense = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        isRotating = false;

    }

    
}
