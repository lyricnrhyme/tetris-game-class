using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Shape[] m_allShapes;

    Shape GetRandomrShape () {
        int i = Random.Range (0, m_allShapes.Length);
        if (m_allShapes[i]) {
            return m_allShapes[i];
        } else {
            Debug.Log ("WARNING! Invalid shape!");
            return null;
        }
    }

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}