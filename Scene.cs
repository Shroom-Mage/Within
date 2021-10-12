using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Scene
    {
        private LinkedList<Actor> _actors = new LinkedList<Actor>();
        private LinkedList<Actor> _addQueue = new LinkedList<Actor>();

        public virtual bool TimedUpdate()
        {
            foreach (Actor actor in _actors)
            {
                if (!actor.Active)
                    continue;

                actor.TimedUpdate();
            }

            foreach (Actor actor in _addQueue)
            {
                _actors.AddLast(actor);
            }
            _addQueue.Clear();

            return true;
        }

        public virtual void Update()
        {
            foreach (Actor actor in _actors)
            {
                if (!actor.Active)
                    continue;

                actor.Update();
            }
        }

        public virtual void Draw()
        {
            foreach (Actor actor in _actors)
            {
                if (!actor.Active)
                    continue;

                actor.Draw();
            }
        }

        public void AddActor(Actor actor)
        {
            _addQueue.AddLast(actor);
        }

        public Actor CheckPosition(int x, int y)
        {
            foreach (Actor actor in _actors)
            {
                if (actor.Active && actor.X == x && actor.Y == y)
                    return actor;
            }

            return null;
        }
    }
}
