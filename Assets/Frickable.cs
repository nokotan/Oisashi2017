using UnityEngine;
using System.Collections;

public class Frickable : MonoBehaviour {

    private Vector3? PressStartPos;
    private Rigidbody Rigit;

	// Use this for initialization
	void Start () {
        Rigit = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(0)) {
            if (PressStartPos == null) {
                PressStartPos = Input.mousePosition;
            }
        } else {
            if (PressStartPos != null) {
                var Difference = Input.mousePosition - PressStartPos.Value;
                Difference = Quaternion.Euler(90.0f, 0.0f, 0.0f) * Difference;

                Rigit.AddForce(Difference);
                PressStartPos = null;
            }
        }
	}
}
