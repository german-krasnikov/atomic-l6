// using Atomic.Entities;
// using Modules.Gameplay;
//
// namespace SampleGame
// {
//     public static class AmmoWeaponUseCase
//     {
//         public static bool AddClipsToCurrentWeapon(in IEntity entity, in int clips)
//         {
//             IEntity currentWeapon = entity.GetCurrentWeapon().Value;
//             if (currentWeapon == null)
//                 return false;
//                 
//             Ammo ammo = currentWeapon.GetAmmo();
//             return ammo.Add(clips);
//         }
//     }
// }