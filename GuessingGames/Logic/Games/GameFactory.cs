using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGames.Logic.Games
{
    public class GameFactory
    {
        public List<System.Type> ListGames()
        {
            var list = this.GetType().Assembly.GetTypes().Where(b => b.BaseType.Name == "GuessingGame").ToList();
            return list;
        }

        internal dynamic NewGame(string gameType)
        {
            var g = this.GetType().Assembly.GetTypes().Where(b => b.Name == gameType).FirstOrDefault();
            if (g != null)
            {
                return Activator.CreateInstance(g,
                    BindingFlags.CreateInstance |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.OptionalParamBinding, null, new object[] { Type.Missing }, CultureInfo.CurrentCulture);
            }

            return new EasyGame();

        }
    }
}
