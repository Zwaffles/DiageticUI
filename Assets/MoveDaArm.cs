using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDaArm : MonoBehaviour
{
    public float newYAngle;
    public float oldYAngle;

    private bool movingUp = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (!movingUp)
            {
                movingUp = true;
                StopAllCoroutines();
                StartCoroutine(Rotate(-83f));
            }

            else
            {
                movingUp = false;
                StopAllCoroutines();
                StartCoroutine(Rotate(0f));
            }
        }
    }

    IEnumerator Rotate(float targetAngle)
    {
        while (transform.rotation.x != targetAngle)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetAngle, 304f, 4f), 3f * Time.deltaTime);
            yield return null;
        }

        transform.rotation = Quaternion.Euler(targetAngle, 304f, 4f);
        yield return null;
    }
}
