using System;

namespace EchterTheGungeon
{
    public class EchterTheGungeon : ETGModule
    {
        public override void Init()
        {
            Console.WriteLine("Initialized (EchterTG)");
        }

        public override void Start()
        {
            Console.WriteLine("Started (EchterTG)");
        }

        public override void Exit()
        {
        }
    }
}