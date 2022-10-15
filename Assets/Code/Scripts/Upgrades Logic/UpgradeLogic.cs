using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UpgradeLogic : MonoBehaviour
{
    [SerializeField] protected UpgradeSO upgrade;

    private IEnumerator coroutine;

    protected abstract void Tick();

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

            yield return new WaitForSeconds(GetWaitTime());
        }
    }

    private float GetWaitTime()
    {
        float time = 1f;

        return time;
    }
}
