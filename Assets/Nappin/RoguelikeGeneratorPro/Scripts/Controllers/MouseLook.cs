using UnityEngine;


namespace RoguelikeGeneratorPro
{
    public class MouseLook : MonoBehaviour
    {
        [Header("Rotation controller")]
        public Vector2 clampInDegrees = new Vector2(360, 180);
        public Vector2 sensitivity = new Vector2(1, 1);
        public Vector2 smoothing = new Vector2(3, 3);

        private GameObject characterBody;
        private Vector2 mouseAbsolute;
        private Vector2 smoothMouse;
        private Vector2 targetDirection;
        private Vector2 targetCharacterDirection;


        /**/


        void Start()
        {
            characterBody = this.transform.parent.gameObject;

            targetDirection = transform.localRotation.eulerAngles;
            targetCharacterDirection = characterBody.transform.localRotation.eulerAngles;
        }


        #region Rotate

        void LateUpdate()
        {
            Cursor.visible = false;

            var targetOrientation = Quaternion.Euler(targetDirection);
            var targetCharacterOrientation = Quaternion.Euler(targetCharacterDirection);
            var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));
            smoothMouse.x = Mathf.Lerp(smoothMouse.x, mouseDelta.x, 1f / smoothing.x);
            smoothMouse.y = Mathf.Lerp(smoothMouse.y, mouseDelta.y, 1f / smoothing.y);
            mouseAbsolute += smoothMouse;

            if (clampInDegrees.x < 360) mouseAbsolute.x = Mathf.Clamp(mouseAbsolute.x, -clampInDegrees.x * 0.5f, clampInDegrees.x * 0.5f);
            if (clampInDegrees.y < 360) mouseAbsolute.y = Mathf.Clamp(mouseAbsolute.y, -clampInDegrees.y * 0.5f, clampInDegrees.y * 0.5f);
            transform.localRotation = Quaternion.AngleAxis(-mouseAbsolute.y, targetOrientation * Vector3.right) * targetOrientation;

            var yRotation = Quaternion.AngleAxis(mouseAbsolute.x, Vector3.up);
            characterBody.transform.localRotation = yRotation * targetCharacterOrientation;
        }

        #endregion
    }
}