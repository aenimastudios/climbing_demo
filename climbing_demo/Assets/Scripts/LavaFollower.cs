using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFollower : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start() {
        trans_ = transform;
        initPos_ = trans_.position;
    }

    // Update is called once per frame
    void Update()    {
        var pos = trans_.position;
        pos.y += Time.deltaTime * speed;
        trans_.position = pos;
    }

    public void SetInitPosition() {
        trans_.position = initPos_;
    }

    Transform trans_;
    Vector3 initPos_;
}
