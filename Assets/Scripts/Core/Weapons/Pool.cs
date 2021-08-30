using System.Collections.Generic;

namespace Core.Weapons
{
    public class Pool<T> where T : PooledObject
    {
        private readonly Queue<T> _inactiveObjects = new Queue<T>();

        public void AddObjectToPool(T obj)
        {
            _inactiveObjects.Enqueue(obj);
            obj.Disabled += OnDisabled;
        }

        private void OnDisabled(PooledObject obj)
        {
            ReturnObjectToPool(obj);
        }

        private void ReturnObjectToPool(PooledObject obj)
        {
            _inactiveObjects.Enqueue((T) obj);
        }

        public bool TryGetInactiveObject(out T pooledObject)
        {
            var hasObject = _inactiveObjects.Count > 0;
            
            pooledObject = hasObject ? _inactiveObjects.Peek() : null;

            return hasObject;
        }
    }
}