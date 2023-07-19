using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)

    [SerializeField]
    private Toaster _toaster;

    [SerializeField] 
    private Waffle _waffle;

    [SerializeField] 
    private Transform _location;

    private void Start()
    {
        _toaster.TimerIsUp += CreateWaffle;
    }

    private void CreateWaffle()
    {
        Instantiate(_waffle, _location);
    }
}