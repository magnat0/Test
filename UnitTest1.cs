using NUnit.Framework;
using System.Drawing;
using Game;
namespace TestProject2
{
    public class Tests
    {
        public string[] map1 = {
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEIEEEEEEEEEEEEEEEEEEEEEEFEEEEEEEE",
"GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG" };

        public string[] map2 = {
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEX",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEPEIFEEEEEEEEEEEEEEEEEEEEEELEEEEEEE",
"GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG" };

        public string[] map3 = {
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEIEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEVEEEEEEEEEEEEEEEEEEEEEFEEEEEEEEE",
"GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG" };

        public string[] map4 = {
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE",
"EEEEEEIEEEEEEESEEEEEEEEEEEEEFEEEEEEEEE",
"GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG" };
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGoLeft()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X -model.Player.PlayerSpeed, model.Player.Hero.Location.Y);
            model.Player.Left = true;
            model.Movegame(size);
            Assert.AreEqual(point,model.Player.Hero.Location);
        }


        [Test]
        public void TestGoRight()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X + model.Player.PlayerSpeed, model.Player.Hero.Location.Y);
            model.Player.Right = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestJumpWhileOnTheGround()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X, model.Player.Hero.Location.Y - model.Player.JumpSpeed + 2);
            model.Player.Jump = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestJumpToTheLeft()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X - model.Player.PlayerSpeed*4, model.Player.Hero.Location.Y - model.Player.JumpSpeed + 2);
            model.Player.Jump = true;
            model.Player.Left = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
         public void TestJumpToTheRight()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X + model.Player.PlayerSpeed * 4, model.Player.Hero.Location.Y - model.Player.JumpSpeed + 2);
            model.Player.Jump = true;
            model.Player.Right = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestJumpLeftWitAcceleration()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X - (model.Player.PlayerSpeed+ 5) * 4, 
                model.Player.Hero.Location.Y - model.Player.JumpSpeed + 2);
            model.Player.Jump = true;
            model.Player.Boost = true;
            model.Player.Left = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestJumpRightWitAcceleration()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X + (model.Player.PlayerSpeed + 5) * 4,
                model.Player.Hero.Location.Y - model.Player.JumpSpeed + 2);
            model.Player.Jump = true;
            model.Player.Boost = true;
            model.Player.Right = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestGoLeftWitAcceleration()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X - (model.Player.PlayerSpeed + 5),
                model.Player.Hero.Location.Y);
            model.Player.Boost = true;
            model.Player.Left = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestGoRightWitAcceleration()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map1).Item2;
            model.Map = MakeMap.CreateGameMap(map1).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var point = new Point(model.Player.Hero.Location.X + (model.Player.PlayerSpeed + 5),
                model.Player.Hero.Location.Y);
            model.Player.Boost = true;
            model.Player.Right = true;
            model.Movegame(size);
            Assert.AreEqual(point, model.Player.Hero.Location);
        }

        [Test]
        public void TestInteractionWithFruit()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var fruit = model.Map.Find(x => x.Tag == Tags.KeySubject);
            var steps = (fruit.Location.X - model.Player.Hero.Location.X) / model.Player.PlayerSpeed;
            for (var i = 0; i < steps; i++)
            {
                model.Player.Right = true;
                model.Movegame(size);
            }
            Assert.IsTrue(model.Player.Win);
        }

        [Test]
        public void TestChangingTheLevelWhenWinning()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var fruit = model.Map.Find(x => x.Tag == Tags.KeySubject);
            var steps = (fruit.Location.X - model.Player.Hero.Location.X) / model.Player.PlayerSpeed;
            for (var i = 0; i < steps; i++)
            {
                model.Player.Right = true;
                model.Movegame(size);
            }
            model.Movegame(size);
            Assert.AreEqual(2,model.Level);
        }

        [Test]
        public void TestDeathWhenInteractingWithASaw()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var saw = model.Map.Find(x => x.Tag == Tags.Obstacle);
            var steps = (model.Player.Hero.Location.X - saw.Location.X ) / model.Player.PlayerSpeed - 1;
            for (var i = 0; i < steps; i++)
            {
                model.Player.Left = true;
                model.Movegame(size);
                model.Player.Left = false;
            }
            Assert.IsTrue(model.Player.Dead);
        }

        [Test]
        public void TestMovementLevHorObstacle()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var fireball = model.Map.Find(x => x.Tag == Tags.LevHorObstacle);
            var initialpoint = new Point(fireball.Location.X - 20,fireball.Location.Y);
            model.Movegame(size);
            Assert.AreEqual(initialpoint, model.Map.Find(x => x.Tag == Tags.LevHorObstacle).Location);
        }

        [Test]
        public void TestMovementLevVerObstacle()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            for (int i = 0; i < 10; i++)
                model.Movegame(size);
            var fireball = model.Map.Find(x => x.Tag == Tags.LevVertObstacle);
            var point = new Point(fireball.Location.X, fireball.Location.Y - 10);
            model.Movegame(size);
            Assert.AreEqual(point, model.Map.Find(x => x.Tag == Tags.LevVertObstacle).Location);
        }

        [Test]
        public void TestReturnToTheStartingPositionLevVerObstacle()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            var fireball = model.Map.Find(x => x.Tag == Tags.LevVertObstacle);
            var length = (fireball.ShowTheInitialLocation().Y) / fireball.Vspeed + 1;
            for (int i = 0; i <= length; i++)
                model.Movegame(size);
            Assert.AreEqual(fireball.ShowTheInitialLocation(), model.Map.Find(x => x.Tag == Tags.LevVertObstacle).Location);
        }

        [Test]
        public void TestReturnToTheStartingPositionLevHorObstacle()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map2).Item2;
            model.Map = MakeMap.CreateGameMap(map2).Item1;
            var fireball = model.Map.Find(x => x.Tag == Tags.LevHorObstacle);
            var length = (fireball.ShowTheInitialLocation().X) / fireball.Hspeed + 1;
            for (int i = 0; i <= length; i++)
                model.Movegame(size);
            Assert.AreEqual(fireball.ShowTheInitialLocation(), model.Map.Find(x => x.Tag == Tags.LevHorObstacle).Location);
        }

        [Test]
        public void TestMovementOnALevitatingPlatform()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map3).Item2;
            model.Map = MakeMap.CreateGameMap(map3).Item1;
            for (int i = 0; i < 50; i++)
                model.Movegame(size);
            var newpoint = model.Map.Find(x => x.Tag == Tags.LevitatingVertical).Location;
            Assert.AreEqual(model.Player.Hero.Location.Y, newpoint.Y- model.Player.Hero.Height);
        }

        [Test]
        public void TestMovementOfStones()
        {
            var model = new Model(1, 1);
            Size size = new Size(1820, 880);
            model.Player = MakeMap.CreateGameMap(map4).Item2;
            model.Map = MakeMap.CreateGameMap(map4).Item1;
            var point = model.Map.Find(x => x.Tag == Tags.Opponent).Location;
            for (int i = 0; i < 5; i++)
                model.Movegame(size);
            var newpoint = model.Map.Find(x => x.Tag == Tags.Opponent).Location;
            Assert.AreEqual(newpoint, new Point(point.X+4*5,point.Y));
        }
    }
}