using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            SceneManager.LoadScene("start");
        }
    }
}
