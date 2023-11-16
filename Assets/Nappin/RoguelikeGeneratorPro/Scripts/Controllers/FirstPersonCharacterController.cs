using UnityEngine;


namespace RoguelikeGeneratorPro
{
    [RequireComponent(typeof(Collider))]
    [RequireComponent(typeof(CharacterController))]
    public class FirstPersonCharacterController : MonoBehaviour
    {
        [Header("Movement controller")]
        public float speed = 5.0f;
        public float antiBump = 4.5f;
        public float gravity = 30.0f;

        private Vector3 moveDirection;
        private CharacterController controller;


        /**/


        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }


        #region Move

        private void Update()
        {
            if (controller.isGrounded)
            {
                Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                if (input.x != 0 && input.y != 0) input *= 0.777f;

                moveDirection = new Vector3(input.x * speed, -antiBump, input.y * speed);
                moveDirection = transform.TransformDirection(moveDirection);
            }
            else moveDirection.y -= gravity * Time.deltaTime;
        }


        private void FixedUpdate()
        {
            controller.Move(moveDirection * Time.deltaTime);
        }

        #endregion
    }
}