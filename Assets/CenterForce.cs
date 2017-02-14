using UnityEngine;
using System.Collections;

public class CenterForce : MonoBehaviour {

    private Rigidbody Rigit;

    public Vector3 CenterPosition;
    public float Magnitude;

    // Use this for initialization
    void Start () {
        Rigit = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        var TransForm = GetComponent<Transform>();
        var CenterDirection = CenterPosition - transform.position;

        if (CenterDirection.sqrMagnitude > 0.001f) {
            Rigit.AddForce(CenterDirection.normalized * Magnitude);
        }
	}
}
