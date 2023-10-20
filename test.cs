using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bossbgm.SceneEffects
{
    public class EOC : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot("mod, Assets\\Music\\ENNWAY - Breaking The Seal");
    }
}
