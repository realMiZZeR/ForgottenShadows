using Retroskuff.Core.Input;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Retroskuff.Modules.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private InputBehaviour _input;
        private Vector2 _moveDirection;

        [Inject]
        public void Construct(InputBehaviour controls)
        {
            _input = controls;
        }

        private void Update()
        {
        }

        private void OnEnable()
        {
            _input.Controls.Player.Move.performed += OnMove;
        }

        private void OnDisable()
        {
            _input.Controls.Player.Move.performed -= OnMove;
        }

        private void OnMove(InputAction.CallbackContext context)
        {
            _moveDirection = context.ReadValue<Vector2>();
            Debug.Log(_moveDirection);
        }
    }
}