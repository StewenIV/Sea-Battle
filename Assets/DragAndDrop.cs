using UnityEngine;

namespace Assets
{
    public class DragAndDrop
    {
        enum State
        {
            None = 0,
            Drag = 1,
        }

        private State _state;
        GameObject _item;

        public DragAndDrop()
        {
            _state = State.None;
            _item = null;
        }

        // ReSharper disable Unity.PerformanceAnalysis
        public bool Action()
        {
            switch (_state)
            {
                case State.None:
                    if (isMouseButtonPressed())
                        PickUp();
                    break;
                case State.Drag:
                    /*    if (IsMouseButtonPressed())
                            Drag();
                    else{
                    Drop()
                    return true;} */
                    break;
            }

            return false;
        }

        private bool isMouseButtonPressed()
        {
            return Input.GetMouseButton(0);
        }

        void PickUp()
        {
            Vector2 clickPosition = GetClickPosition();
            var clickedItem = GetItemAt(clickPosition);
            if (clickedItem == null) return;
            _item = clickedItem.gameObject;
            _state = State.Drag;
            Debug.Log(_item.name);
        }

        Vector2 GetClickPosition()
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        Transform GetItemAt(Vector2 position)
        {
            RaycastHit2D[] figures = Physics2D.RaycastAll(position, Vector2.zero, 0.5f);
            if (figures.Length == 0)
            {
                return null;
            }
            else
                return figures[0].transform;
        }
    }
}