using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class SugarcaneBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x53;
        
        public override byte ID { get { return 0x53; } }

        public override double Hardness { get { return 0; } }

        public override string DisplayName { get { return "Sugar cane"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(9, 4);
        }
    }
}