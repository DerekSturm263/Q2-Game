using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Room
{
    [SerializeField] private Grid<bool> _layout;
    public readonly Grid<bool> Layout => _layout;

    [SerializeField] private Directional<List<Grid<bool>>> _roomsToDirections;
    public readonly Directional<List<Grid<bool>>> RoomsToDirections => _roomsToDirections;
}