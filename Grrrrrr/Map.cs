using Grrrrrr.Items;
using System.Collections.Generic;

namespace Grrrrrr
{
    public class Map
    {
        public List<Entity> Entities { get; set; }

        public Map()
        {
            Entities = new List<Entity>();
            LoadMap(false);
        }

        private void LoadMap(bool danielHasCreatedMapFromJson)
        {
            if(danielHasCreatedMapFromJson)
            {
                //Populate Entities from json file
            }
            else
            {
                AddWalls();
                AddDoors();
                AddItems();
            }
        }

        private void AddItems()
        {
            Entities.Add(new Key
            {
                PositionX = 6,
                PositionY = 5
            });
        }

        private void AddDoors()
        {
            Entities.Add(new Door
            {
                PositionX = 11,
                PositionY = 9,
                Locked = true
            });
        }

        private void AddWalls()
        {
            Entities = new List<Entity>
            {
                new Wall
                {
                    PositionX = 4,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 3
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 4
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 5
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 6
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 7
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 8
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 9
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 10
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 11
                },
                new Wall
                {
                    PositionX = 4,
                    PositionY = 12
                },


                new Wall
                {
                    PositionX = 5,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 6,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 7,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 8,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 9,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 10,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 2
                },

                new Wall
                {
                    PositionX = 11,
                    PositionY = 2
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 2
                },



                new Wall
                {
                    PositionX = 11,
                    PositionY = 3
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 4
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 5
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 6
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 7
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 8
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 10
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 11
                },
                new Wall
                {
                    PositionX = 11,
                    PositionY = 12
                },

                new Wall
                {
                    PositionX = 10,
                    PositionY = 12
                },
                new Wall
                {
                    PositionX = 9,
                    PositionY = 12
                },
                new Wall
                {
                    PositionX = 8,
                    PositionY = 12
                },
                new Wall
                {
                    PositionX = 7,
                    PositionY = 12
                },
                new Wall
                {
                    PositionX = 6,
                    PositionY = 12
                },
                new Wall
                {
                    PositionX = 5,
                    PositionY = 12
                },

            };
        }
    }
}
