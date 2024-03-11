using UnityEngine;

namespace Retroskuff.Core.Input
{
    public class InputBehaviour : MonoBehaviour
    {
        private Controls _controls;

        public Controls Controls => _controls;

        private void Awake()
        {
            _controls = new Controls();
        }

        private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }
    }
}