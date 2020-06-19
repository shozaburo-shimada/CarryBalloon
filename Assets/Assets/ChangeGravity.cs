using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour {
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rBody;
    GameObject refObj;

    // Use this for initialization
    private void Start() {
        rBody = this.GetComponent<Rigidbody>();
        rBody.useGravity = false; //最初にrigidBodyの重力を使わなくする

        refObj = GameObject.Find("MenuWindow");
    }

    private void FixedUpdate() {
        SetLocalGravity(); //重力をAddForceでかけるメソッドを呼ぶ。FixedUpdateが好ましい。
    }

    private void SetLocalGravity() {
        //MenuWindow mw = refObj.GetComponent<MenuWindow>();
        //localGravity.x = 0;
        //localGravity.y = -mw.gravityValue;
        //localGravity.z = 0;

        rBody.AddForce(localGravity, ForceMode.Acceleration);
    }
}
