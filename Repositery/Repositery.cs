using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tailoring.entity;
using System.Threading.Tasks;

namespace Tailoring.Repository
{
    public class Repositery
    {
        public static List<Cloth> cloths = new List<Cloth>();
         static Repositery()
        {
            cloths.Add(new Cloth {clothId=1, clothType = "shirt", Material = "spun", colour = "blue", price = 150 });
            cloths.Add(new Cloth {clothId=2, clothType = "Phant", Material = "cotton",  colour = "black", price = 300 });
            cloths.Add(new Cloth {clothId=3, clothType = "chudi", Material = "polistar",  colour = "green", price = 450 });
            cloths.Add(new Cloth {clothId=4, clothType = "Kurtha", Material = "Terry-cotton",  colour = "red", price = 250 });
        }
        public IEnumerable<Cloth> GetClothDetails()
        {
            return cloths;
        }
        public void AddCloth(Cloth cloth)
        {
            cloths.Add(cloth);
        }
        public Cloth GetClothId(int clothId)
        {
            return cloths.Find(id => id.clothId == clothId);
        }
        public void DeleteCloth(int clothId)
        {
            Cloth cloth = GetClothId(clothId);
            if (cloth != null)
                cloths.Remove(cloth);
        }
        public void UpdateCloth(Cloth cloth)
        {
            Cloth updateCloth = GetClothId(cloth.clothId);
            updateCloth.clothType = cloth.clothType;
            updateCloth.colour = cloth.colour;
            updateCloth.Material = cloth.Material;
            updateCloth.price = cloth.price;
            
        }
    }

}

