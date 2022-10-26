using BlazorBattles.Shared;
using System.Net.Http.Json;
using System.Linq;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {

   //     private readonly HttpClient _http;

        //public UnitService(HttpClient http){

//            _http = http;
       //}

        public IList<Unit> Units => new List<Unit>
        {
            new Unit() {Id=1, Title = "Knight", Attack=10, Defense=10, BananaCost=100},
            new Unit() {Id=2, Title = "Archer", Attack=15, Defense=5, BananaCost=150},
            new Unit() {Id=3, Title = "Mage", Attack=20, Defense=1, BananaCost=200}
        };
        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

       


        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });

        }

        public Task LoadUnitsAsync()
        {
            throw new Exception();
        } 



        //public async Task LoadUnitsAsync(){
        //if (Units.Count == 0)
        //{
        //  Units = await  _http.GetFromJsonAsync<IList<Unit>>("api/Unit");
        //}
        //}
    }
}

