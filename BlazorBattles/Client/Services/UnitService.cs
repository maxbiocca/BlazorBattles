using BlazorBattles.Shared;
using System.Net.Http.Json;

namespace BlazorBattles.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly HttpClient _http;

        public UnitService(HttpClient http)
        {
            _http = http;
        }
        public IList<Unit> Units { get; set; } = new List<Unit>();
       
        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();
        IList<Unit> IUnitService.Units { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId =unit.Id, HitPoints = unit.HitPoints });

        }

        public async Task LoadUnitAsync()
        {
            if (Units.Count == 0)
            {
                Units = await _http.GetFromJsonAsync<IList<Unit>>("api/Unit");
            }
        }
    }
}