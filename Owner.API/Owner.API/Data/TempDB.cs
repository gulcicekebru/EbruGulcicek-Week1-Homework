using Owner.API.Model;
using System.Collections.Generic;

namespace Owner.API.Data
{
    public class TempDB
    {
      
        public List<OwnerModel> GetOwnerModels()
        {
            return new List<OwnerModel>
            {
                new OwnerModel
                {
                    Id=1,
                    Name="Ebru",
                    Surname="Gülçiçek",
                    Date="29/10/2022",
                    Explanation="Papara .NET Bootcamp",
                    Type="Computer Engineer"
                },
                new OwnerModel
                {
                    Id=2,
                    Name="Emin",
                    Surname="Çapa",
                    Date="29/10/2022",
                    Explanation="Papara .NET Bootcamp",
                    Type="Economist"
                },
                new OwnerModel
                {
                    Id=3,
                    Name="Tamer",
                    Surname="Şahin",
                    Date="29/10/2022",
                    Explanation="Doing Hack",
                    Type="Hacker"
                },
            };
        }
    }
}
