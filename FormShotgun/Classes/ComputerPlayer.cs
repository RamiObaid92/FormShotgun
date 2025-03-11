using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShotgun.Classes
{
    // Datorns klass som genererar ett slumpmässigt action val
    public class ComputerPlayer : Player
    {
        private Random random = new();
        public Action GenerateAction(int playerBullets)
        {
            List<Action> actions = new() { Action.Load };

            if(this.HasBullets() && playerBullets > 0)
            {
                actions.Add(Action.Block);
            }

            if (HasBullets())
            {
                actions.Add(Action.Shoot);
            }

            if (this.CanUseShotgun())
            {
                return Action.Shotgun;
            }

            int i = random.Next(actions.Count);

            return actions[i];
        }
    }
}
