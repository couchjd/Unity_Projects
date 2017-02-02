using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {
    private float maxForwardSpeed;
    public float desiredMaxSpeed = 15.0f;
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftShift)){
            maxForwardSpeed = desiredMaxSpeed;
        }
    }
}
