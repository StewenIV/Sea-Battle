using UnityEngine;

namespace Assets
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private readonly DragAndDrop _dragAndDrop; 
        public NewBehaviourScript()
        {
            _dragAndDrop = new DragAndDrop();
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            _dragAndDrop.Action();
        }
    }
}
