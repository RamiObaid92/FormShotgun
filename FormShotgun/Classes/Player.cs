using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShotgun.Classes
{
    public abstract class Player
    {
        public int Bullets { get; set; }

        public void IncreaseBullets(int bulletAmount)
        {
            Bullets += bulletAmount;
        }

        public void DecreaseBullets(int bulletAmount)
        {
            Bullets -= bulletAmount;
        }

        public bool HasBullets()
        {
            return Bullets > 0;
        }

        public bool CanUseShotgun()
        {
            return Bullets >= 3;
        }
    }
}
