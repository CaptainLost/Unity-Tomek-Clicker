using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public abstract class UpgradeLogic : MonoBehaviour
{
    [SerializeField] protected float tickTime;

    private IEnumerator coroutine;

    protected abstract void Tick();

    public abstract BigDouble CalculateTickPoints();
    public abstract BigDouble CalulateClickPoints();

    public float TickTime { get { return tickTime; } }

    private void Start()
    {
        coroutine = Coroutine();
        StartCoroutine(coroutine);
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }

    private IEnumerator Coroutine()
    {
        while (true)
        {
            Tick();

            yield return new WaitForSeconds(tickTime);
        }
    }
}
