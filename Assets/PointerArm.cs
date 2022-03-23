using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArm : MonoBehaviour
{
    private bool movingIn = false;
    Vector3 mouse_pos;
    Vector3 object_pos;
    float angle;

    private void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (!movingIn)
            {
                movingIn = true;
                StopAllCoroutines();
                StartCoroutine(Move(-2.65f));
            }

            else
            {
                movingIn = false;
                StopAllCoroutines();
                StartCoroutine(Move(-4f));
            }
        }
    }

    IEnumerator Move(float targetPosition)
    {
        while (transform.rotation.x != targetPosition)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(targetPosition, 2.18f, 2.3f), 3f * Time.deltaTime);
            yield return null;
        }

        transform.position = new Vector3(targetPosition, 2.18f, 2.3f);
        yield return null;
    }
}
