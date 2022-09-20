using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Engine
{
    interface GameObjectMethods
    {

        /// Returns list of entities of certain type.
        List<T> GetGameObjectList<T>() where T : GameObject;

        /// Checks if any instances of an entity exist.
        bool GameObjectExists<T>() where T : GameObject;

        /// Finds first entity of given type.
        T FindGameObject<T>() where T : GameObject;

        /// Returns list of entities, which have component - enabled or disabled - of given type.
        List<GameObject> GetGameObjectListByComponent<T>() where T : Component;


        /// Finds first entity, which has component - enabled or disabled -  of given type.
        GameObject FindGameObjectByComponent<T>() where T : Component;

        /// Returns list of components - enabled and disabled - of given type.
        List<Component> GetComponents<T>() where T : Component;


    }
}
