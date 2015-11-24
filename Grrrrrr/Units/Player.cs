using Grrrrrr.Events;
using Grrrrrr.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grrrrrr
{
    public class Player : Unit
    {
        public List<Item> Inventory { get; set; }

        public Player()
        {
            Color = ConsoleColor.Green;
            Inventory = new List<Item>();
        }

        public override void Move(int X, int Y, Map map)
        {
            Goal goal = (Goal)map.Entities.First(x => x is Goal);

            if(goal.PositionX == PositionX + X && goal.PositionY == PositionY + Y)
            {
                map.Interface = "You win!";
            }

            List<Entity> doors = map.Entities.Where(x => x is Door).ToList();
            Door door;
            if((door = (Door)doors.FirstOrDefault(x => x.PositionX == PositionX + X && x.PositionY == PositionY + Y && ((Door)x).Locked)) != null)
            {
                Key key;
                if((key = (Key)Inventory.FirstOrDefault(x => x is Key)) != null)
                {
                    door.Locked = false;
                    Inventory.Remove(key);
                }
                else
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\..\..\Content\Sound\LockedDoor.wav");
                    player.Play();
                    return;
                }
            }
            Item item;
            if((item = (Item)map.Entities.FirstOrDefault(x => x is Item && x.PositionX == PositionX + X && x.PositionY == PositionY + Y)) != null)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\..\..\Content\Sound\PickupKeys.wav");
                player.Play();
                Inventory.Add(item);
                map.Entities.Remove(item);
            }
            base.Move(X, Y, map);
        }
    }
}
