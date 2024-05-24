using System;
using System.Collections.Generic;

namespace ECS_dice_game_2
{
    public class Entity
    {
        public int Id;
        private Dictionary<Type, object> components = new Dictionary<Type, object>();

        public Entity(int id)
        {
            Id = id;
        }

        public void AddComponent<T>(T component)
        {
            components[typeof(T)] = component;
        }

        public T GetComponent<T>() where T : class
        {
            if (components.TryGetValue(typeof(T), out var component))
            {
                return component as T;
            }
            return null;
        }
    }
}
