﻿using UnityEngine;

public class Chain : MonoBehaviour
{
    public float speed = 3f;

    public Transform player;

    public static bool IsFired;

    void Start()
    {
        IsFired = false;
    }

    void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
            IsFired = true;
		}

		if (IsFired)
		{
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
		}
		else
		{
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
		}
    }
}
