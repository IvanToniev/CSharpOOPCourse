using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassTheMaze
{
    public class Engine : IMoves
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;

        List<GameObject> staticObjects;
        Player player;

        public Engine(IRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();

            this.staticObjects = new List<GameObject>();
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }



        public virtual void AddObject(GameObject obj)
        {

            if (obj is Player)
            {
                AddRacket(obj);
                AddStaticObject(obj);

            }
            else
            {
                this.AddStaticObject(obj);
            }
        }

        private void AddRacket(GameObject obj)
        {
            //TODO: we should remove the previous racket from this.allObjects
            this.player = obj as Player;
        }
        static bool doorFlagClosed = true;
        public virtual void MovePlayerLeft()
        {
            bool flag = true;

            foreach (var item in staticObjects)
            {
                if (item is Block)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col - 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {
                        flag = false;
                        break;
                    }
                }
                else if (item is Exit)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col - 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row && doorFlagClosed)
                    {
                        flag = false;
                        break;
                    }
                    else if (!doorFlagClosed && item.GetTopLeft().Col == this.player.GetTopLeft().Col - 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {
                        Console.Clear();
                        throw new GameOverException("You Won!");
                    }
                }
                else if (item is Key)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col - 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {

                        item.IsDestroyed = true;
                        doorFlagClosed = false;
                        break;
                    }
                }
            }
            if (flag == true)
            {
                this.player.MoveLeft();
            }
        }

        public virtual void MovePlayerUp()
        {
            bool flag = true;
            foreach (var item in staticObjects)
            {
                if (item is Block)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row - 1)
                    {
                        flag = false;
                        break;
                    }
                }
                else if (item is Exit)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row - 1 && doorFlagClosed)
                    {
                        flag = false;
                        break;
                    }
                    else if (!doorFlagClosed && item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row - 1)
                    {
                        Console.Clear();
                        throw new GameOverException("You Won!");
                    }
                }
                else if (item is Key)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row - 1)
                    {

                        item.IsDestroyed = true;
                        doorFlagClosed = false;
                        break;
                    }
                }
            }
            if (flag == true)
            {
                this.player.MoveUp();
            }
        }

        public virtual void MovePlayerDown()
        {
            bool flag = true;
            foreach (var item in staticObjects)
            {
                if (item is Block)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row + 1)
                    {
                        flag = false;
                        break;
                    }
                }
                else if (item is Exit)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row + 1 && doorFlagClosed)
                    {
                        flag = false;
                        break;
                    }
                    else if (!doorFlagClosed && item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row + 1)
                    {
                        Console.Clear();
                        throw new GameOverException("You Won!");
                    }
                }
                else if (item is Key)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col && item.GetTopLeft().Row == this.player.GetTopLeft().Row + 1)
                    {

                        item.IsDestroyed = true;
                        doorFlagClosed = false;
                        break;
                    }
                }
            }
            if (flag == true)
            {
                this.player.MoveDown();
            }
        }

        public virtual void MovePlayerRight()
        {
            bool flag = true;

            foreach (var item in staticObjects)
            {
                if (item is Block)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col + 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {
                        flag = false;
                        break;
                    }
                }
                else if (item is Exit)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col + 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row && doorFlagClosed)
                    {
                        flag = false;
                        break;
                    }
                    else if (!doorFlagClosed && item.GetTopLeft().Col == this.player.GetTopLeft().Col + 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {
                        Console.Clear();
                        throw new GameOverException("You Won!");
                    }
                }
                else if (item is Key)
                {
                    if (item.GetTopLeft().Col == this.player.GetTopLeft().Col + 1 && item.GetTopLeft().Row == this.player.GetTopLeft().Row)
                    {

                        item.IsDestroyed = true;
                        doorFlagClosed = false;
                        break;
                    }
                }


            }
            if (flag == true)
            {
                this.player.MoveRight();
            }
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(500);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }



                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}

