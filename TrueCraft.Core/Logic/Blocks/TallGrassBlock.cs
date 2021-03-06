using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class TallGrassBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x1F;
        
        public override byte ID { get { return 0x1F; } }

        public override double Hardness { get { return 0; } }

        public override string DisplayName { get { return "Tall Grass"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(7, 2);
        }
    }
}