using NUnit.Framework;

namespace TicTacToeApp
{
    [TestFixture]
    public class UnitTest1
    {
        /// <summary>
        ///     a game is over when all fields in a row are taken by a player
        ///     players take turns taking fields until the game is over
        ///     a game is over when all fields in a diagonal are taken by a player
        ///     game is over when all fields are taken
        ///     there are two players in the game(X and O)
        ///     a game has nine fields in a 3x3 grid
        ///     a game is over when all fields in a column are taken by a player
        ///     a player can take a field if not already taken
        /// 
        ///     outputs
        ///     x wins, o wins, draw
        /// </summary>
        [Test]
        public void TestMethod1()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.OIsWinner = true;
            Assert.AreEqual(true, tickTackToe.OIsWinner);
        }
        [Test]
        public void TestMethod2()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.XIsWinner = true;
            Assert.AreEqual(true, tickTackToe.XIsWinner);
        }
        [Test]
        public void TestMethod3()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.IsDraw = true;
            Assert.AreEqual(true, tickTackToe.IsDraw);
        }
        [Test]
        public void TestMethod4()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.IsDiagonalWin = true;
            Assert.AreEqual(true, tickTackToe.IsDiagonalWin);
        }

        [Test]
        public void TestMethod5()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.IsRowWin = true;
            Assert.AreEqual(true, tickTackToe.IsRowWin);
        }

        [Test]
        public void TestMethod6()
        {
            var tickTackToe = new tickTacToe();
            tickTackToe.IsColWin = true;
            Assert.AreEqual(true, tickTackToe.IsColWin);
        }
    }

    internal class tickTacToe
    {
        public bool IsRowWin { get; set; }
        public bool IsColWin { get; set; }
        public bool IsDiagonalWin { get; set; }

        public bool XIsWinner { get; set; }

        public  bool OIsWinner { get; set; }
        public bool IsDraw { get;  set; }
    }
}
