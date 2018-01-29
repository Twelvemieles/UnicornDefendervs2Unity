using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitBullet : MonoBehaviour {

	void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
