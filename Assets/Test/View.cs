using UnityEngine;
using VContainer;

namespace Test
{
    public class View: MonoBehaviour
    {
        [Inject] public Service Service { get; init; }

        private void Start()
        {
            Debug.Log(Service.Hello());
        }
    }
}