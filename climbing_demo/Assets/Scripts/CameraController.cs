using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTrans;
    public float accelerometerFactor;
    public float smoothTime;

    private void Awake() {
        trans_ = transform;
    }

    private void LateUpdate() {
        var pos = playerTrans.position;
        pos.z = trans_.position.z;
        trans_.position = pos;
        float velocity = 0;
        var angle = Mathf.SmoothDampAngle(trans_.rotation.eulerAngles.z, Input.acceleration.x * accelerometerFactor, ref velocity, smoothTime);
        trans_.rotation = Quaternion.Euler(0, 0, angle);
    }

    Transform trans_;
}
