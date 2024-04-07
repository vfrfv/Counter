using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _counter = 0;
    private bool _active = false;
    private Coroutine _coroutine;

    private void Update()
    {
        Debug.Log(_counter);
    }

    private void OnMouseDown()
    {
        if (_active == false)
        {
            _coroutine = StartCoroutine(StartCountdown());
            _active = true;
        }
        else
        {
            StopCoroutine(_coroutine);
            _active = false;
        }
    }

    private IEnumerator StartCountdown()
    {
        float amountDelay = 0.5f;
        var delay = new WaitForSeconds(amountDelay);

        while (true)
        {
            _counter++;

            yield return delay;
        }
    }
}
