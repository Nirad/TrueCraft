using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Blocks
{
    public class ObsidianBlock : BlockProvider
    {
        public static readonly byte BlockID = 0x31;
        
        public override byte ID { get { return 0x31; } }

        public override double Hardness { get { return 10; } }

        public override string DisplayName { get { return "Obsidian"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(5, 2);
        }
    }
}