// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class KnowYourElements
    {
        public static class Perk
        {
            private static FormLink<IPerkGetter> Construct(uint id) => new FormLink<IPerkGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPerkGetter> kye_perk_earth_elemental => Construct(0x5904);
            public static FormLink<IPerkGetter> kye_perk_water_elemental => Construct(0x590b);
            public static FormLink<IPerkGetter> kye_perk_wind_elemental => Construct(0x590c);
        }
    }
}