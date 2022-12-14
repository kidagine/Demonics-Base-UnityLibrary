using System.Collections.Generic;
using UnityEngine;

namespace Demonics.Manager
{
public class ObjectPoolingManager : MonoBehaviour
{
	[SerializeField] private List<ObjectPool> _objectPools;
	[SerializeField] private Dictionary<string, Queue<GameObject>> _objectPoolDictionary = new Dictionary<string, Queue<GameObject>>();
	private List<GameObject> _objects = new List<GameObject>();
	public static ObjectPoolingManager Instance { get; private set; }


        void Awake()
        {
            CheckInstance();
        }

        void Start()
        {
            foreach (ObjectPool objectPool in _objectPools)
            {
                Queue<GameObject> objectPoolQueue = new Queue<GameObject>();
                for (int i = 0; i < objectPool.size; i++)
                {
                    GameObject poolObject = Instantiate(objectPool.prefab, transform);
                    poolObject.SetActive(false);
                    objectPoolQueue.Enqueue(poolObject);
                    _objects.Add(poolObject);
                }
                _objectPoolDictionary.Add(objectPool.prefab.name, objectPoolQueue);
            }
        }

        private void CheckInstance()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }

        public void SetObject(string name, bool active)
        {
            if (_objectPoolDictionary.ContainsKey(name))
            {
                GameObject poolObject = _objectPoolDictionary[name].Dequeue();
                poolObject.SetActive(active);
            }
        }

        public void DisableAllObjects()
        {
            for (int i = 0; i < _objects.Count; i++)
            {
                if (_objects[i] != null)
                {
                    _objects[i].SetActive(false);
                }
            }
        }
    }
}
