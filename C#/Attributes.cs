[System.Serializable] //requires using System;

[CreateAssetMenu(fileName = "SomeSettings", menuName = "SomeSettings", order = 1)]

[Header("A header")]

[Range(min, max)]

[SerializeField]

[HideInInspector]

[RequireComponent(typeof(Rigidbody))]