using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    float hits = -1f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into things this amount of times: " + hits);
        }
    }
}
