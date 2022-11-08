using Core;
using UnityEngine;

public class StartUp : MonoBehaviour
{
    private LogHealthSystem _healthSystem;
    private void Awake()
    {
        Contexts ctx = Contexts.sharedInstance;
        _healthSystem = new LogHealthSystem(ctx);
    }

    private void Update()
    {
        _healthSystem.Execute();
    }
}
