using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public List<GameObject> targets = new List<GameObject>();

    private void Awake()
    {
        foreach (GameObject gameObject in targets) gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (GameObject gameObject in targets) gameObject.SetActive(true);
    }
}
