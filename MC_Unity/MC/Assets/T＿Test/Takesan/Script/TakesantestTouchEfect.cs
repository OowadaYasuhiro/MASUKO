using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakesantestTouchEfect : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] Camera _camera;

    // Update is called once per frame
    void Update()
    {
        if (TakesantestInput.Touchbegan == true)
        {
            var pos = _camera.ScreenToWorldPoint((Vector3)TakesantestInput.Touchposition + _camera.transform.forward * 5);
            particle.transform.position = pos;
            particle.Emit(1);
        }
    }
}
