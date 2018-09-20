﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace UnityChan
{
    public class FloorSlideMove : MonoBehaviour
    {
        private CharacterController characterController;
        private Rigidbody rb;
        private Vector3 pos;

        private Vector3 velocity = Vector3.zero;
        private Vector3 floorMoveDirection;
        private bool isSlideFloor = false;

        private void Start()
        {
            this.rb = GetComponent<Rigidbody>();
            this.pos = transform.position;
        }

        private void FixedUpdate()
        {
            this.rb.MovePosition(new Vector3(this.pos.x, this.pos.y, this.pos.z + Mathf.PingPong(Time.time*1.5f, 2)));
        }

    }
}
