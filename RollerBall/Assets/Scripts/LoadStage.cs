using UnityEngine;
using System.Collections;

public class LoadStage : MonoBehaviour {
    public string scene = "none";
    
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(scene);    
    }
}
