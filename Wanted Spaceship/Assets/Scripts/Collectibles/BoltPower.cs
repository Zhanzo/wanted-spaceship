﻿using UnityEngine;

public class BoltPower : MonoBehaviour {

    public GameObject collected;
    private PlayerController player;

    void Start() {
        GameObject tmp = GameObject.FindGameObjectWithTag("Player");
        player = tmp.GetComponent<PlayerController>();
        if (player == null) {
            Debug.LogError("Unable to find the PlayerController script");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            player.StartCoroutine(player.StrongShots());
            Destroy(gameObject);
            GameObject tmp = Instantiate(collected, transform.position, transform.rotation);
            Destroy(tmp, 1);
        }
    }
}